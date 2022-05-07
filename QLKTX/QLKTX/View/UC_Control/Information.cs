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
    public partial class Information : UserControl
    {
        private SV temp;
        public Information(SV sv)
        {
            temp = sv;
            InitializeComponent();
            Information_Load();
        }

        private void Information_Load()
        {
            txtmssv.Texts = temp.MSSV;
            txtname.Texts = temp.HoTen;
            txtLop.Texts = temp.LopHoc;
            checkSex.Checked = temp.GioiTinh;
            txtKhoa.Texts = temp.Khoa;
            txtKhoahoc.Texts = temp.KhoaHoc;
            dtNgaySinh.Value = temp.NgaySinh;
            txtQue.Texts = temp.QueQuan;
            txtSDT.Texts = temp.SDT;
            txtHedaotao.Texts = temp.HeDaoTao;
            cbbKhu.Texts = temp.Phong.Khu.MaKhu;
            cbbPhong.Texts = temp.Phong.MaPhong;
            txtNgayHetHan.Texts = temp.HopDong.NgayHetHan.Value.Date.ToString("dd/MM/yyyy");

        }
        private void btSave_Click(object sender, EventArgs e)
        {
            temp.SDT = txtSDT.Texts;
            BLL_QLSV.Instance.EditSV(temp);
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            string _MaPhieu = "GH" + Convert.ToString(BLL_PhieuGiaHanHD.Instance.GetLastMaPhieuGiaHan()).PadLeft(5, '0');
            PhieuGiaHanHD HD = new PhieuGiaHanHD
            {
                MaPhieu = _MaPhieu,
                MaHopDong = temp.HopDong.MaHopDong,
                SoNamGiaHan =1
                
            };
            BLL_PhieuGiaHanHD.Instance.AddPhieuGiaHan(HD);
            MessageBox.Show("Đăng ký gia hạn thành công");
        }
    }
}
