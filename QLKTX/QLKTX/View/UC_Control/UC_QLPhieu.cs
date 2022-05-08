using QLKTX.BLL;
using QLKTX.View.FormView;
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
            dgvBaoCao.DataSource = null;
            dgvDKOKTX.DataSource = null;
            dgvGiaHan.DataSource = null;
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
                p.SDT,
                p.Phieu.status
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
            dgvDKOKTX.Columns[11].HeaderText = "Trạng thái";
            dgvDKOKTX.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBaoCao.DataSource = list.Select(p => new
            {
                MaPhieu = p.MaPhieu,
                TenPhieu = p.TenPhieu,
                MSSV = p.MSSV,
                MaCB = p.MaCB,
                MaPhong = p.MaPhong,
                NgayLap = p.NgayLap,
                status = p.status

            }).ToList();
            dgvBaoCao.Columns[0].HeaderText = "Mã phiếu";
            dgvBaoCao.Columns[1].HeaderText = "Tên phiếu";
            dgvBaoCao.Columns[2].HeaderText = "MSSV";
            dgvBaoCao.Columns[3].HeaderText = "Mã cán bộ";
            dgvBaoCao.Columns[4].HeaderText = "Mã phòng";
            dgvBaoCao.Columns[5].HeaderText = "Ngày lập";
            dgvBaoCao.Columns[6].HeaderText = "Trạng thái";
            dgvBaoCao.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGiaHan.DataSource = BLL_PhieuGiaHanHD.Instance.getAllPhieu().Select(p => new
            {
                MaPhieu = p.MaPhieu,
                MaHD = p.MaHopDong,
                Hoten = p.HopDong.SVs.FirstOrDefault().HoTen,
                MSSV = p.HopDong.SVs.FirstOrDefault().MSSV,
                time=p.SoNamGiaHan,
                status = p.Phieu.status
            }).ToList();
            dgvGiaHan.Columns[0].HeaderText = "Mã phiếu";
            dgvGiaHan.Columns[1].HeaderText = "Mã hợp đồng";
            dgvGiaHan.Columns[2].HeaderText = "Họ tên";
            dgvGiaHan.Columns[3].HeaderText = "MSSV";
            dgvGiaHan.Columns[4].HeaderText = "Số năm gia hạn";
            dgvGiaHan.Columns[5].HeaderText = "Trạng thái";
            dgvGiaHan.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void LoadData()
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

        

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dgvBaoCao.Rows[e.RowIndex].Cells[6].Value))
                return;
            dgvBaoCao.Rows[e.RowIndex].Selected = true;
            string ma = dgvBaoCao.Rows[e.RowIndex].Cells[0].Value.ToString();
            BLL_PhieuDKOKTX.Instance.DuyetPhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
            ShowDataGridView(BLL_QLPhieu.Instance.GetAllPhieu());
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDKOKTX.SelectedRows)
            {
                if (Convert.ToBoolean(row.Cells["status"].Value) == true) MessageBox.Show("Đã duyệt");
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuDKOKTX.Instance.DuyetPhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
            }
            LoadData();
        }

        private void btnAcceptAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDKOKTX.Rows)
            {
                if (Convert.ToBoolean(row.Cells["status"].Value) == true) continue;
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuDKOKTX.Instance.DuyetPhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
            }
            LoadData();
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
                LoadData();
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
            LoadData();
        }

        private void btnViewDKO_Click(object sender, EventArgs e)
        {
            string ma = dgvDKOKTX.Rows[dgvBaoCao.CurrentRow.Index].Cells[0].Value.ToString();
            ApproveSVForm form = new ApproveSVForm(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
            form.d = new ApproveSVForm.mydel(LoadData);
            form.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.SelectedRows.Count == 1)
            {
                string ma = dgvBaoCao.SelectedRows[0].Cells[0].Value.ToString();
                string LoaiPhieu = ma.Substring(0, 2);
                switch (LoaiPhieu)
                {
                    case "DK":
                        {
                            ApproveSVForm form = new ApproveSVForm(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
                            form.d = new ApproveSVForm.mydel(LoadData);
                            form.ShowDialog();
                            break;
                        }
                    default:
                        break;
                }

            }
        }

        private void icbtDel_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.SelectedRows.Count >= 1)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvBaoCao.SelectedRows)
                    {
                        string ma = row.Cells[0].Value.ToString();
                        BLL_QLPhieu.Instance.DeletePhieu(ma);
                    }
                }
            }
            LoadData();
        }

        private void btnAcceptGH_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGiaHan.SelectedRows)
            {
                if (Convert.ToBoolean(row.Cells["status"].Value) == true) continue;
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuGiaHanHD.Instance.DuyetPhieuGiaHan(BLL_PhieuGiaHanHD.Instance.SearchPhieuGH(ma));
            }
            LoadData();
        }

        private void btnAcceptAllGH_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGiaHan.Rows)
            {
                if (Convert.ToBoolean(row.Cells["status"].Value) == true) continue;
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuGiaHanHD.Instance.DuyetPhieuGiaHan(BLL_PhieuGiaHanHD.Instance.SearchPhieuGH(ma));
            }
            LoadData();
        }

        private void btnDelGH_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGiaHan.SelectedRows)
            {
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuGiaHanHD.Instance.DeletePhieuGH(BLL_PhieuGiaHanHD.Instance.SearchPhieuGH(ma));
            }
            LoadData();
        }

        private void btnDelAllGH_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGiaHan.Rows)
            {
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuGiaHanHD.Instance.DeletePhieuGH(BLL_PhieuGiaHanHD.Instance.SearchPhieuGH(ma));
            }
            LoadData();
        }
    }
}
