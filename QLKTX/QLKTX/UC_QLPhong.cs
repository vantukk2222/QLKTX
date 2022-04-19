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
        public void ShowDataDetail(List<SV> list)
        {
            guna2DataGridView2.DataSource = null;
            guna2DataGridView2.DataSource = list.Select(p => new {
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
            guna2DataGridView2.Columns[0].HeaderText = "MSSV";
            guna2DataGridView2.Columns[1].HeaderText = "Mã Hợp Đồng";
            guna2DataGridView2.Columns[2].HeaderText = "Họ Tên";
            guna2DataGridView2.Columns[3].HeaderText = "Mã Phòng";
            guna2DataGridView2.Columns[4].HeaderText = "Ngày Sinh";
            guna2DataGridView2.Columns[5].HeaderText = "Quê Quán";
            guna2DataGridView2.Columns[6].HeaderText = "Giới Tính";
            guna2DataGridView2.Columns[7].HeaderText = "Khóa Học";
            guna2DataGridView2.Columns[8].HeaderText = "Khoa";
            guna2DataGridView2.Columns[9].HeaderText = "Hệ Đào Tạo";
            guna2DataGridView2.Columns[10].HeaderText = "SĐT";
        }
        public void LoadData()
        {
            ShowDataGridView( BLL_QLPhong.Instance.GetAllPhong());
        }

        private void icbtView_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                guna2DataGridView2.DataSource = null;
                MessageBox.Show(guna2DataGridView1.CurrentRow.Cells["MaPhong"].FormattedValue.ToString());
                string Maphong = String.Concat(guna2DataGridView1.CurrentRow.Cells[0].FormattedValue.ToString().Where(c => !Char.IsWhiteSpace(c)));
                ShowDataDetail(BLL_QLPhong.Instance.ShowSVPhong(Maphong));


            }
            
        }
    }
}
