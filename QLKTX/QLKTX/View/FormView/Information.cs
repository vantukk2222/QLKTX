using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.View.FormView
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }
    }
}
