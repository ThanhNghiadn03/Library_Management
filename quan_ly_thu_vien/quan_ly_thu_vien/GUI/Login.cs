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
    public partial class Login : Form
    {
        BLL.BLLLogin_Register bll_login_register;
        public Login()
        {
            InitializeComponent();
            bll_login_register = new BLL.BLLLogin_Register();
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            tb_matkhau.Text = "";
            tb_tendangnhap.Text = "";
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            bool isLogin = bll_login_register.BLLLogin(tb_tendangnhap.Text, tb_matkhau.Text);
            if(isLogin)
            {
                //GUI.Login login = new GUI.Login();
                GUI.Home home = new GUI.Home();
                home.Show();
                this.Hide();
                home.FormClosed += (s, args) => this.Close();
            }
        }

        private void link_dk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI.Register register = new GUI.Register();
            register.Show();
            this.Hide();
            register.FormClosed += (s, args) => this.Close();
        }
    }
}
