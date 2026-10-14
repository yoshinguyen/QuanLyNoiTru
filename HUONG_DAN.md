# Quản lý hồ sơ bệnh nhân nội trú (WinForms C# + SQL Server)

## Cách chạy
1. Mở **SQL Server Management Studio**, chạy file `Database.sql` (file cũ của bạn, không thay đổi) để tạo database kèm dữ liệu mẫu.
2. Mở `QuanLyNoiTru.csproj` bằng **Visual Studio**
   (cần workload ".NET desktop development" và .NET Framework 4.8 targeting pack).
3. Mở `Db.cs`, sửa `ConnStr` cho đúng tên SQL Server của máy bạn
   (`.\SQLEXPRESS`, `.`, `localhost`, hoặc `(localdb)\MSSQLLocalDB`).
4. Bấm **F5**.

## Đăng nhập
Tạo 1 database mới theo file db.txt.
Chỉ có **1 tài khoản admin** (`1` / `1`), không phân quyền: đăng nhập là dùng được mọi chức năng.

## Sửa giao diện bằng Designer
Mỗi form có 2 file: `XxxForm.cs` (xử lý) và `XxxForm.Designer.cs` (giao diện).
Trong Visual Studio **bấm đúp `XxxForm.cs` (hoặc chuột phải → View Designer)** để kéo thả, đổi kích thước, đổi chữ, đổi màu control.
Không sửa tay nội dung `InitializeComponent` trong file Designer nếu không cần.

| Form | File | Chức năng |
|---|---|---|
| Đăng nhập | `LoginForm` | Đăng nhập admin |
| Form chính | `MainForm` | Menu trái, nhúng form con vào panel phải |
| Bệnh nhân | `BenhNhanForm` | Thêm/sửa/xóa/tìm kiếm, **nhập từ file, xuất ra file** |
| Bác sĩ | `BacSiForm` | Thêm/sửa/xóa/tìm kiếm, **nhập từ file, xuất ra file** |
| Nhập viện | `NhapVienForm` | Khoa → Phòng → Giường + bác sĩ, ra viện, hủy; xuất file |
| Bệnh án | `BenhAnForm` | Mỗi lần khám 1 dòng; xuất file |
| Đơn thuốc | `DonThuocForm` | Thêm/sửa/xóa thuốc, tự trừ/cộng tồn kho; xuất file |
| Viện phí | `VienPhiForm` | Tính tiền, lưu, thanh toán, in hóa đơn; xuất file |
| Báo cáo | `BaoCaoForm` | 6 ô thống kê, 5 báo cáo, in / xuất PDF / xuất Excel-CSV |

File dùng chung: `BaseForm.cs` (thông báo, nhập/xuất file), `Db.cs` (kết nối SQL), `Export.cs` (đọc/ghi .xlsx, .csv, in ấn).

## Nhập / xuất file
- **Xuất**: nút **Xuất ra file** ở mọi form có danh sách → chọn đuôi `.xlsx` (Excel) hoặc `.csv`.
- **Nhập** (Bệnh nhân, Bác sĩ): bấm **Nhập từ file**, chọn file `.xlsx` hoặc `.csv`.
  - Dòng đầu là tiêu đề cột. Cách dễ nhất: **xuất ra file trước để lấy file mẫu**, thêm dòng rồi nhập lại.
  - Bệnh nhân cần: `Họ tên`, `Ngày sinh` (dd/MM/yyyy), `Giới tính`, `CCCD` (12 số, có thể trống), `SĐT`, `Địa chỉ`, `Nghề nghiệp`, `Người thân`, `SĐT người thân`, `Tình trạng bệnh`.
  - Bác sĩ cần: `Họ tên`, `Ngày sinh`, `Giới tính`, `Chuyên khoa`, `SĐT`, `Email`, `Khoa` (đúng tên khoa) hoặc `Mã khoa`, `Đang làm việc` (Có/Không).
  - Cột `Mã BN` / `Mã BS` trong file được bỏ qua, hệ thống tự sinh mã mới. Dòng lỗi (thiếu họ tên, ngày sinh sai, CCCD sai, trùng...) bị bỏ qua và được liệt kê sau khi nhập.

## Quy tắc nghiệp vụ
- Chỉ chọn được giường đang **Trống**; tạo hồ sơ → giường thành **Đang sử dụng**; ra viện / hủy → giường trả về **Trống**.
- Một bệnh nhân chỉ có 1 hồ sơ **Đang điều trị** tại một thời điểm.
- Tiền phòng = số ngày nằm × đơn giá phòng (tính cả ngày vào và ngày ra, tối thiểu 1 ngày).
- Tiền thuốc = tổng thành tiền các đơn thuốc của lần nhập viện đó.
- Hóa đơn đã thanh toán thì không sửa được.
- Thêm/sửa/xóa thuốc trong đơn tự trừ/cộng lại tồn kho.

## Lưu ý
- Xuất PDF dùng máy in ảo "Microsoft Print to PDF" (có sẵn trên Windows 10/11).
- Mật khẩu đang lưu dạng chữ thường để khớp dữ liệu mẫu; sản phẩm thật nên băm (SHA-256/bcrypt).
