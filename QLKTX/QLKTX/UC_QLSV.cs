using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        public void ShowDataGridView(List<SV> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list.Select(p => new {
                p.MSSV,
                p.MaHopDong,
                p.HoTen,
                p.MaPhong,
                p.NgaySinh,
                p.QueQuan,
                p.GioiTinh,
                p.KhoaHoc,
                p.Khoa,
                p.HeDaoTao,
                p.SDT
            }).ToList();
            dataGridView1.Columns[0].HeaderText = "MSSV";
            dataGridView1.Columns[1].HeaderText = "Mã Hợp Đồng";
            dataGridView1.Columns[2].HeaderText = "Họ Tên";
            dataGridView1.Columns[3].HeaderText = "Mã Phòng";
            dataGridView1.Columns[4].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[5].HeaderText = "Quê Quán";
            dataGridView1.Columns[6].HeaderText = "Giới Tính";
            dataGridView1.Columns[7].HeaderText = "Khóa Học";
            dataGridView1.Columns[8].HeaderText = "Khoa";
            dataGridView1.Columns[9].HeaderText = "Hệ Đào Tạo";
            dataGridView1.Columns[10].HeaderText = "SĐT";
        }
        public void LoadData()
        {
            ShowDataGridView(BLL_QLSV.Instance.GetAllSV());
        }
        private void UC_QLSV_Load(object sender, EventArgs e)
        {

        }

        private void iconTimKiem_Click(object sender, EventArgs e)
        {
            ShowDataGridView(BLL_QLSV.Instance.GetAllSVContainName(txtName.Text.Trim()));
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Clear();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string mssv = dataGridView1.Rows[index].Cells[0].Value.ToString();
                
                BLL_QLSV.Instance.DeleteSV(mssv);
                ShowDataGridView(BLL_QLSV.Instance.GetAllSV());
            }
        }
    }
}
