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
    public partial class FRM_ORDERS_LIST : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        public FRM_ORDERS_LIST()
        {
            InitializeComponent();
            this.dgvOrders.DataSource = order.SearchOrders("");
        }

        private void FRM_ORDERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int order_ID = Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value);
            RPT.RPT_ORDERS report = new RPT.RPT_ORDERS();
            RPT.FRM_RPT_ORDERS frm = new RPT.FRM_RPT_ORDERS();
            report.SetDataSource(order.GetOrderDetails(order_ID));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvOrders.DataSource = order.SearchOrders(txtSearch.Text);

            }
            catch
            {
                return;
            }
        }
    }
}
