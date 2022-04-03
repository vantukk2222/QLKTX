
namespace QLKTX
{
	partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcompassword = new System.Windows.Forms.TextBox();
            this.cbShowpass = new System.Windows.Forms.CheckBox();
            this.butreg = new System.Windows.Forms.Button();
            this.butclear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.butback = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(84)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtUsername.Location = new System.Drawing.Point(35, 140);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtPassword.Location = new System.Drawing.Point(35, 205);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comfirm password";
            // 
            // txtcompassword
            // 
            this.txtcompassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtcompassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcompassword.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtcompassword.Location = new System.Drawing.Point(35, 270);
            this.txtcompassword.Multiline = true;
            this.txtcompassword.Name = "txtcompassword";
            this.txtcompassword.PasswordChar = '*';
            this.txtcompassword.Size = new System.Drawing.Size(216, 28);
            this.txtcompassword.TabIndex = 6;
            // 
            // cbShowpass
            // 
            this.cbShowpass.AutoSize = true;
            this.cbShowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowpass.Location = new System.Drawing.Point(132, 304);
            this.cbShowpass.Name = "cbShowpass";
            this.cbShowpass.Size = new System.Drawing.Size(119, 21);
            this.cbShowpass.TabIndex = 7;
            this.cbShowpass.Text = "Show password";
            this.cbShowpass.UseVisualStyleBackColor = true;
            this.cbShowpass.CheckedChanged += new System.EventHandler(this.cbShowpass_CheckedChanged);
            // 
            // butreg
            // 
            this.butreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butreg.FlatAppearance.BorderSize = 0;
            this.butreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butreg.ForeColor = System.Drawing.Color.White;
            this.butreg.Location = new System.Drawing.Point(35, 346);
            this.butreg.Name = "butreg";
            this.butreg.Size = new System.Drawing.Size(216, 35);
            this.butreg.TabIndex = 8;
            this.butreg.Text = "REGISTER";
            this.butreg.UseVisualStyleBackColor = false;
            this.butreg.Click += new System.EventHandler(this.butreg_Click);
            // 
            // butclear
            // 
            this.butclear.BackColor = System.Drawing.Color.GhostWhite;
            this.butclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butclear.FlatAppearance.BorderSize = 0;
            this.butclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butclear.Location = new System.Drawing.Point(35, 399);
            this.butclear.Name = "butclear";
            this.butclear.Size = new System.Drawing.Size(216, 35);
            this.butclear.TabIndex = 9;
            this.butclear.Text = "CLEAR";
            this.butclear.UseVisualStyleBackColor = false;
            this.butclear.Click += new System.EventHandler(this.butclear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already have an account?";
            // 
            // butback
            // 
            this.butback.BackColor = System.Drawing.Color.White;
            this.butback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butback.FlatAppearance.BorderSize = 0;
            this.butback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butback.Location = new System.Drawing.Point(83, 461);
            this.butback.Name = "butback";
            this.butback.Size = new System.Drawing.Size(120, 24);
            this.butback.TabIndex = 11;
            this.butback.Text = "BACK TO LOGIN";
            this.butback.UseVisualStyleBackColor = false;
            this.butback.Click += new System.EventHandler(this.butback_Click);
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
            this.butexit.TabIndex = 25;
            this.butexit.Text = "X";
            this.butexit.UseVisualStyleBackColor = false;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butback);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butclear);
            this.Controls.Add(this.butreg);
            this.Controls.Add(this.cbShowpass);
            this.Controls.Add(this.txtcompassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtcompassword;
		private System.Windows.Forms.CheckBox cbShowpass;
		private System.Windows.Forms.Button butreg;
		private System.Windows.Forms.Button butclear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button butback;
		private System.Windows.Forms.Button butexit;
	}
}

