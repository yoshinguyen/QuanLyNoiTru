using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>
    /// Viện phí: tiền phòng = số ngày nằm x đơn giá phòng (tính cả ngày vào và ngày ra, tối thiểu 1 ngày);
    /// tiền thuốc = tổng thành tiền các đơn thuốc của lần nhập viện; tiền khám / dịch vụ nhập tay.
    /// Giao diện: VienPhiForm.Designer.cs
    /// </summary>
    public partial class VienPhiForm : BaseForm
    {
        // dữ liệu tính toán hiện tại
        decimal tienPhong, tienThuoc;
        int soNgay;
        string maVP = "", trangThai = "Chưa lập";
        string maBN = "", tenBN = "", tenBS = "", tenPhong = "";
        DateTime vao;
        DateTime? ra;
        bool loading;        // true: đang gán giá trị cho ô số tiền, chưa tính tổng
        bool ready;          // false: đang dựng form

        public VienPhiForm()
        {
            InitializeComponent();
            Bind(cmbNV,
                Db.Query(@"SELECT nv.MaNhapVien,
                                  nv.MaNhapVien + N' - ' + bn.HoTen + N' (' + nv.TrangThai + N')' AS Hien
                           FROM NHAPVIEN nv JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
                           WHERE nv.TrangThai <> N'Hủy'
                           ORDER BY nv.NgayNhapVien DESC"),
                "Hien", "MaNhapVien");
            LoadData();
            ready = true;
            Tinh(true);
        }

        void LoadData()
        {
            dgv.DataSource = Db.Query(
                @"SELECT vp.MaVP AS [Mã VP], vp.MaNhapVien AS [Mã NV], bn.HoTen AS [Bệnh nhân],
                         vp.TienPhong AS [Tiền phòng], vp.TienThuoc AS [Tiền thuốc], vp.TienKham AS [Tiền khám],
                         vp.TienDichVu AS [Tiền dịch vụ], vp.TongTien AS [Tổng tiền], vp.NgayLap AS [Ngày lập],
                         vp.TrangThai AS [Trạng thái]
                  FROM VIENPHI vp
                  JOIN NHAPVIEN nv ON nv.MaNhapVien = vp.MaNhapVien
                  JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
                  ORDER BY vp.NgayLap DESC");
            foreach (var c in new[] { "Tiền phòng", "Tiền thuốc", "Tiền khám", "Tiền dịch vụ", "Tổng tiền" }) FmtCol(dgv, c, "N0");
            FmtCol(dgv, "Ngày lập", "dd/MM/yyyy HH:mm");
        }

        /// <summary>Tính tiền phòng + thuốc từ dữ liệu. loadSaved = true: nạp luôn tiền khám/dịch vụ đã lưu.</summary>
        void Tinh(bool loadSaved)
        {
            string nv = Val(cmbNV);
            if (nv == null) return;

            var dt = Db.Query(
                @"SELECT nv.NgayNhapVien, nv.NgayRaVien, bn.MaBN, bn.HoTen AS TenBN,
                         ISNULL(bs.HoTen, N'') AS TenBS, ISNULL(p.TenPhong, N'') AS TenPhong, ISNULL(p.DonGia, 0) AS DonGiaPhong,
                         ISNULL((SELECT SUM(ct.ThanhTien)
                                 FROM CT_DONTHUOC ct
                                 JOIN DONTHUOC d ON d.MaDon = ct.MaDon
                                 JOIN BENHAN ba ON ba.MaBA = d.MaBA
                                 WHERE ba.MaNhapVien = nv.MaNhapVien), 0) AS TienThuoc
                  FROM NHAPVIEN nv
                  JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
                  LEFT JOIN BACSI bs ON bs.MaBS = nv.MaBS
                  LEFT JOIN GIUONG g ON g.MaGiuong = nv.MaGiuong
                  LEFT JOIN PHONG p ON p.MaPhong = g.MaPhong
                  WHERE nv.MaNhapVien = @nv", Db.P("@nv", nv));
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            vao = (DateTime)r["NgayNhapVien"];
            ra = r["NgayRaVien"] == DBNull.Value ? (DateTime?)null : (DateTime)r["NgayRaVien"];
            maBN = r["MaBN"].ToString();
            tenBN = r["TenBN"].ToString();
            tenBS = r["TenBS"].ToString();
            tenPhong = r["TenPhong"].ToString();
            decimal donGia = Convert.ToDecimal(r["DonGiaPhong"]);

            DateTime den = ra ?? DateTime.Now;
            soNgay = Math.Max(1, (den.Date - vao.Date).Days + 1);
            tienPhong = soNgay * donGia;
            tienThuoc = Convert.ToDecimal(r["TienThuoc"]);

            // hóa đơn đã lưu (nếu có)
            var vp = Db.Query("SELECT MaVP, TienPhong, TienThuoc, TienKham, TienDichVu, TrangThai FROM VIENPHI WHERE MaNhapVien=@nv", Db.P("@nv", nv));
            loading = true;
            if (vp.Rows.Count > 0)
            {
                maVP = vp.Rows[0]["MaVP"].ToString();
                trangThai = vp.Rows[0]["TrangThai"].ToString();
                if (trangThai == "Đã thanh toán")   // đã thanh toán: giữ nguyên số liệu đã chốt
                {
                    tienPhong = Convert.ToDecimal(vp.Rows[0]["TienPhong"]);
                    tienThuoc = Convert.ToDecimal(vp.Rows[0]["TienThuoc"]);
                }
                if (loadSaved || trangThai == "Đã thanh toán")
                {
                    nudKham.Value = Convert.ToDecimal(vp.Rows[0]["TienKham"]);
                    nudDV.Value = Convert.ToDecimal(vp.Rows[0]["TienDichVu"]);
                }
            }
            else
            {
                maVP = "";
                trangThai = "Chưa lập";
                if (loadSaved) { nudKham.Value = 0; nudDV.Value = 0; }
            }
            loading = false;

            txtMaVP.Text = maVP;
            txtTrangThai.Text = trangThai;
            txtSoNgay.Text = soNgay.ToString();
            txtDonGia.Text = Fmt.Money(donGia);
            txtPhong.Text = Fmt.Money(tienPhong);
            txtThuoc.Text = Fmt.Money(tienThuoc);
            UpdateTong();
        }

        void UpdateTong()
        {
            if (loading) return;
            txtTong.Text = Fmt.Money(tienPhong + tienThuoc + nudKham.Value + nudDV.Value);
        }

        // ---------- sự kiện ----------

        void cmbNV_SelectedIndexChanged(object sender, EventArgs e) { if (ready) Tinh(true); }

        void nudTien_ValueChanged(object sender, EventArgs e) { if (ready) UpdateTong(); }

        void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (!ready) return;
            var r = dgv.CurrentRow;
            if (r != null && S(r, "Mã NV") != "" && Val(cmbNV) != S(r, "Mã NV")) cmbNV.SelectedValue = S(r, "Mã NV");
        }

        void btnTinh_Click(object sender, EventArgs e) { Tinh(false); }

        void btnLamMoi_Click(object sender, EventArgs e) { LoadData(); Tinh(true); }

        void btnXuat_Click(object sender, EventArgs e) { XuatFile(dgv, "VienPhi"); }

        void btnLuu_Click(object sender, EventArgs e)
        {
            string nv = Val(cmbNV);
            if (nv == null) { Warn("Hãy chọn hồ sơ nhập viện."); return; }
            try
            {
                Tinh(false);
                if (trangThai == "Đã thanh toán") { Warn("Hóa đơn đã thanh toán, không thể sửa."); return; }

                if (maVP == "")
                {
                    string ma = Db.NextId("VIENPHI", "MaVP", "VP");
                    Db.Exec(@"INSERT INTO VIENPHI(MaVP, MaNhapVien, TienPhong, TienThuoc, TienKham, TienDichVu, TrangThai)
                              VALUES(@ma, @nv, @phong, @thuoc, @kham, @dv, N'Chưa thanh toán')",
                        Db.P("@ma", ma), Db.P("@nv", nv), Db.P("@phong", tienPhong), Db.P("@thuoc", tienThuoc),
                        Db.P("@kham", nudKham.Value), Db.P("@dv", nudDV.Value));
                }
                else
                {
                    Db.Exec(@"UPDATE VIENPHI SET TienPhong=@phong, TienThuoc=@thuoc, TienKham=@kham, TienDichVu=@dv, NgayLap=GETDATE()
                              WHERE MaVP=@ma",
                        Db.P("@phong", tienPhong), Db.P("@thuoc", tienThuoc),
                        Db.P("@kham", nudKham.Value), Db.P("@dv", nudDV.Value), Db.P("@ma", maVP));
                }
                LoadData();
                Tinh(true);
                Msg("Đã lưu hóa đơn viện phí.");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (maVP == "") { Warn("Chưa có hóa đơn. Hãy bấm \"Lưu hóa đơn\" trước."); return; }
            if (trangThai == "Đã thanh toán") { Msg("Hóa đơn này đã thanh toán rồi."); return; }
            if (!Confirm("Xác nhận bệnh nhân đã thanh toán hóa đơn " + maVP + "?")) return;
            try
            {
                Db.Exec("UPDATE VIENPHI SET TrangThai = N'Đã thanh toán' WHERE MaVP = @ma", Db.P("@ma", maVP));
                LoadData();
                Tinh(true);
            }
            catch (Exception ex) { Err(ex); }
        }

        static string Row(string label, decimal amount)
        {
            return label.PadRight(32) + Fmt.Money(amount).PadLeft(28);
        }
    }
}
