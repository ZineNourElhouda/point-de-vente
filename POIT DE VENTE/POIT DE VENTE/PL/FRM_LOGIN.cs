using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POIT_DE_VENTE.PL
{
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txtUser.Text,txtPWD.Text);
            if(Dt.Rows.Count>0)
            {
                FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                Program.SalesMan = Dt.Rows[0]["FullName"].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("!عملية تسجيل الدخول فاشلة");
            }
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
