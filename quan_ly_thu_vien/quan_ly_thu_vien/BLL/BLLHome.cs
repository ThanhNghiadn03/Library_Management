using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_thu_vien.BLL
{
    class BLLHome
    {
        DAL.DALLogin_Register dal_login_register;
        //GUI.Login login = null;
        public BLLHome()
        {
            dal_login_register = new DAL.DALLogin_Register();
        }
    }
}
