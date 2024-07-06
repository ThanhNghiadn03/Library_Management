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
    public partial class Register : Form
    {
        BLL.BLLLogin_Register bll_login_register;
        public Register()
        {
            InitializeComponent();
            bll_login_register = new BLL.BLLLogin_Register();
        }

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            bll_login_register.BLLRegister(tb_hoten.Text, tb_tendangnhap.Text, tb_matkhau.Text);
            tb_hoten.Text = "";
            tb_tendangnhap.Text = "";
            tb_matkhau.Text = "";
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            tb_hoten.Text = "";
            tb_tendangnhap.Text = "";
            tb_matkhau.Text = "";
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            GUI.Login login = new GUI.Login();
            login.Show();
            this.Hide();
            login.FormClosed += (s, arg) => this.Close();
        }
    }
}
