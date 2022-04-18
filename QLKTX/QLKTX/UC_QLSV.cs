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
    public partial class UC_QLSV : UserControl
    {
        QLKTXEntities1 db = new QLKTXEntities1();
        public UC_QLSV()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource= BLL_QLSV.Instance.GetAllSV().Select(p => new {p.MSSV,p.MaHopDong,p.HoTen,
                                                                                    p.MaPhong,p.NgaySinh,p.QueQuan,
                                                                                    p.GioiTinh,p.KhoaHoc,p.Khoa,
                                                                                    p.HeDaoTao,p.SDT}).ToList();
        }
        private void UC_QLSV_Load(object sender, EventArgs e)
        {

        }

        
    }
}
