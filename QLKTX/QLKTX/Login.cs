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

namespace QLKTX
{
	public partial class Login : Form
	{
		
		
		public Login()
		{
			InitializeComponent();
		}

		private void butlogin_Click(object sender, EventArgs e)
		{
			SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-IHJACRP;Initial Catalog=QLKyTucXa;Integrated Security=True");
			
			string query = "Select * from Account Where account = '" + txtUsername.Text.Trim() +"' and password = '" + txtPassword.Text.Trim() + "'";
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
			DataTable dtbl = new DataTable();
			sda.Fill(dtbl);
			if (dtbl.Rows.Count == 1)
			{
				MessageBox.Show("Login Success!!!");
			}
			else
				MessageBox.Show("Check your username and password");
		}

		private void butexit_Click(object sender, EventArgs e)
		{
			this.Close();
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
	}
}
