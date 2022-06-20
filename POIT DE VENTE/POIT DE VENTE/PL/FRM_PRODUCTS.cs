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
    public partial class FRM_PRODUCTS : Form
    {
        private static FRM_PRODUCTS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt=prd.SearchProduct(txtSearch.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void FRM_PRODUCTS_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد فعلا حذف هذا المنتج؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                prd.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تحديث المنتج"+this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnOk.Text = "تعديل";
            frm.state = "apdate";
            frm.txtRef.ReadOnly = true;
            byte[] image=(byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* private void txtSearch_TextChanged(object sender, EventArgs e)
         {

         }*/
    }
}
