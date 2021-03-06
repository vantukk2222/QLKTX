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
//using QLKTX.DTA;
using QLKTX.BLL;

namespace QLKTX.View.FormView
{
	public partial class Login : Form
	{
		AccCB tempCB;
		AccSV tempSV;
		
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
                        tempCB = BLL_Acc.Instance.LoginCB(txtUsername.Text.Trim(), txtPassword.Text.Trim());
						if (tempCB!=null)
						{
							Main fmain = new Main();
							fmain.ShowDialog();
							this.Hide();
							MessageBox.Show("Welcome cán bộ " + tempCB.CanBoQuanLy.HoTen);
						}
						else
							MessageBox.Show("Check your username and password");
                        break;
                    //Login SV
                    case 1:
                        tempSV = BLL_Acc.Instance.LoginSV(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                        if (tempSV!=null)
						{
							if (!tempSV.status)
							{
								MessageBox.Show(" Tài khoản của bạn đã bị khóa\n Vui lòng liên hệ với cán bộ KTX để giải quyết");
								break;
							}
							else
							{
								User fuser = new User(tempSV.SV);
								fuser.Show();
								this.Hide();
								MessageBox.Show("Welcome sinh viên " + tempSV.SV.HoTen);
								int count = BLL_PhieuKyLuat.Instance.SoPhieuKyLuatChuaThanhToan(tempSV.SV);
								MessageBox.Show("Bạn có " + count.ToString() + " phiếu phạt chưa xử lý");

							}
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
