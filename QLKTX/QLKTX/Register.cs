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

        private void butback_Click(object sender, EventArgs e)
        {
			this.Hide();
			Login flog = new Login();
			flog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
