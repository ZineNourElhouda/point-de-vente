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
            if (Dt.Rows.Count > 0)
            {
                if (Dt.Rows[0][2].ToString() == "مسؤول")
                {
                    FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.العملياتToolStripMenuItem.Enabled = true;
                    Program.SalesMan = Dt.Rows[0]["FullName"].ToString();
                    FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Visible = true;

                    this.Close();
                } 
                else if (Dt.Rows[0][2].ToString() == "بائع")
                {
                    FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Visible = false;
                    FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Visible = false;
                    FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Visible = false;
                    FRM_MAIN.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.العملياتToolStripMenuItem.Enabled = true;

                    Program.SalesMan = Dt.Rows[0]["FullName"].ToString();
                    this.Close();
                } 
               
            }
            else
            {
                MessageBox.Show("!عملية تسجيل الدخول فاشلة");
                txtPWD.Clear();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUser.Text != string.Empty)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPWD.Text != string.Empty)
            {
                btnLogin.Focus();
            }
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
    
}
