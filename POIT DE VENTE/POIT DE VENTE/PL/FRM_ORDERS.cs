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
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        DataTable Dt = new DataTable();

        void CalculatTotalAmount()
        {
            if (txtDiscount.Text != string.Empty && txtAmount.Text != string.Empty)
            {
                double Discount = Convert.ToDouble(txtDiscount.Text);
                double Amount = Convert.ToDouble(txtAmount.Text);
                double TotalAmount = Amount - (Amount * (Discount / 100));
                txtTotalAmount.Text = txtTotalAmount.ToString();
            }
        }
        void CalculateAmount()
        {
            if (txtPrice.Text != string.Empty && txtQty.Text != string.Empty)
            {

                txtAmount.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQty.Text)).ToString();
            }

        }
        void ClearBoxes()
        {
            txtIDproduct.Clear();
            txtNameProduct.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtAmount.Clear();
            txtDiscount.Clear();
            txtTotalAmount.Clear();
            btnBrowse.Focus();
                }
        void CreateDataTable()
        {
            Dt.Columns.Add("معرف المنتج");
            Dt.Columns.Add("اسم المنتج");
            Dt.Columns.Add(" ثمن الوحدة");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("المبلغ");
            Dt.Columns.Add("نسبة الخصم(%)");
            Dt.Columns.Add("المبلغ الإجمالي");

            dgvProducts.DataSource = Dt;
        }
        //ملائمة حجم قائمة المنتجات بما يلائم الازرار
        void ResizeDGV()
        {
            this.dgvProducts.RowHeadersWidth = 90;
            this.dgvProducts.Columns[0].Width = 110;
            this.dgvProducts.Columns[1].Width = 185;
            this.dgvProducts.Columns[2].Width = 117;
            this.dgvProducts.Columns[3].Width = 110;
            this.dgvProducts.Columns[4].Width = 115;
            this.dgvProducts.Columns[5].Width = 115;
            this.dgvProducts.Columns[6].Width = 135;

        }
        //استدعاء العناصر
        public FRM_ORDERS()
        {
            InitializeComponent();
            CreateDataTable();
            ResizeDGV();
            txtSalesMan.Text = Program.SalesMan;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtOrderId.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
        }
        // FRM_ORDERS الى FRM_CUSTOMERS_LISTعرض البيانات من
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
            frm.ShowDialog();if(frm.dgvCustomers.CurrentRow.Cells[5].Value is DBNull)
            {
                MessageBox.Show("هذا العميل لا يحتوي على صورة");
                this.txtCustomerID.Text = frm.dgvCustomers.CurrentRow.Cells[0].Value.ToString();
                this.txtFirstName.Text = frm.dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = frm.dgvCustomers.CurrentRow.Cells[2].Value.ToString();
                this.txtTel.Text = frm.dgvCustomers.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = frm.dgvCustomers.CurrentRow.Cells[4].Value.ToString();
                pbox.Image = null;
                return;
            }
            this.txtCustomerID.Text = frm.dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            this.txtFirstName.Text = frm.dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            this.txtLastName.Text = frm.dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            this.txtTel.Text = frm.dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            this.txtEmail.Text = frm.dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            byte[] custPicture =(byte[])frm.dgvCustomers.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(custPicture);
            pbox.Image = Image.FromStream(ms);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //جلب العناصر المذكورة من قائمة المنتجات
        private void button9_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            FRM_PRODUCTS_LIST frm = new FRM_PRODUCTS_LIST();
            frm.ShowDialog();
            txtIDproduct.Text = frm.dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtNameProduct.Text = frm.dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = frm.dgvProducts.CurrentRow.Cells[3].Value.ToString();
            txtQty.Focus();//يبدأالمأشر من هنا
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }
        //منع جميع القيم ماعدا الرقمية منهاو8 هو الكوداسكي لزر الحذف
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator=Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);//اداة الفصل العشري
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtPrice.Text != string.Empty)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQty.Text != string.Empty)
            {
                txtDiscount.Focus();
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculatTotalAmount();
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculatTotalAmount();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculatTotalAmount();
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               for(int i=0; i<dgvProducts.Rows.Count-1;i++)
                {
                    if(dgvProducts.Rows[i].Cells[0].Value.ToString()==txtIDproduct.Text)
                    {
                        MessageBox.Show("هذا المنتج تم إدخاله مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (order.VerifyQty(txtIDOrder.Text, Convert.ToInt32(txtQty.Text)).Rows.Count < 1)
                    {
                        MessageBox.Show("الكمية المدخلة لهذا المنتج غير متاحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                DataRow r = Dt.NewRow();
                r[0] = txtIDproduct.Text;
                r[1] = txtNameProduct.Text;
                r[2] = txtPrice.Text;
                r[3] = txtQty.Text;
                r[4] = txtAmount.Text;
                r[5] = txtDiscount.Text;
                r[6] = txtTotalAmount.Text;
                Dt.Rows.Add(r);
                dgvProducts.DataSource = Dt;
                ClearBoxes();
                //حساب المجموع
                txtSumTotals.Text =
                (from DataGridViewRow row in dgvProducts.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

            }
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                txtIDproduct.Text = this.dgvProducts.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
                txtQty.Text = this.dgvProducts.CurrentRow.Cells[3].Value.ToString();
                txtAmount.Text = this.dgvProducts.CurrentRow.Cells[4].Value.ToString();
                txtDiscount.Text = this.dgvProducts.CurrentRow.Cells[5].Value.ToString();
                txtTotalAmount.Text = this.dgvProducts.CurrentRow.Cells[6].Value.ToString();
                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
                txtQty.Focus();
            }
            catch
            {
                return;
            }
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {

        }

        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtSumTotals.Text =
                (from DataGridViewRow row in dgvProducts.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            dgvProducts.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //اضافة معلومات الفاتورة
           order.ADD_ORDER(Convert.ToInt32(txtIDOrder.Text), dtOrder.Value, Convert.ToInt32(txtCustomerID.Text), txtDesOrder.Text, txtSalesMan.Text);
           //اضافة المنتجات المدخلة
           for(int i=0; i<dgvProducts.Rows.Count-1 ; i++)
            {
                order.ADD_ORDER_DETAILS(dgvProducts.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(txtIDOrder.Text), 
                    Convert.ToInt32( dgvProducts.Rows[i].Cells[3].Value),
                    dgvProducts.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToInt32(dgvProducts.Rows[i].Cells[5].Value),
                    dgvProducts.Rows[i].Cells[4].Value.ToString(),
                    dgvProducts.Rows[i].Cells[6].Value.ToString());

            }
            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
