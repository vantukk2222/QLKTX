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
			string ConnectionStringCheck = ConfigurationManager.ConnectionStrings["QLKTX.Properties.Settings.QLKTXConnectionString"].ConnectionString;
			SqlConnection sqlconcheck = new SqlConnection(ConnectionStringCheck);

			string querycheck = "Select * from Account Where account = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
			SqlDataAdapter sda = new SqlDataAdapter(querycheck, sqlconcheck);
			DataTable dtblcheck = new DataTable();
			sda.Fill(dtblcheck);
			if (dtblcheck.Rows.Count == 1)
			{
				MessageBox.Show("Username already exists!");
			}
			else
			{
				if (txtUsername.Text == "" || txtPassword.Text == "")
				{
					MessageBox.Show("Please fill form!");
				}
				
				else if (txtcompassword.Text != txtPassword.Text)
				{
					MessageBox.Show("Password do not match!");
				}
				else if (txtPassword.Text == txtUsername.Text)
				{
					MessageBox.Show("Please choose a stronger password!");
				}
				else
				{
					string ConnectionStringCheckid = ConfigurationManager.ConnectionStrings["QLKTX.Properties.Settings.QLKTXConnectionString"].ConnectionString;
					SqlConnection sqlconcheckid = new SqlConnection(ConnectionStringCheckid);

					string queryid = "Select * from Account";
					SqlDataAdapter sdaid = new SqlDataAdapter(queryid, sqlconcheckid);
					DataTable dtblid = new DataTable();
					sdaid.Fill(dtblid);
					int x = int.Parse(dtblid.Rows.Count.ToString()) + 1;
					string ConnectionString = ConfigurationManager.ConnectionStrings["QLKTX.Properties.Settings.QLKTXConnectionString"].ConnectionString;
					SqlConnection sqlcon = new SqlConnection(ConnectionString);
					SqlCommand cmd = new SqlCommand(@"INSERT INTO ACCOUNT
					([loginid]
					,[account]
					,[password])
					VALUES
					('" + x + "','" + txtUsername.Text + "','" + txtPassword.Text + "')", sqlcon);
					sqlcon.Open();
					cmd.ExecuteNonQuery();
					sqlcon.Close();
					MessageBox.Show("Register Successfully!!!");
					txtcompassword.Text = txtPassword.Text = txtUsername.Text = "";

				}
			}
		}

        private void butclear_Click(object sender, EventArgs e)
        {
			txtcompassword.Text = txtPassword.Text = txtUsername.Text = "";
		}
    }
}
