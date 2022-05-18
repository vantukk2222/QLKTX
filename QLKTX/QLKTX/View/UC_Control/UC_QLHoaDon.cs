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
    public partial class UC_QLHoaDon : UserControl
    {
        public UC_QLHoaDon()
        {
            InitializeComponent();
            BLL_HoaDon.Instance.CreateHoaDonMonthly();
            loadData();
        }

        public void loadData()
        {
            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = BLL_HoaDon.Instance.getAllHoaDon().Select(x => new
            {
                x.MaHoaDon,
                x.TenHoaDon,
                x.MSSV,
                //x.SV.HoTen,
                x.NgayLap,
                x.NgayThu,
                x.DienNuoc.TìnhTrang,
                x.TienPhong,
                x.status
            }).ToList();
            SetColumnsName();
        }
        public void SetColumnsName()
        {
            dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = "Tên hóa đơn";
            dgvHoaDon.Columns[2].HeaderText = "MSSV";
            //dgvHoaDon.Columns[3].HeaderText = "Họ tên";
            dgvHoaDon.Columns[3].HeaderText = "Ngày lập";
            dgvHoaDon.Columns[4].HeaderText = "Ngày thu";
            dgvHoaDon.Columns[5].HeaderText = "Điện nước";
            dgvHoaDon.Columns[6].HeaderText = "Tiền phòng";
            dgvHoaDon.Columns[7].HeaderText = "Đã thanh toán";
            dgvHoaDon.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void icbtSearch_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = BLL_HoaDon.Instance.getHoaDonByDate(dtpNgayDau.Value, dtpNgayCuoi.Value).Select(x => new
            {
                x.MaHoaDon,
                x.TenHoaDon,
                x.MSSV,
                x.SV.HoTen,
                x.NgayLap,
                x.NgayThu,
                x.DienNuoc,
                x.TienPhong,
                x.status
            }).ToList();
            SetColumnsName();
        }
    }
}
