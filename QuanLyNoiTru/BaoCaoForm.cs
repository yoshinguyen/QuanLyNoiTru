using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>
    /// Thống kê nhanh (6 ô số liệu) + báo cáo dạng bảng: xem, in, xuất PDF, xuất Excel/CSV.
    /// Giao diện: BaoCaoForm.Designer.cs
    /// </summary>
    public partial class BaoCaoForm : BaseForm
    {
        DataTable current;
        bool ready;

        static readonly string[] Names =
        {
            "Danh sách bệnh nhân đang điều trị",
            "Danh sách tất cả bệnh nhân",
            "Danh sách hồ sơ nhập viện",
            "Danh sách viện phí",
            "Thống kê số bệnh nhân đang điều trị theo khoa"
        };

        static readonly string[] Queries =
        {
            @"SELECT bn.MaBN AS [Mã BN], bn.HoTen AS [Họ tên], bn.NgaySinh AS [Ngày sinh], bn.GioiTinh AS [Giới tính],
                     k.TenKhoa AS [Khoa], p.TenPhong AS [Phòng], g.SoGiuong AS [Giường], bs.HoTen AS [Bác sĩ],
                     nv.NgayNhapVien AS [Ngày vào viện], bn.TinhTrang AS [Tình trạng bệnh]
              FROM NHAPVIEN nv
              JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
              LEFT JOIN BACSI bs ON bs.MaBS = nv.MaBS
              LEFT JOIN GIUONG g ON g.MaGiuong = nv.MaGiuong
              LEFT JOIN PHONG p ON p.MaPhong = g.MaPhong
              LEFT JOIN KHOA k ON k.MaKhoa = p.MaKhoa
              WHERE nv.TrangThai = N'Đang điều trị'
              ORDER BY nv.NgayNhapVien",

            @"SELECT MaBN AS [Mã BN], HoTen AS [Họ tên], NgaySinh AS [Ngày sinh], GioiTinh AS [Giới tính], CCCD AS [CCCD],
                     SoDienThoai AS [SĐT], DiaChi AS [Địa chỉ], NgheNghiep AS [Nghề nghiệp], TinhTrang AS [Tình trạng bệnh]
              FROM BENHNHAN ORDER BY MaBN",

            @"SELECT nv.MaNhapVien AS [Mã NV], bn.HoTen AS [Bệnh nhân], bs.HoTen AS [Bác sĩ], p.TenPhong AS [Phòng],
                     nv.MaGiuong AS [Giường], nv.NgayNhapVien AS [Ngày vào viện], nv.NgayRaVien AS [Ngày ra viện],
                     nv.LyDoNhapVien AS [Lý do], nv.TrangThai AS [Trạng thái]
              FROM NHAPVIEN nv
              JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
              LEFT JOIN BACSI bs ON bs.MaBS = nv.MaBS
              LEFT JOIN GIUONG g ON g.MaGiuong = nv.MaGiuong
              LEFT JOIN PHONG p ON p.MaPhong = g.MaPhong
              ORDER BY nv.NgayNhapVien DESC",

            @"SELECT vp.MaVP AS [Mã VP], bn.HoTen AS [Bệnh nhân], vp.TienPhong AS [Tiền phòng], vp.TienThuoc AS [Tiền thuốc],
                     vp.TienKham AS [Tiền khám], vp.TienDichVu AS [Tiền dịch vụ], vp.TongTien AS [Tổng tiền],
                     vp.NgayLap AS [Ngày lập], vp.TrangThai AS [Trạng thái]
              FROM VIENPHI vp
              JOIN NHAPVIEN nv ON nv.MaNhapVien = vp.MaNhapVien
              JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
              ORDER BY vp.NgayLap DESC",

            @"SELECT k.TenKhoa AS [Khoa], COUNT(nv.MaNhapVien) AS [Số bệnh nhân đang điều trị]
              FROM KHOA k
              LEFT JOIN PHONG p ON p.MaKhoa = k.MaKhoa
              LEFT JOIN GIUONG g ON g.MaPhong = p.MaPhong
              LEFT JOIN NHAPVIEN nv ON nv.MaGiuong = g.MaGiuong AND nv.TrangThai = N'Đang điều trị'
              GROUP BY k.MaKhoa, k.TenKhoa
              ORDER BY k.MaKhoa"
        };

        public BaoCaoForm()
        {
            InitializeComponent();
            cmbBC.Items.AddRange(Names);
            cmbBC.SelectedIndex = 0;
            ready = true;
            LoadReport();
        }

        void LoadStats()
        {
            var dt = Db.Query(
                @"SELECT (SELECT COUNT(*) FROM BENHNHAN) AS TongBN,
                         (SELECT COUNT(*) FROM NHAPVIEN WHERE TrangThai = N'Đang điều trị') AS DangDT,
                         (SELECT COUNT(*) FROM NHAPVIEN WHERE TrangThai = N'Đã ra viện') AS DaRa,
                         (SELECT COUNT(*) FROM GIUONG WHERE TrangThai = N'Trống') AS GiuongTrong,
                         (SELECT COUNT(*) FROM GIUONG) AS TongGiuong,
                         ISNULL((SELECT SUM(TongTien) FROM VIENPHI WHERE TrangThai = N'Đã thanh toán'), 0) AS DaThu,
                         ISNULL((SELECT SUM(TongTien) FROM VIENPHI WHERE TrangThai = N'Chưa thanh toán'), 0) AS ChuaThu");
            var r = dt.Rows[0];
            vTong.Text = r["TongBN"].ToString();
            vDangDT.Text = r["DangDT"].ToString();
            vDaRa.Text = r["DaRa"].ToString();
            vGiuong.Text = r["GiuongTrong"] + " / " + r["TongGiuong"];
            vDaThu.Text = Fmt.Money(Convert.ToDecimal(r["DaThu"]));
            vChuaThu.Text = Fmt.Money(Convert.ToDecimal(r["ChuaThu"]));
        }

        void LoadReport()
        {
            try
            {
                LoadStats();
                current = Db.Query(Queries[cmbBC.SelectedIndex]);
                dgv.DataSource = current;
                foreach (DataGridViewColumn c in dgv.Columns)
                    if (c.ValueType == typeof(decimal)) c.DefaultCellStyle.Format = "N0";
                FmtCol(dgv, "Ngày sinh", "dd/MM/yyyy");
                FmtCol(dgv, "Ngày vào viện", "dd/MM/yyyy HH:mm");
                FmtCol(dgv, "Ngày ra viện", "dd/MM/yyyy HH:mm");
                FmtCol(dgv, "Ngày lập", "dd/MM/yyyy HH:mm");
            }
            catch (Exception ex) { Err(ex); }
        }

        string TieuDe { get { return cmbBC.Text.ToUpper(); } }

        // sukien

        void cmbBC_SelectedIndexChanged(object sender, EventArgs e) { if (ready) LoadReport(); }
        //in xsl
        void btnExcel_Click(object sender, EventArgs e) { XuatFile(dgv, "BaoCao"); }
    }
}
