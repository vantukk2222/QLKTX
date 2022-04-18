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
    public partial class UC_QLPhong : UserControl
    {
        public UC_QLPhong()
        {
            InitializeComponent();
            LoadData();
        }
        public void ShowDataGridView(List<Phong> list)
        {
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = list.Select(p => new
            {
                MaPhong = p.MaPhong,
                TenPhong = p.TenPhong,
                LoaiPhong=p.LoaiPhong,
                MaKhu=p.MaKhu,
                SoNguoiHienTai = p.SoNguoiHienTai,
                SoNguoiToiDa=p.SoNguoiToiDa

            }).ToList();
            guna2DataGridView1.Columns[0].HeaderText = "Mã Phòng";
            guna2DataGridView1.Columns[1].HeaderText = "Tên Phòng";
            guna2DataGridView1.Columns[2].HeaderText = "Loại Phòng";
            guna2DataGridView1.Columns[3].HeaderText = "Mã Khu";
            guna2DataGridView1.Columns[4].HeaderText = "Số Người Hiện Tại";
            guna2DataGridView1.Columns[5].HeaderText = "Số Người Tối Đa";

        }
        public void LoadData()
        {
            ShowDataGridView( BLL_QLPhong.Instance.GetAllPhong());
        }
    }
}
