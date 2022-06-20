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
    public partial class FRM_USERS_LIST : Form
    {
        BL.CLS_LOGIN login = new BL.CLS_LOGIN();
        public FRM_USERS_LIST()
        {
            InitializeComponent();
            this.dgvUsers.DataSource = login.SearchUsers("");//تعبئة dgvUsers
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();  
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.txtID.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            frm.txtFullName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            frm.txtPWD.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            frm.txtPWDConfirm.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            frm.cmbType.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            frm.btnSave.Text = "تعديل";
            frm.ShowDialog();
            this.dgvUsers.DataSource = login.SearchUsers("");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا المستخدم","حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) ==DialogResult.Yes) 
            {
                login.DELETE_USER(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvUsers.DataSource = login.SearchUsers("");

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvUsers.DataSource = login.SearchUsers(txtSearch.Text);

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();

            frm.btnSave.Text = "موافق";
            frm.ShowDialog();
            this.dgvUsers.DataSource = login.SearchUsers("");

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();

        }
    }
}
