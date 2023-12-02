using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4payeSystem.Accounting
{
    public partial class frmAccounting : Form
    {
        public frmAccounting()
        {
            InitializeComponent();
            ReportViewModelWarehouse report = WarehouseAuditStore.ReportForMain();
            lblAllBuy.Text = report.AllBalance.ToString("#,0");
            lblSell.Text = report.Sell.ToString("#,0");
            lblCurentValue.Text = report.CurentValueStore.ToString("#,0");
            lblCorbetValue.Text = report.CorbetStore.ToString("#,0");
            lblCommodityStore.Text = report.AllCommodity.ToString("#,0");

            /////////////////////////////////

            ReportViewModelSell report2 = WarehouseAuditSell.ReportForMain();
            lblSellAll.Text = report2.SellAll.ToString("#,0");
            lblSellCash.Text = report2.SellCash.ToString("#,0");
            lblSellInstallment.Text = report2.SellInstallment.ToString("#,0");
            lblAllSellCommodity.Text = report2.AllSellCommodity.ToString("#,0");
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
