namespace QLKTX.View.FormView
{
    partial class User
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
            this.panelTitleBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.icbtMin = new FontAwesome.Sharp.IconButton();
            this.icbtClose = new FontAwesome.Sharp.IconButton();
            this.icbtMax = new FontAwesome.Sharp.IconButton();
            this.icbtLogOut = new FontAwesome.Sharp.IconButton();
            this.btnChangePass = new FontAwesome.Sharp.IconButton();
            this.icbtTongQuan = new FontAwesome.Sharp.IconButton();
            this.icbtHoaDon = new FontAwesome.Sharp.IconButton();
            this.icbtThongTin = new FontAwesome.Sharp.IconButton();
            this.icbtMenu = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Gray;
            this.panelTitleBar.Controls.Add(this.guna2HtmlLabel2);
            this.panelTitleBar.Controls.Add(this.icbtMin);
            this.panelTitleBar.Controls.Add(this.icbtClose);
            this.panelTitleBar.Controls.Add(this.icbtMax);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelTitleBar.FillColor2 = System.Drawing.Color.Yellow;
            this.panelTitleBar.FillColor3 = System.Drawing.Color.Wheat;
            this.panelTitleBar.FillColor4 = System.Drawing.Color.LightSalmon;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1071, 40);
            this.panelTitleBar.TabIndex = 11;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Enabled = false;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DeepPink;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(349, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(331, 20);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "CHƯƠNG TRÌNH QUẢN LÝ KÝ TÚC XÁ";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.icbtMenu);
            this.panelLogo.Controls.Add(this.iconPictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 114);
            this.panelLogo.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Enabled = false;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(276, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(331, 20);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "CHƯƠNG TRÌNH QUẢN LÝ KÝ TÚC XÁ";
            // 
            // panelMenu
            // 
            this.panelMenu.AllowDrop = true;
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panelMenu.Controls.Add(this.icbtLogOut);
            this.panelMenu.Controls.Add(this.btnChangePass);
            this.panelMenu.Controls.Add(this.icbtTongQuan);
            this.panelMenu.Controls.Add(this.icbtHoaDon);
            this.panelMenu.Controls.Add(this.icbtThongTin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 761);
            this.panelMenu.TabIndex = 10;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackgroundImage = global::QLKTX.Properties.Resources.hostel;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 40);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1071, 721);
            this.panelDesktop.TabIndex = 12;
            // 
            // icbtMin
            // 
            this.icbtMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbtMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.icbtMin.FlatAppearance.BorderSize = 0;
            this.icbtMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtMin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtMin.ForeColor = System.Drawing.Color.White;
            this.icbtMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.icbtMin.IconColor = System.Drawing.Color.Black;
            this.icbtMin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icbtMin.IconSize = 20;
            this.icbtMin.Location = new System.Drawing.Point(951, 0);
            this.icbtMin.Name = "icbtMin";
            this.icbtMin.Size = new System.Drawing.Size(45, 25);
            this.icbtMin.TabIndex = 15;
            this.icbtMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtMin.UseVisualStyleBackColor = false;
            this.icbtMin.Click += new System.EventHandler(this.icbtMin_Click);
            // 
            // icbtClose
            // 
            this.icbtClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbtClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.icbtClose.FlatAppearance.BorderSize = 0;
            this.icbtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtClose.ForeColor = System.Drawing.Color.White;
            this.icbtClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.icbtClose.IconColor = System.Drawing.Color.Black;
            this.icbtClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtClose.IconSize = 20;
            this.icbtClose.Location = new System.Drawing.Point(1035, 0);
            this.icbtClose.Name = "icbtClose";
            this.icbtClose.Size = new System.Drawing.Size(45, 25);
            this.icbtClose.TabIndex = 14;
            this.icbtClose.UseVisualStyleBackColor = false;
            this.icbtClose.Click += new System.EventHandler(this.icbtClose_Click);
            // 
            // icbtMax
            // 
            this.icbtMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbtMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.icbtMax.FlatAppearance.BorderSize = 0;
            this.icbtMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtMax.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtMax.ForeColor = System.Drawing.Color.White;
            this.icbtMax.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.icbtMax.IconColor = System.Drawing.Color.Black;
            this.icbtMax.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icbtMax.IconSize = 20;
            this.icbtMax.Location = new System.Drawing.Point(993, 0);
            this.icbtMax.Name = "icbtMax";
            this.icbtMax.Size = new System.Drawing.Size(45, 25);
            this.icbtMax.TabIndex = 13;
            this.icbtMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtMax.UseVisualStyleBackColor = false;
            this.icbtMax.Click += new System.EventHandler(this.icbtMax_Click);
            // 
            // icbtLogOut
            // 
            this.icbtLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.icbtLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.icbtLogOut.FlatAppearance.BorderSize = 0;
            this.icbtLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtLogOut.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtLogOut.ForeColor = System.Drawing.Color.Cornsilk;
            this.icbtLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.icbtLogOut.IconColor = System.Drawing.Color.Cornsilk;
            this.icbtLogOut.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icbtLogOut.IconSize = 30;
            this.icbtLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtLogOut.Location = new System.Drawing.Point(0, 706);
            this.icbtLogOut.Name = "icbtLogOut";
            this.icbtLogOut.Size = new System.Drawing.Size(230, 55);
            this.icbtLogOut.TabIndex = 9;
            this.icbtLogOut.Tag = "Đăng Xuất";
            this.icbtLogOut.Text = "Đăng Xuất";
            this.icbtLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtLogOut.UseVisualStyleBackColor = false;
            this.icbtLogOut.Click += new System.EventHandler(this.icbtLogOut_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnChangePass.IconColor = System.Drawing.Color.Cornsilk;
            this.btnChangePass.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnChangePass.IconSize = 30;
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.Location = new System.Drawing.Point(0, 279);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(230, 55);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Tag = "Đổi mật khẩu";
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // icbtTongQuan
            // 
            this.icbtTongQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.icbtTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtTongQuan.FlatAppearance.BorderSize = 0;
            this.icbtTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtTongQuan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtTongQuan.ForeColor = System.Drawing.Color.White;
            this.icbtTongQuan.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.icbtTongQuan.IconColor = System.Drawing.Color.Cornsilk;
            this.icbtTongQuan.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icbtTongQuan.IconSize = 30;
            this.icbtTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtTongQuan.Location = new System.Drawing.Point(0, 224);
            this.icbtTongQuan.Name = "icbtTongQuan";
            this.icbtTongQuan.Size = new System.Drawing.Size(230, 55);
            this.icbtTongQuan.TabIndex = 5;
            this.icbtTongQuan.Tag = "Tổng quan KTX";
            this.icbtTongQuan.Text = "Tổng quan KTX";
            this.icbtTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtTongQuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtTongQuan.UseVisualStyleBackColor = false;
            // 
            // icbtHoaDon
            // 
            this.icbtHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.icbtHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtHoaDon.FlatAppearance.BorderSize = 0;
            this.icbtHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtHoaDon.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtHoaDon.ForeColor = System.Drawing.Color.White;
            this.icbtHoaDon.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.icbtHoaDon.IconColor = System.Drawing.Color.Cornsilk;
            this.icbtHoaDon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icbtHoaDon.IconSize = 30;
            this.icbtHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtHoaDon.Location = new System.Drawing.Point(0, 169);
            this.icbtHoaDon.Name = "icbtHoaDon";
            this.icbtHoaDon.Size = new System.Drawing.Size(230, 55);
            this.icbtHoaDon.TabIndex = 3;
            this.icbtHoaDon.Tag = "Hoá đơn";
            this.icbtHoaDon.Text = "Hoá đơn";
            this.icbtHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtHoaDon.UseVisualStyleBackColor = false;
            this.icbtHoaDon.Click += new System.EventHandler(this.icbtHoaDon_Click);
            // 
            // icbtThongTin
            // 
            this.icbtThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.icbtThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtThongTin.FlatAppearance.BorderSize = 0;
            this.icbtThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtThongTin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtThongTin.ForeColor = System.Drawing.Color.White;
            this.icbtThongTin.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.icbtThongTin.IconColor = System.Drawing.Color.Cornsilk;
            this.icbtThongTin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icbtThongTin.IconSize = 30;
            this.icbtThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtThongTin.Location = new System.Drawing.Point(0, 114);
            this.icbtThongTin.Name = "icbtThongTin";
            this.icbtThongTin.Size = new System.Drawing.Size(230, 55);
            this.icbtThongTin.TabIndex = 2;
            this.icbtThongTin.Tag = "Thông tin cá nhân";
            this.icbtThongTin.Text = "Thông tin cá nhân";
            this.icbtThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtThongTin.UseVisualStyleBackColor = false;
            this.icbtThongTin.Click += new System.EventHandler(this.icbtThongTin_Click);
            // 
            // icbtMenu
            // 
            this.icbtMenu.AutoSize = true;
            this.icbtMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.icbtMenu.FlatAppearance.BorderSize = 0;
            this.icbtMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtMenu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtMenu.ForeColor = System.Drawing.Color.White;
            this.icbtMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.icbtMenu.IconColor = System.Drawing.Color.Cornsilk;
            this.icbtMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icbtMenu.IconSize = 30;
            this.icbtMenu.Location = new System.Drawing.Point(160, 0);
            this.icbtMenu.Name = "icbtMenu";
            this.icbtMenu.Size = new System.Drawing.Size(60, 60);
            this.icbtMenu.TabIndex = 2;
            this.icbtMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtMenu.UseVisualStyleBackColor = false;
            this.icbtMenu.Click += new System.EventHandler(this.icbtMenu_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Cornsilk;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 95;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(95, 95);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1301, 761);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1301, 761);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private FontAwesome.Sharp.IconButton icbtLogOut;
        private FontAwesome.Sharp.IconButton btnChangePass;
        private FontAwesome.Sharp.IconButton icbtTongQuan;
        private FontAwesome.Sharp.IconButton icbtHoaDon;
        private FontAwesome.Sharp.IconButton icbtThongTin;
        private FontAwesome.Sharp.IconButton icbtMin;
        private FontAwesome.Sharp.IconButton icbtClose;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTitleBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private FontAwesome.Sharp.IconButton icbtMax;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton icbtMenu;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panelMenu;
    }
}