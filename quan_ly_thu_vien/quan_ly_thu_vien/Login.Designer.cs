namespace quan_ly_thu_vien
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_dangnhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tendangnhap = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.bt_nhaplai = new System.Windows.Forms.Button();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.link_dk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_dangnhap
            // 
            this.label_dangnhap.AutoSize = true;
            this.label_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dangnhap.Location = new System.Drawing.Point(320, 56);
            this.label_dangnhap.Name = "label_dangnhap";
            this.label_dangnhap.Size = new System.Drawing.Size(170, 33);
            this.label_dangnhap.TabIndex = 0;
            this.label_dangnhap.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // tb_tendangnhap
            // 
            this.tb_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tendangnhap.Location = new System.Drawing.Point(388, 127);
            this.tb_tendangnhap.Name = "tb_tendangnhap";
            this.tb_tendangnhap.Size = new System.Drawing.Size(201, 29);
            this.tb_tendangnhap.TabIndex = 3;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_matkhau.Location = new System.Drawing.Point(388, 190);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(201, 29);
            this.tb_matkhau.TabIndex = 4;
            this.tb_matkhau.UseSystemPasswordChar = true;
            // 
            // bt_nhaplai
            // 
            this.bt_nhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhaplai.Location = new System.Drawing.Point(242, 295);
            this.bt_nhaplai.Name = "bt_nhaplai";
            this.bt_nhaplai.Size = new System.Drawing.Size(120, 43);
            this.bt_nhaplai.TabIndex = 5;
            this.bt_nhaplai.Text = "Nhập Lại";
            this.bt_nhaplai.UseVisualStyleBackColor = true;
            this.bt_nhaplai.Click += new System.EventHandler(this.bt_nhaplai_Click);
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.Location = new System.Drawing.Point(434, 295);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(120, 43);
            this.bt_dangnhap.TabIndex = 6;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            // 
            // link_dk
            // 
            this.link_dk.AutoSize = true;
            this.link_dk.Location = new System.Drawing.Point(498, 241);
            this.link_dk.Name = "link_dk";
            this.link_dk.Size = new System.Drawing.Size(143, 13);
            this.link_dk.TabIndex = 7;
            this.link_dk.TabStop = true;
            this.link_dk.Text = "Chưa có tài khoản? Đăng ký";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link_dk);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.bt_nhaplai);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_tendangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_dangnhap);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tendangnhap;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button bt_nhaplai;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.LinkLabel link_dk;
    }
}