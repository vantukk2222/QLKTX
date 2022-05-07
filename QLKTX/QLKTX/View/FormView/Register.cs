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
using QLKTX.BLL;

namespace QLKTX.View.FormView
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
            if (txtmssv.Texts == null || txtmssv.Texts == ""|| txtmssv.Texts.Length>10)
            {
                MessageBox.Show("MSSV không hợp lệ mời nhập lại");
                return;
            }
            if (txtname.Texts == null || txtname.Texts == ""||Int32.TryParse(txtname.Texts,out int k)||txtname.Texts.Length>50)
            {
                MessageBox.Show("Họ tên không hợp lệ mời nhập lại");
                return;
            }
            if (txtQue.Texts == null || txtQue.Texts == "" || Int32.TryParse(txtQue.Texts, out k) || txtQue.Texts.Length>10)
            {
                MessageBox.Show("Quê quán không hợp lệ mời nhập lại");
                return;
            }
            if (txtKhoa.Texts == null || txtKhoa.Texts == "" || Int32.TryParse(txtKhoa.Texts, out k) || txtKhoa.Texts.Length > 10)
            {
                MessageBox.Show("Khoa không hợp lệ mời nhập lại");
                return;
            }
            if (txtKhoahoc.Texts == null || txtKhoahoc.Texts == "" || Int32.TryParse(txtKhoahoc.Texts, out k)==false || txtKhoahoc.Texts.Length > 10)
            {
                MessageBox.Show("Khóa học không hợp lệ mời nhập lại");
                return;
            }
            if (txtLop.Texts == null || txtLop.Texts == "" || Int32.TryParse(txtLop.Texts, out k) || txtLop.Texts.Length > 10)
            {
                MessageBox.Show("Lớp không hợp lệ mời nhập lại");
                return;
            }
            if (txtHedaotao.Texts == null || txtHedaotao.Texts == "" || Int32.TryParse(txtHedaotao.Texts, out k) || txtHedaotao.Texts.Length > 10)
            {
                MessageBox.Show("Hệ đào tạo không hợp lệ mời nhập lại");
                return;
            }
            string _MaPhieu = "DK" + Convert.ToString(BLL_PhieuDKOKTX.Instance.GetLastMaPhieuDKOKTX()).PadLeft(5, '0');
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
            BLL_PhieuDKOKTX.Instance.AddPhieuDKOKTX(pdk);
            MessageBox.Show("đăng ký thành công");
            this.Hide();
            Login flog = new Login();
            flog.Show();
        }
    }
}
