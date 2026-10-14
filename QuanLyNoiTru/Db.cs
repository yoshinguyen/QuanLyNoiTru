using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLyNoiTru
{
    /// <summary>Một câu lệnh SQL kèm tham số (dùng để chạy trong transaction).</summary>
    public class Stmt
    {
        public string Sql;
        public SqlParameter[] Ps;
        public Stmt(string sql, params SqlParameter[] ps) { Sql = sql; Ps = ps; }
    }

    public static class Db
    {
        // >>> SỬA CHUỖI KẾT NỐI Ở ĐÂY cho đúng máy của bạn <<<
        // SQL Server Express : Server=.\SQLEXPRESS
        // SQL Server thường  : Server=.   hoặc   Server=localhost
        // LocalDB            : Server=(localdb)\MSSQLLocalDB
        public static string ConnStr =
            @"Data Source=.\DBCUATAO;Initial Catalog=QuanLyBenhNhanNoiTru1234;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>Tạo tham số. Chuỗi rỗng / null được lưu thành NULL.</summary>
        public static SqlParameter P(string name, object value)
        {
            var s = value as string;
            if (value == null || (s != null && s.Trim().Length == 0)) value = DBNull.Value;
            return new SqlParameter(name, value);
        }

        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using (var cn = new SqlConnection(ConnStr))
            using (var da = new SqlDataAdapter(sql, cn))
            {
                if (ps != null) da.SelectCommand.Parameters.AddRange(ps);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int Exec(string sql, params SqlParameter[] ps)
        {
            using (var cn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] ps)
        {
            using (var cn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                cn.Open();
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>Chạy nhiều câu lệnh trong 1 transaction: hoặc thành công hết, hoặc huỷ hết.</summary>
        public static void ExecTx(params Stmt[] stmts)
        {
            using (var cn = new SqlConnection(ConnStr))
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        foreach (var st in stmts)
                        {
                            using (var cmd = new SqlCommand(st.Sql, cn, tx))
                            {
                                if (st.Ps != null) cmd.Parameters.AddRange(st.Ps);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>Sinh mã tiếp theo, ví dụ NextId("BENHNHAN","MaBN","BN") -> BN05.</summary>
        public static string NextId(string table, string col, string prefix)
        {
            string sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(" + col + ", " + (prefix.Length + 1) +
                         ", 10) AS INT)), 0) + 1 FROM " + table +
                         " WHERE " + col + " LIKE '" + prefix + "[0-9]%'";
            int n = Convert.ToInt32(Scalar(sql));
            return prefix + n.ToString("D2");
        }
    }

    /// <summary>Người đăng nhập hiện tại (chỉ có 1 tài khoản admin, không phân quyền).</summary>
    public static class Session
    {
        public static string FullName = "Admin";
    }

    public static class Fmt
    {
        static readonly CultureInfo Vn = new CultureInfo("vi-VN");
        public static string Money(decimal d) { return d.ToString("N0", Vn) + " đ"; }
    }
}
