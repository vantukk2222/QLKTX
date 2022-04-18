using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class UC_QLPhong : UserControl
    {
        public UC_QLPhong()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            guna2DataGridView1.DataSource = BLL_QLPhong.Instance.GetAllPhong().ToList();
        }
    }
}
