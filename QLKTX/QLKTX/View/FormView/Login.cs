using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using QLKTX.DTA;

namespace QLKTX.View.FormView
{
	public partial class Login : Form
	{
		
		
		public Login()
		{
			InitializeComponent();
		}

		private void butlogin_Click(object sender, EventArgs e)
		{
			if (cbbRole.SelectedIndex >= 0)
			{
                switch (cbbRole.SelectedIndex)
                {
					case 0:
						if (DataHelper.db.AccCBs.Where(cb => cb.UserName == txtUsername.Text.Trim() & cb.PassWord == txtPassword.Text.Trim()).Count() == 1)
						{
							Main fmain = new Main();
							fmain.Show();
							this.Hide();
							MessageBox.Show("Welcome " + txtUsername.Text);
						}
						else
							MessageBox.Show("Check your username and password");
                        break;
                    //Login SV
                    case 1:
						if (DataHelper.db.AccSVs.Where(sv => sv.UserName == txtUsername.Text.Trim() & sv.PassWord == txtPassword.Text.Trim()).Count() == 1)
						{
							User fuser = new User();
							fuser.Show();
							this.Hide();



							MessageBox.Show("Welcome " + txtUsername.Text);
						}
						else
							MessageBox.Show("Check your username and password");
						break;
                    default:
                        break;
                }
                
			}
			else
			{
				MessageBox.Show("Lựa chọn quyền truy cập!!!");
			}
            
		}

		private void butexit_Click(object sender, EventArgs e)
		{
            Application.Exit();
        }

		private void cbShowpass_CheckedChanged(object sender, EventArgs e)
		{
			if (txtPassword.PasswordChar == '\0')
			{
				txtPassword.PasswordChar = '*';
			}
			else txtPassword.PasswordChar = '\0';
		}

		private void butcreate_Click(object sender, EventArgs e)
		{
			Register reg = new Register();
			reg.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
