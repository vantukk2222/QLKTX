
namespace QLKTX
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
            this.butcreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.butlogin = new System.Windows.Forms.Button();
            this.cbShowpass = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butexit = new System.Windows.Forms.Button();
            this.cbbRole = new RJCodeAdvance.RJControls.RJComboBox();
            this.SuspendLayout();
            // 
            // butcreate
            // 
            this.butcreate.AutoSize = true;
            this.butcreate.BackColor = System.Drawing.Color.GhostWhite;
            this.butcreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butcreate.FlatAppearance.BorderSize = 0;
            this.butcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butcreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butcreate.Location = new System.Drawing.Point(79, 341);
            this.butcreate.Name = "butcreate";
            this.butcreate.Size = new System.Drawing.Size(168, 33);
            this.butcreate.TabIndex = 4;
            this.butcreate.Text = "CREATE ACCOUNT";
            this.butcreate.UseVisualStyleBackColor = false;
            this.butcreate.Click += new System.EventHandler(this.butcreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 99999999;
            this.label5.Text = "Don\'t have an account?";
            // 
            // butlogin
            // 
            this.butlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butlogin.FlatAppearance.BorderSize = 0;
            this.butlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butlogin.ForeColor = System.Drawing.Color.White;
            this.butlogin.Location = new System.Drawing.Point(36, 254);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(216, 35);
            this.butlogin.TabIndex = 3;
            this.butlogin.Text = "LOGIN";
            this.butlogin.UseVisualStyleBackColor = false;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // cbShowpass
            // 
            this.cbShowpass.AutoSize = true;
            this.cbShowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowpass.Location = new System.Drawing.Point(133, 227);
            this.cbShowpass.Name = "cbShowpass";
            this.cbShowpass.Size = new System.Drawing.Size(119, 21);
            this.cbShowpass.TabIndex = 3122121;
            this.cbShowpass.Text = "Show password";
            this.cbShowpass.UseVisualStyleBackColor = true;
            this.cbShowpass.CheckedChanged += new System.EventHandler(this.cbShowpass_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(36, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(36, 128);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(84)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quan Ly KTX";
            // 
            // butexit
            // 
            this.butexit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butexit.BackColor = System.Drawing.Color.GhostWhite;
            this.butexit.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.butexit.FlatAppearance.BorderSize = 0;
            this.butexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.butexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.butexit.ForeColor = System.Drawing.Color.Salmon;
            this.butexit.Location = new System.Drawing.Point(261, 0);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(24, 24);
            this.butexit.TabIndex = 24;
            this.butexit.Text = "X";
            this.butexit.UseVisualStyleBackColor = false;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // cbbRole
            // 
            this.cbbRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbRole.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbRole.BorderSize = 1;
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbRole.ForeColor = System.Drawing.Color.DimGray;
            this.cbbRole.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbRole.Items.AddRange(new object[] {
            "ADMIN",
            "SINH VIÊN"});
            this.cbbRole.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbRole.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbRole.Location = new System.Drawing.Point(36, 75);
            this.cbbRole.MinimumSize = new System.Drawing.Size(150, 30);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Padding = new System.Windows.Forms.Padding(1);
            this.cbbRole.Size = new System.Drawing.Size(200, 30);
            this.cbbRole.TabIndex = 100000001;
            this.cbbRole.Texts = "ROLE";
            // 
            // Login
            // 
            this.AcceptButton = this.butlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(285, 385);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butcreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butlogin);
            this.Controls.Add(this.cbShowpass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button butcreate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button butlogin;
		private System.Windows.Forms.CheckBox cbShowpass;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butexit;
        private RJCodeAdvance.RJControls.RJComboBox cbbRole;
    }
}