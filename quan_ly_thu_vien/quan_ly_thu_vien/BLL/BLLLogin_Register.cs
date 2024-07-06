using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_thu_vien.BLL
{
    class BLLLogin_Register
    {
        DAL.DALLogin_Register dal_login_register;
        GUI.Login login = null;
        public BLLLogin_Register(GUI.Login login)
        {
            dal_login_register = new DAL.DALLogin_Register();
            this.login = login;
        }

        public void BLLLogin(string username, string password)
        {
            bool isLogin = dal_login_register.DALLogin(username, password);
            if(isLogin)
            {
                login.
            }
        }
    }
}
