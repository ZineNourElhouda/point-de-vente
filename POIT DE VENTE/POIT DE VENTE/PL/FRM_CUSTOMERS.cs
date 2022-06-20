using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POIT_DE_VENTE.PL
{
    public partial class FRM_CUSTOMERS : Form
        
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        int ID;
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();
            dgList.Columns[0].Visible = false;
            dgList.Columns[5].Visible = false;
        }

        private void FRM_CUSTOMERS_Load(object sender, EventArgs e)
        {

        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            try
            {
                byte[] Picture;

                if (pbox.Image == null)
                {
                    Picture = new byte[0];
                    cust.ADD_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, Picture, "without_image");
                    MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    Picture = ms.ToArray();
                    cust.ADD_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, Picture, "with_image");
                    MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();

                }
            }
            catch
            {
                return;
            }
            finally
            {
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
            }
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور|*.JPG;*.PNG; .*GIF;.*BMP ";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            pbox.Image = null;
            txtFirstName.Focus();
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLastName.Focus();
            }
           
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTel.Focus();
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }



        private void dgList_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                pbox.Image = null;
                ID = Convert.ToInt32(dgList.CurrentRow.Cells[0].Value);
                this.txtLastName.Text = dgList.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = dgList.CurrentRow.Cells[2].Value.ToString();
                this.txtTel.Text = dgList.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = dgList.CurrentRow.Cells[4].Value.ToString();
                byte[] Picture = (byte[])dgList.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(Picture);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        /*private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    MessageBox.Show("العميل المراد تعديله غير موجود");
                    return;
                }

                byte[] Picture;
                if (pbox.Image == null)
                {
                    Picture = new byte[0];
                    cust.EDIT_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, Picture, "without_image", ID);
                    MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                else
                {

                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    Picture = ms.ToArray();
                    cust.EDIT_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, Picture, "with_image", ID);
                    MessageBox.Show("تم التعديل بنجاح ", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgList.DataSource = cust.GET_ALL_CUSTOMERS();
                }
            }
            catch
            {
                return;
            }
        }*/
            private void button4_Click(object sender, EventArgs e)
            {
                Close();
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("العميل المراد حذفه غير موجود");
                return;
            }
                if (MessageBox.Show("هل تريد فعلا حذف هذا العميل؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cust.DELETE_CUSTOMER(ID);
                }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dgList.DataSource = cust.Search_Customer(txtSearch.Text);
        }
        void Navigate(int Index)
        {
            try
            {
                pbox.Image = null;
                DataRowCollection DRC = cust.GET_ALL_CUSTOMERS().Rows;
                ID = Convert.ToInt32 (DRC[Index][0]);
                txtFirstName.Text = DRC[Index][1].ToString();
                txtLastName.Text = DRC[Index][2].ToString();
                txtTel.Text = DRC[Index][3].ToString();
                txtEmail.Text = DRC[Index][4].ToString();
                byte[] Picture = (byte[])DRC[Index][5];
                MemoryStream ms = new MemoryStream(Picture);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

       
    }
}
