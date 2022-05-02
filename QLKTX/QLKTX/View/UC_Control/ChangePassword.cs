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
    public partial class ChangePassword : UserControl
    {
        private SV temp;
        public ChangePassword(SV sv)
        {
            InitializeComponent();
            temp = sv;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (BLL_AccSV.Instance.CheckPassword(temp, txtPass.Text))
            {
                if (txtNewPass.Text == txtComfirmNewPass.Text)
                {
                    BLL_AccSV.Instance.ChangePassword(temp, txtNewPass.Text);
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác!!!");
            }
        }
    }
}
