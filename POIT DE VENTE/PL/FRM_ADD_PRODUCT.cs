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
using System.Globalization;

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
        private void btnPicture_Click(object sender, EventArgs e)
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
            if (pbox.Image != null)
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
            else
            {
                MessageBox.Show("ادخل صورة المنتج", "تتنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
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

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);//اداة الفصل العشري
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtRef.Text != string.Empty)
            {
                txtDes.Focus();
            }
        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDes.Text != string.Empty)
            {
                txtQte.Focus();
            }
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQte.Text != string.Empty)
            {
                txtPrice.Focus();
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {
                btnPicture.Focus();
            }
        }


    }
}


