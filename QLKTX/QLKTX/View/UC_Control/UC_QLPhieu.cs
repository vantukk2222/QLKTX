using QLKTX.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.View.UC_Control
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
            dgvDKOKTX.DataSource = null;
            dgvDKOKTX.DataSource = BLL_PhieuDKOKTX.Instance.GetAllPhieuDKOKTX().Select(p => new {
                p.MaPhieu,
                p.MSSV,
                p.HoTen,
                p.NgaySinh,
                p.QueQuan,
                p.GioiTinh,
                p.LopHoc,
                p.KhoaHoc,
                p.Khoa,
                p.HeDaoTao,
                p.SDT
            }).ToList();
            dgvDKOKTX.Columns[0].HeaderText = "Mã phiếu";
            dgvDKOKTX.Columns[1].HeaderText = "MSSV";
            dgvDKOKTX.Columns[2].HeaderText = "Họ tên";
            dgvDKOKTX.Columns[3].HeaderText = "Ngày sinh";
            dgvDKOKTX.Columns[4].HeaderText = "Quê quán";
            dgvDKOKTX.Columns[5].HeaderText = "Giới tính";
            dgvDKOKTX.Columns[6].HeaderText = "Lớp học";
            dgvDKOKTX.Columns[7].HeaderText = "Khóa học";
            dgvDKOKTX.Columns[8].HeaderText = "Khoa";
            dgvDKOKTX.Columns[9].HeaderText = "Hệ đào tạo";
            dgvDKOKTX.Columns[10].HeaderText = "SĐT";
            dgvDKOKTX.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.DataSource = list.Select(p => new
            {
                MaPhieu = p.MaPhieu,
                TenPhieu = p.TenPhieu,
                MSSV = p.MSSV,
                MaCB = p.MaCB,
                MaPhong = p.MaPhong,
                NgayLap = p.NgayLap,
                status = p.status

            }).ToList();
            guna2DataGridView1.Columns[0].HeaderText = "Mã Phiếu";
            guna2DataGridView1.Columns[1].HeaderText = "Tên Phiếu";
            guna2DataGridView1.Columns[2].HeaderText = "MSSV";
            guna2DataGridView1.Columns[3].HeaderText = "Mã Cán Bộ";
            guna2DataGridView1.Columns[4].HeaderText = "Mã Phòng";
            guna2DataGridView1.Columns[5].HeaderText = "Ngày Lập";
            guna2DataGridView1.Columns[6].HeaderText = "Trạng Thái";
            guna2DataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value))
                return;
            guna2DataGridView1.Rows[e.RowIndex].Selected = true;
            string ma = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            BLL_PhieuDKOKTX.Instance.DuyetPhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
            ShowDataGridView(BLL_QLPhieu.Instance.GetAllPhieu());
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDKOKTX.SelectedRows)
            {
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuDKOKTX.Instance.DuyetPhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
            }
        }

        private void btnAcceptAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDKOKTX.Rows)
            {
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuDKOKTX.Instance.DuyetPhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
            }
        }

        private void btnDelDKO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvDKOKTX.SelectedRows)
                {
                    string ma = row.Cells[0].Value.ToString();
                    BLL_PhieuDKOKTX.Instance.DeletePhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvDKOKTX.Rows)
                {
                    string ma = row.Cells[0].Value.ToString();
                    BLL_PhieuDKOKTX.Instance.DeletePhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
                }
            }
        }
    }
}
