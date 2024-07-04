using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_thu_vien
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            tb_matkhau.Text = "";
            tb_tendangnhap.Text = "";
        }
    }
}
