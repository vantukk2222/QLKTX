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
            dgvBaoCao.Columns[0].HeaderText = "Mã Phiếu";
            dgvBaoCao.Columns[1].HeaderText = "Tên Phiếu";
            dgvBaoCao.Columns[2].HeaderText = "MSSV";
            dgvBaoCao.Columns[3].HeaderText = "Mã Cán Bộ";
            dgvBaoCao.Columns[4].HeaderText = "Mã Phòng";
            dgvBaoCao.Columns[5].HeaderText = "Ngày Lập";
            dgvBaoCao.Columns[6].HeaderText = "Trạng Thái";
            dgvBaoCao.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                string ma = row.Cells[0].Value.ToString();
                BLL_PhieuDKOKTX.Instance.DuyetPhieuDKOKTX(BLL_PhieuDKOKTX.Instance.SearchPhieuDK(ma));
            }
            LoadData();
        }

        private void btnAcceptAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDKOKTX.Rows)
            {
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
                string ma = dgvBaoCao.Rows[dgvBaoCao.CurrentRow.Index].Cells[0].Value.ToString();
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
    }
}
