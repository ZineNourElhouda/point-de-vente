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
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string state = "add";
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();

        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategories.DataSource = prd.GET_ALL_CATEGORIES();
            cmbCategories.DisplayMember = "DESCRIPTION_CAT";
            cmbCategories.ValueMember = "ID_CAT";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور|*.JPG;*.PNG; .*GIF;.*BMP ";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
                if (state == "add")
                {

                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    prd.ADD_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text, txtRef.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);
                    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();

                    prd.UPDATE_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text, txtRef.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);
                    MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FRM_PRODUCTS.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.VerifyProductID(txtRef.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا", "تتنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pbox_Click(object sender, EventArgs e)
        {

        }

       
    }
}


