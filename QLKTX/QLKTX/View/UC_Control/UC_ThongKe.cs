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
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
        public void LoadInfo()
        {
            lbSoPhongSuDung.Text = BLL_QLPhong.Instance.GetSoPhongDangSuDung().ToString();
            lbSoPhongTrong.Text = BLL_QLPhong.Instance.GetSoPhongTrong().ToString();
            lbTongSoPhong.Text = BLL_QLPhong.Instance.GetSoPhongToiDa().ToString();
            lbSoSV.Text = BLL_QLSV.Instance.GetSoLuongSV().ToString();
            lbDoanhThu.Text = BLL_HoaDon.Instance.GetDoanhThu(dtpNgayDau.Value.Date, dtpNgayCuoi.Value.Date).ToString();
            lbSoSVBiKhoaTaiKhoan.Text = BLL_QLSV.Instance.GetSoSVBiKhoaTaiKhoan().ToString();
            dgvSVNoTienPhong.DataSource = BLL_HoaDon.Instance.GetSVNoTienPhong(dtpNgayDau.Value, dtpNgayCuoi.Value).Select(x => new { x.MSSV, x.HoTen, x.Phong.TenPhong, SoThangNo = x.HoaDons.Where(p => p.status == false).Count(),status=x.AccSV.status }).ToList();
            dgvSVNoTienPhong.Columns[0].HeaderText = "MSSV";
            dgvSVNoTienPhong.Columns[1].HeaderText = "Họ Tên";
            dgvSVNoTienPhong.Columns[2].HeaderText = "Phòng";
            dgvSVNoTienPhong.Columns[3].HeaderText = "Số Tháng Nợ";
            dgvSVNoTienPhong.Columns[4].HeaderText = "Trạng Thái tài khoản";
            dgvSVNoTienPhong.Columns[4].ValueType = typeof(bool);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpNgayCuoi.Value < dtpNgayDau.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }
            else
            {
                LoadInfo();
            }
        }

        private void icbtDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dgvSVNoTienPhong.Rows)
            {
                if (Int32.Parse(i.Cells[3].Value.ToString()) > 3)
                {
                    BLL_QLSV.Instance.khoaAccSV(BLL_QLSV.Instance.GetSVByMSSV(i.Cells[0].Value.ToString()));
                }
                
            }
            LoadInfo();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string Maphieu;
            foreach (DataGridViewRow i in dgvSVNoTienPhong.Rows)
            {
                Maphieu = "KL" + Convert.ToString(BLL_PhieuKyLuat.Instance.GetLastMaPhieuKyLuat()).PadLeft(5, '0');
                PhieuKyLuat temp = new PhieuKyLuat
                {
                    MaPhieu = Maphieu,
                    HinhThucKyLuat = "nộp phạt",
                    HinhThucViPham = "trễ tiền phòng",
                    Phieu = new Phieu { MaPhieu = Maphieu,TenPhieu="Phiếu Kỷ luật", MSSV = i.Cells[0].FormattedValue.ToString(), NgayLap = DateTime.Now, status = false },
                };
                BLL_PhieuKyLuat.Instance.AddPhieuKyLuat(temp);
            }
            MessageBox.Show("đã tạo phiếu kỷ luật");
        }

        private void icbUnlock_Click(object sender, EventArgs e)
        {
            if (dgvSVNoTienPhong.SelectedRows.Count > 0)
            {
                BLL_QLSV.Instance.MokhoaAccSV(BLL_QLSV.Instance.GetSVByMSSV(dgvSVNoTienPhong.SelectedRows[0].Cells[0].FormattedValue.ToString()));
                LoadInfo();
            }
            foreach (DataGridViewRow i in dgvSVNoTienPhong.Rows)
            {
                if (Int32.Parse(i.Cells[3].Value.ToString()) <= 3)
                {
                    BLL_QLSV.Instance.MokhoaAccSV(BLL_QLSV.Instance.GetSVByMSSV(i.Cells[0].Value.ToString()));
                }

            }
            LoadInfo();

        }
    }
}
