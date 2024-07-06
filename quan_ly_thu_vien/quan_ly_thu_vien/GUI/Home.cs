using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_thu_vien.GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.xinchao.Text = "Xin chào " + DAL.DALLogin_Register.account[0]+"!";
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DAL.DALLogin_Register.account = new string[]{null,null};
            GUI.Login login = new GUI.Login();
            login.Show();
            this.Hide();
            login.FormClosed += (s, arg) => this.Close();
        }
    }
}
