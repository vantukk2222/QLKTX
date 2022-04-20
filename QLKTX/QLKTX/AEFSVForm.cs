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
        public string MSSV { get; set; }
        public bool AddSV = true;
        public AEFSVForm(string mssv="")
        {
            if (mssv != "" )
            {
                AddSV = false;
                MSSV = mssv;
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

                txtmssv.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).MSSV;
                if (AddSV == false)
                {
                    txtmssv.Enabled = false;
                }
                
                txtHedaotao.Texts = String.Concat(BLL_QLSV.Instance.GetSVByMSSV(MSSV).HeDaoTao.Where(c => !Char.IsWhiteSpace(c))); ;
                txtKhoa.Texts = String.Concat(BLL_QLSV.Instance.GetSVByMSSV(MSSV).Khoa.Where(c => !Char.IsWhiteSpace(c))); ;
                txtKhoahoc.Texts = String.Concat(BLL_QLSV.Instance.GetSVByMSSV(MSSV).KhoaHoc.Where(c => !Char.IsWhiteSpace(c))); ;
                txtLop.Texts = String.Concat(BLL_QLSV.Instance.GetSVByMSSV(MSSV).LopHoc.Where(c => !Char.IsWhiteSpace(c))); ;
                txtname.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).HoTen;
                txtSDT.Texts = String.Concat(BLL_QLSV.Instance.GetSVByMSSV(MSSV).SDT.Where(c => !Char.IsWhiteSpace(c))); ;
                txtQue.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).QueQuan;
                rjDatePicker1.Value = Convert.ToDateTime( BLL_QLSV.Instance.GetSVByMSSV(MSSV).NgaySinh);
                if (BLL_QLSV.Instance.GetSVByMSSV(MSSV).GioiTinh == true)
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
            if (AddSV)
            {
                MessageBox.Show("Add thanh cong");
                this.Close();
            }
            else
            {
                

                MessageBox.Show("Edit thanh cong");
                this.Close();
            }
        }
    }
}
