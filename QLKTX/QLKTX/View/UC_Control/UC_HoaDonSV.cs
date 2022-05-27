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
    public partial class UC_HoaDonSV : UserControl
    {
        private SV temp;
        public UC_HoaDonSV(SV sv)
        {
            temp = sv;
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = BLL_HoaDon.Instance.GetHoaDons(temp.MSSV).Select(x => new
            {
                x.MaHoaDon,
                x.TenHoaDon,
                x.MSSV,
                x.SV.HoTen,
                x.NgayLap,
                x.NgayThu,
                x.DienNuoc.TìnhTrang,
                x.TienPhong,
                x.status
            }).ToList();
            dgvPhieuPhat.DataSource = null;
            dgvPhieuPhat.DataSource = BLL_PhieuKyLuat.Instance.GetPhieuKyLuats(temp.MSSV).Select(x => new
            {
                x.MaPhieu,
                x.Phieu.TenPhieu,
                x.Phieu.MSSV,
                x.Phieu.SV.HoTen,
                x.Phieu.NgayLap,
                x.HinhThucViPham,
                x.HinhThucKyLuat,
                x.Phieu.status
                
            }).ToList();
            SetColumnsName();
        }
        public void SetColumnsName()
        {
            dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = "Tên hóa đơn";
            dgvHoaDon.Columns[2].HeaderText = "MSSV";
            dgvHoaDon.Columns[3].HeaderText = "Họ tên";
            dgvHoaDon.Columns[4].HeaderText = "Ngày lập";
            dgvHoaDon.Columns[5].HeaderText = "Ngày thu";
            dgvHoaDon.Columns[6].HeaderText = "Điện nước";
            dgvHoaDon.Columns[7].HeaderText = "Tiền phòng";
            dgvHoaDon.Columns[8].HeaderText = "Đã thanh toán";
            //dgvHoaDon.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            /////////////////////////////////
            dgvPhieuPhat.Columns[0].HeaderText = "Mã phiếu";
            dgvPhieuPhat.Columns[1].HeaderText = "Tên phiếu";
            dgvPhieuPhat.Columns[2].HeaderText = "MSSV";
            dgvPhieuPhat.Columns[3].HeaderText = "Họ tên";
            dgvPhieuPhat.Columns[7].HeaderText = "Tình trạng";
            dgvPhieuPhat.Columns[5].HeaderText = "Hình thức vi phạm";
            dgvPhieuPhat.Columns[6].HeaderText = "Hình thức kỷ luật";
            dgvPhieuPhat.Columns[4].HeaderText = "Ngày lập";
            //dgvPhieuPhat.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void icbttienphong_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvHoaDon.SelectedRows)
                {
                    if (!Convert.ToBoolean(i.Cells["status"].Value.ToString()))
                    {
                        string msv = i.Cells["MSSV"].Value.ToString();
                        DateTime dt = Convert.ToDateTime(i.Cells["NgayLap"].Value);
                        BLL_HoaDon.Instance.ThanhToanPhong(msv,dt);
                    }
                }
                MessageBox.Show("Thanh toán thành công");
            }
            loadData();
        }

        private void icbttiendn_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvHoaDon.SelectedRows)
                {
                    if (!Convert.ToBoolean(i.Cells["TìnhTrang"].Value.ToString()))
                    {
                        string msv = i.Cells["MSSV"].Value.ToString();
                        DateTime dt = Convert.ToDateTime(i.Cells["NgayLap"].Value);
                        BLL_HoaDon.Instance.ThanhToanDN(msv, dt);
                    }
                }
                MessageBox.Show("Thanh toán thành công");
            }
            loadData();
        }

        private void icbtSearchHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnNopPhat_Click(object sender, EventArgs e)
        {
            if (dgvPhieuPhat.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvPhieuPhat.SelectedRows)
                {
                    if (!Convert.ToBoolean(i.Cells["status"].Value.ToString()))
                    {
                        string msv = i.Cells["MSSV"].Value.ToString();
                        DateTime dt = Convert.ToDateTime(i.Cells["NgayLap"].Value);
                        BLL_PhieuKyLuat.Instance.NopPhat(msv, dt);
                    }
                }
                MessageBox.Show("Thanh toán thành công");
            }
            loadData();
        }
    }
}
