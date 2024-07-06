using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_thu_vien.DAL
{
    class DALLogin_Register
    {
        DBAccessControl db;
        public static string[] account;

        public DALLogin_Register()
        {
            db = new DBAccessControl();
            account = new string[2];
            account[0] = null;
            account[1] = null;
        }

        public bool DALCheckExistAccount(string fullName, string username)
        {
            bool isExist = false;
            string sqlCheckExist = "select count(*) from Librarians where libFullName=N'" + fullName + "'or username = '" +
                                    username + "';";
            int kq= (int)db.Scalar(sqlCheckExist);
            isExist = kq > 0 ? true : false;
            return isExist;
        }

        public bool DALLogin(string username, string password)
        {
            string sqlLogin = "select count(*) from Librarians where username = '" + 
                username + "' and pass_word = '" + password + "';";
            int kq = (int)db.Scalar(sqlLogin);
            if (kq == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return false;
            } else
            {
                account = new string[]{username, password};
                MessageBox.Show("Đăng nhập thành công");
                return true; 
            }
        }

        public void DALRegister(string fullName, string username, string password)
        {
            if(!DALCheckExistAccount(fullName,username))
            {
                string sqlAddNewAccount = "insert into Librarians (libFullName,username,pass_word) values (N'"+
                    fullName + "', '" + username + "','" + password + "');";
                db.Nonquery(sqlAddNewAccount);
                MessageBox.Show("Đăng kí tài khoản thành công");
            } else
            {
                MessageBox.Show("Tài khoản này đã tồn tại");
            }
        }
    }
}
