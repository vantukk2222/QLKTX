using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class UC_QLSV : UserControl
    {
       // QLKTXEntities1 db = new QLKTXEntities1();
        public UC_QLSV()
        {
            InitializeComponent();
            LoadData();
            cbbKhoa.Items.Add("All");
            foreach (string s in BLL_QLSV.Instance.GetAllKhoa().Distinct())
            {
                string khoa = String.Concat(s.Where(c => !Char.IsWhiteSpace(c)));
                cbbKhoa.Items.Add(khoa);
            }
        }
        public void ShowDataGridView(List<SV> list)
        {
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = list.Select(p => new {
                p.MSSV,
                p.MaHopDong,
                p.HoTen,
                p.MaPhong,
                p.NgaySinh,
                p.QueQuan,
                p.GioiTinh,
                p.KhoaHoc,
                p.Khoa,
                p.HeDaoTao,
                p.SDT
            }).ToList();
            guna2DataGridView1.Columns[0].HeaderText = "Mã Sinh Viên";
            guna2DataGridView1.Columns[1].HeaderText = "Mã Hợp Đồng";
            guna2DataGridView1.Columns[2].HeaderText = "Họ Tên";
            guna2DataGridView1.Columns[3].HeaderText = "Mã Phòng";
            guna2DataGridView1.Columns[4].HeaderText = "Ngày Sinh";
            guna2DataGridView1.Columns[5].HeaderText = "Quê Quán";
            guna2DataGridView1.Columns[6].HeaderText = "Giới Tính";
            guna2DataGridView1.Columns[7].HeaderText = "Khóa Học";
            guna2DataGridView1.Columns[8].HeaderText = "Khoa";
            guna2DataGridView1.Columns[9].HeaderText = "Hệ Đào Tạo";
            guna2DataGridView1.Columns[10].HeaderText = "SĐT";
            
        }
        public void LoadData()
        {
            ShowDataGridView(BLL_QLSV.Instance.GetAllSV());
        }
        private void UC_QLSV_Load(object sender, EventArgs e)
        {

        }

        private void iconTimKiem_Click(object sender, EventArgs e)
        {
            string s;
            if (cbbKhoa.SelectedText != null)
            {
                s = cbbKhoa.SelectedText.Trim();
            }
            else s = "";
            ShowDataGridView(BLL_QLSV.Instance.GetAllSVKhoaTen(s,txtName.Texts.Trim()));
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Texts = string.Empty;
        }

        private void icbtDel_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chưa?", "Delete Students", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow i in guna2DataGridView1.SelectedRows)
                    {
                        BLL_QLSV.Instance.DeleteSV(i.Cells[0].FormattedValue.ToString());
                        MessageBox.Show(i.Cells[0].FormattedValue.ToString());

                    }

                    LoadData();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }


            }
        }

        private void icbtAdd_Click(object sender, EventArgs e)
        {
            AEFSVForm add = new AEFSVForm();
            add.d = new AEFSVForm.mydel(ShowDataGridView);
            add.ShowDialog();
        }

        private void icbtEdit_Click(object sender, EventArgs e)
        {
            AEFSVForm edit = new AEFSVForm(guna2DataGridView1.SelectedRows[0].Cells[0].FormattedValue.ToString());
            edit.d = new AEFSVForm.mydel(ShowDataGridView);
            edit.ShowDialog();
            
        }

        private void guna2DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                icbtDel_Click(sender, new EventArgs());
            }
        }
    }
}
