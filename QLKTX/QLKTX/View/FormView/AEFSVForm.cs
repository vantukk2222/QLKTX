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
    public partial class AEFSVForm : Form
    {
        public delegate void mydel(List<SV> lst);
        public mydel d;
        public string MSSV { get; set; }
        public bool AddSV = true;
        public SV tempSV;
        
        public AEFSVForm(string mssv="")
        {
            if (mssv != "" )
            {
                AddSV = false;
                MSSV = mssv;
                tempSV = BLL_QLSV.Instance.GetSVByMSSV(MSSV);
            }
            
            MSSV = mssv;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            if (MSSV != "")
            {
                this.Text = "Chỉnh sửa sinh viên";
                txtmssv.Texts = tempSV.MSSV;
                if (AddSV == false)
                {
                    txtmssv.Enabled = false;
                }
                txtHedaotao.Texts = String.Concat(tempSV.HeDaoTao.Where(c => !Char.IsWhiteSpace(c))); ;
                txtKhoa.Texts = String.Concat(tempSV.Khoa.Where(c => !Char.IsWhiteSpace(c))); ;
                txtKhoahoc.Texts = String.Concat(tempSV.KhoaHoc.Where(c => !Char.IsWhiteSpace(c))); ;
                txtLop.Texts = String.Concat(tempSV.LopHoc.Where(c => !Char.IsWhiteSpace(c))); ;
                txtname.Texts = tempSV.HoTen;
                txtSDT.Texts = String.Concat(tempSV.SDT.Where(c => !Char.IsWhiteSpace(c))); ;
                txtQue.Texts = tempSV.QueQuan;
                rjDatePicker1.Value = Convert.ToDateTime( tempSV.NgaySinh);
                if (tempSV.GioiTinh == true)
                {
                    checkSex.Checked = true;
                }
                else checkSex.Checked = false;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            bool sex = checkSex.Checked;
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
            catch (Exception )
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
            
            bool flag=true;
            while (flag)
            {
                if (AddSV)
                {
                    try
                    {
                        if (BLL_QLSV.Instance.checkSV(txtmssv.Texts))
                        {
                            MessageBox.Show("MSSV đã tồn tại mời nhập lại");
                            return;
                        }
                        
                        BLL_HopDong.Instance.AddHopDong();
                        tempSV = new SV
                        {
                            MSSV = txtmssv.Texts,
                            HoTen = txtname.Texts,
                            NgaySinh = rjDatePicker1.Value.Date,
                            GioiTinh = checkSex.Checked,
                            SDT = txtSDT.Texts,
                            QueQuan = txtQue.Texts,
                            HeDaoTao = txtHedaotao.Texts,
                            Khoa = txtKhoa.Texts,
                            KhoaHoc = txtKhoahoc.Texts,
                            LopHoc = txtLop.Texts,
                            MaHopDong= "HD" + Convert.ToString(BLL_HopDong.Instance.GetLastMaHopDong()).PadLeft(4, '0'),
                        };
                        BLL_QLSV.Instance.AddSV(tempSV);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không thành công!!! kiểm tra lại thông tin");
                    }
                    MessageBox.Show("Add thanh cong");
                    flag = false;
                }
                else
                {
                    try
                    {
                        tempSV.MSSV = txtmssv.Texts;
                        tempSV.HoTen = txtname.Texts;
                        tempSV.NgaySinh = rjDatePicker1.Value.Date;
                        tempSV.GioiTinh = checkSex.Checked;
                        tempSV.SDT = txtSDT.Texts;
                        tempSV.QueQuan = txtQue.Texts;
                        tempSV.HeDaoTao = txtHedaotao.Texts;
                        tempSV.Khoa = txtKhoa.Texts;
                        tempSV.KhoaHoc = txtKhoahoc.Texts;
                        tempSV.LopHoc = txtLop.Texts;
                        BLL_QLSV.Instance.EditSV(tempSV);

                    }
                    catch
                    {
                        MessageBox.Show("Chỉnh sửa không thành công!!! kiểm tra lại thông tin");
                    }
                    MessageBox.Show("Edit thanh cong");
                    flag = false;
                }
            }
            d(BLL_QLSV.Instance.GetAllSV());
            this.Close();
        }
    }
}
