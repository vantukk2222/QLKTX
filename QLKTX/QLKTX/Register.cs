using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLKTX
{
	public partial class Register : Form
	{
        PhieuDangKyOKTX pdk;
        public Register()
		{
			InitializeComponent();
		}

        private void butback_Click(object sender, EventArgs e)
        {
			this.Hide();
			Login flog = new Login();
			flog.Show();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(txtmssv.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSSV không hợp lệ mời nhập lại");
                return;
            }
            try
            {
                Int32.Parse(txtSDT.Texts);
                if (txtSDT.Texts.Length < 9 || txtSDT.Texts.Length > 11)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ mời nhập lại");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số điện thoại không hợp lệ mời nhập lại");
                return;
            }
            if (txtmssv.Texts == null || txtmssv.Texts == "")
            {
                MessageBox.Show("MSSV không hợp lệ mời nhập lại");
                return;
            }
            if (txtname.Texts == null || txtname.Texts == "")
            {
                MessageBox.Show("Họ tên không hợp lệ mời nhập lại");
                return;
            }
            if (txtQue.Texts == null || txtQue.Texts == "")
            {
                MessageBox.Show("Quê quán không hợp lệ mời nhập lại");
                return;
            }
            if (txtKhoa.Texts == null || txtKhoa.Texts == "")
            {
                MessageBox.Show("Khoa không hợp lệ mời nhập lại");
                return;
            }
            if (txtKhoahoc.Texts == null || txtKhoahoc.Texts == "")
            {
                MessageBox.Show("Khóa học không hợp lệ mời nhập lại");
                return;
            }
            if (txtLop.Texts == null || txtLop.Texts == "")
            {
                MessageBox.Show("Lớp không hợp lệ mời nhập lại");
                return;
            }
            if (txtHedaotao.Texts == null || txtHedaotao.Texts == "")
            {
                MessageBox.Show("Hệ đào tạo không hợp lệ mời nhập lại");
                return;
            }
            string _MaPhieu = "DK" + Convert.ToString(BLL_QLPhieu.Instance.GetLastMaPhieuDKOKTX()).PadLeft(5, '0');
            pdk = new PhieuDangKyOKTX
            {
                MaPhieu = _MaPhieu,
                MSSV = txtmssv.Texts,
                HoTen = txtname.Texts,
                NgaySinh = dateNgaySinh.Value.Date,
                GioiTinh = checkSex.Checked,
                QueQuan = txtQue.Texts,
                LopHoc = txtLop.Texts,
                Khoa = txtKhoa.Texts,
                KhoaHoc = txtKhoahoc.Texts,
                HeDaoTao = txtHedaotao.Texts,
                SDT = txtSDT.Texts,
            };
            BLL_QLPhieu.Instance.AddPhieuDKOKTX(pdk);

        }
    }
}
