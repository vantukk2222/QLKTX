using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class AEFSVForm : Form
    {
        public delegate void mydel(List<SV> lst);
        public mydel d;
        public string MSSV { get; set; }
        public bool AddSV = true;
        public SV temp;
        public AEFSVForm(string mssv="")
        {
            if (mssv != "" )
            {
                AddSV = false;
                MSSV = mssv;
                temp = BLL_QLSV.Instance.GetSVByMSSV(MSSV);
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
                txtmssv.Texts = temp.MSSV;
                if (AddSV == false)
                {
                    txtmssv.Enabled = false;
                }
                txtHedaotao.Texts = String.Concat(temp.HeDaoTao.Where(c => !Char.IsWhiteSpace(c))); ;
                txtKhoa.Texts = String.Concat(temp.Khoa.Where(c => !Char.IsWhiteSpace(c))); ;
                txtKhoahoc.Texts = String.Concat(temp.KhoaHoc.Where(c => !Char.IsWhiteSpace(c))); ;
                txtLop.Texts = String.Concat(temp.LopHoc.Where(c => !Char.IsWhiteSpace(c))); ;
                txtname.Texts = temp.HoTen;
                txtSDT.Texts = String.Concat(temp.SDT.Where(c => !Char.IsWhiteSpace(c))); ;
                txtQue.Texts = temp.QueQuan;
                rjDatePicker1.Value = Convert.ToDateTime( temp.NgaySinh);
                if (temp.GioiTinh == true)
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
            bool flag=true;
            while (flag)
            {
                if (AddSV)
                {
                    try
                    {
                        temp = new SV
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
                            LopHoc = txtLop.Texts
                        };
                        BLL_QLSV.Instance.AddSV(temp);

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
                        temp.MSSV = txtmssv.Texts;
                        temp.HoTen = txtname.Texts;
                        temp.NgaySinh = rjDatePicker1.Value.Date;
                        temp.GioiTinh = checkSex.Checked;
                        temp.SDT = txtSDT.Texts;
                        temp.QueQuan = txtQue.Texts;
                        temp.HeDaoTao = txtHedaotao.Texts;
                        temp.Khoa = txtKhoa.Texts;
                        temp.KhoaHoc = txtKhoahoc.Texts;
                        temp.LopHoc = txtLop.Texts;
                        DataHelper.db.SaveChanges();

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
