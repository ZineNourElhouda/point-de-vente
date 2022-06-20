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
    public partial class FRM_ADD_USER : Form
    {

        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty || txtPWD.Text == string.Empty || txtFullName.Text == string.Empty
                || txtPWDConfirm.Text == string.Empty)
            {
                MessageBox.Show("الرجاء إدخال جميع المعلومات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("كلمة السر غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if  (btnSave.Text == "موافق")
            {

                  BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                     user.ADD_USER(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
                      MessageBox.Show("تم إضافة المستخدم بنجاح", "إضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);                         
            }
            else if (btnSave.Text == "تعديل")
            {

                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.EDIT_USER(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
                MessageBox.Show("تم تعديل المستخدم بنجاح", "تعديل مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtID.Clear();
            txtFullName.Clear();
            txtPWD.Clear();
            txtPWDConfirm.Clear();
            txtID.Focus();
            }

        private void txtPWDConfirm_Validated(object sender, EventArgs e)
        {
            if(txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("كلمة السر غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPWDConfirm.Clear();
                return;
            }

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtID.Text != string.Empty)
            {
                txtFullName.Focus();
            }
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtFullName.Text != string.Empty)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPWD.Text != string.Empty)
            {
                txtPWDConfirm.Focus();
            }
        }

        private void txtPWDConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPWDConfirm.Text != string.Empty)
            {
                cmbType.Focus();
            }
        }

        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbType.Text != string.Empty)
            {
                btnSave.Focus();
            }
        }

        private void FRM_ADD_USER_Load(object sender, EventArgs e)
        {

        }
    }
}
