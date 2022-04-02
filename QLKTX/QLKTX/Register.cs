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

namespace QLKTX
{
	public partial class Register : Form
	{
		
		public Register()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void butback_Click(object sender, EventArgs e)
		{
			this.Close();
			Login log = new Login();
			log.Show();
		}

		private void butexit_Click(object sender, EventArgs e)
		{
			this.Close();
			Login log = new Login();
			log.Show();
		}

		private void cbShowpass_CheckedChanged(object sender, EventArgs e)
		{
			if (txtPassword.PasswordChar == '\0' && txtcompassword.PasswordChar == '\0')
			{
				txtPassword.PasswordChar = txtcompassword.PasswordChar ='*' ;
			}
			else txtPassword.PasswordChar = txtcompassword.PasswordChar = '\0' ;
		}

		private void butreg_Click(object sender, EventArgs e)
		{
			string ConnectionString = ConfigurationManager.ConnectionStrings["QLKTX.Properties.Settings.QLKTXConnectionString"].ConnectionString;
			SqlConnection sqlcon = new SqlConnection(ConnectionString);

			string query = "Select * from Account Where account = '" + txtUsername.Text.Trim() + "'";
			string queryfull = "Select * from Account Where account = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
			SqlDataAdapter xda = new SqlDataAdapter(queryfull, sqlcon);
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
			DataTable dtblfull = new DataTable();
			DataTable dtbl = new DataTable();
			sda.Fill(dtbl);
			if (txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Please fill form");
			}
			else if (txtcompassword.Text != txtPassword.Text)
			{
				MessageBox.Show("Password do not match");
			}
			else 
			{ 

			}
		}
	}
}
