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
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            this.dgvCustomers.DataSource = cust.GET_ALL_CUSTOMERS();
            this.dgvCustomers.Columns[0].Visible = false;//عدم عرض العمود ذو الرتبة 0 في قاعدة البيانات 
            this.dgvCustomers.Columns[5].Visible = false;
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
