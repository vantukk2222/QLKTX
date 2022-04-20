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
        public AEFSVForm()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            if (MSSV != "")
            {
                txtmssv.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).MSSV;
                if (AddSV)
                {
                    txtmssv.Enabled = false;
                }
                txtHedaotao.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).HeDaoTao;
                txtKhoa.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).Khoa;
                txtKhoahoc.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).KhoaHoc;
                txtLop.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).LopHoc;
                txtname.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).HoTen;
                txtSDT.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).SDT;
                txtQue.Texts = BLL_QLSV.Instance.GetSVByMSSV(MSSV).QueQuan;
                rjDatePicker1.Value =  BLL_QLSV.Instance.GetSVByMSSV(MSSV).NgaySinh.Date;
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
            }
            else MessageBox.Show("Edit thanh cong");
        }
    }
}
