using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Data;

namespace quan_ly_thu_vien.DAL
{
    class DBAccessControl
    {
        String diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\DTU\\thirdyear-summer\\DotNet\\personal project\\quan_ly_thu_vien\\quan_ly_thu_vien\\AppData\\ThuVienDB.mdf;Integrated Security=True";
        SqlConnection conn;
        public DBAccessControl()
        {
            conn = new SqlConnection(diaChi);
        }
        public void Nonquery(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Truy vấn thành công");
            }
            else MessageBox.Show("Truy vấn thất bại");
        }
        public object Scalar(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = (int)comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDaTa(String sqlData)
        {
            SqlConnection conn = new SqlConnection(diaChi);
            SqlDataAdapter da = new SqlDataAdapter(sqlData, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
