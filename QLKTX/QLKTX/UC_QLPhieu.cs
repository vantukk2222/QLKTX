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
    public partial class UC_QLPhieu : UserControl
    {
        public UC_QLPhieu()
        {
            InitializeComponent();
            LoadData();
            cbbLoai.Items.Add("All");
            foreach (string tenphieu in BLL_QLPhieu.Instance.GetAllTenPhieu().Distinct())
            {
                cbbLoai.Items.Add(String.Concat(tenphieu.Where(c => !Char.IsWhiteSpace(c))));
            }
        }
        public void ShowDataGridView(List<Phieu> list)
        {
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = list.Select(p => new
            {
                MaPhieu = p.MaPhieu,
                TenPhieu = p.TenPhieu,
                MSSV = p.MSSV,
                MaCB = p.MaCB,
                MaPhong = p.MaPhong,
                NgayLap = p.NgayLap

            }).ToList();
            guna2DataGridView1.Columns[0].HeaderText = "Mã Phiếu";
            guna2DataGridView1.Columns[1].HeaderText = "Tên Phiếu";
            guna2DataGridView1.Columns[2].HeaderText = "MSSV";
            guna2DataGridView1.Columns[3].HeaderText = "Mã Cán Bộ";
            guna2DataGridView1.Columns[4].HeaderText = "Mã Phòng";
            guna2DataGridView1.Columns[5].HeaderText = "Ngày Lập";

        }
        private void LoadData()
        {
            ShowDataGridView(BLL_QLPhieu.Instance.GetAllPhieu());
        }

        private void icbtSearch_Click(object sender, EventArgs e)
        {
            
                string s;
            if (cbbLoai.SelectedText == null)
            {
                s = "";
            }
            else s = cbbLoai.SelectedText;
            ShowDataGridView(BLL_QLPhieu.Instance.GetAllLoaiTen(s, txtName.Texts.Trim()));
        }

        private void icbtEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
