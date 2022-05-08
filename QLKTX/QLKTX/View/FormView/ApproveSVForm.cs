using QLKTX.BLL;
using QLKTX.DTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.View.FormView
{
    public partial class ApproveSVForm : Form
    {
        public delegate void mydel();
        public mydel d;
        PhieuDangKyOKTX tempPhieu;        
        public ApproveSVForm(PhieuDangKyOKTX phieu)
        {
            tempPhieu = phieu;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {


            txtmssv.Texts = tempPhieu.MSSV;
            txtHedaotao.Texts = String.Concat(tempPhieu.HeDaoTao.Where(c => !Char.IsWhiteSpace(c)));
            txtKhoa.Texts = String.Concat(tempPhieu.Khoa.Where(c => !Char.IsWhiteSpace(c)));
            txtKhoahoc.Texts = String.Concat(tempPhieu.KhoaHoc.Where(c => !Char.IsWhiteSpace(c)));
            txtLop.Texts = String.Concat(tempPhieu.LopHoc.Where(c => !Char.IsWhiteSpace(c)));
            txtname.Texts = tempPhieu.HoTen;
            txtSDT.Texts = String.Concat(tempPhieu.SDT.Where(c => !Char.IsWhiteSpace(c)));
            txtQue.Texts = tempPhieu.QueQuan;
            rjDatePicker1.Value = Convert.ToDateTime(tempPhieu.NgaySinh);
            checkSex.Checked = tempPhieu.GioiTinh;

            rjToggleButton1.Checked = !tempPhieu.GioiTinh;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            BLL_PhieuDKOKTX.Instance.DuyetPhieuDKOKTX(tempPhieu);
            d();
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            BLL_PhieuDKOKTX.Instance.DeletePhieuDKOKTX(tempPhieu);
            d();
            this.Close();
        }
    }
}
