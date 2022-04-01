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
	public partial class Register : Form
	{
		SqlConnection connectAcc;
		SqlCommand cmdAcc;
		string str = "@Data Source=DESKTOP-IHJACRP;Initial Catalog=QLKyTucXa;Integrated Security=True";
		SqlDataAdapter adapter = new SqlDataAdapter();
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
	}
}
