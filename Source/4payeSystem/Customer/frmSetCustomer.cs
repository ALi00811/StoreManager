using _4payeSystem.Manager_Shop;
using _4payeSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4payeSystem.Customer
{
    public partial class frmSetCustomer : Form
    {
        public string SerialBuy { get; set; } = Guid.NewGuid().ToString();
        public int IDCustomer { get; set; }
        List<BuyKala> dgv = new List<BuyKala>();
        public List<TblBuy> ListBuyToDb = new List<TblBuy>();
        public int PriceSend { get; set; }

        public int mojoodi { get; set; }

        public frmSetCustomer(List<BuyKala> dgv ,int Price, int mojoodi)
        {
            InitializeComponent();
            this.mojoodi = mojoodi;
            this.dgv = dgv;
            Refresh();
            lblTypeBuy.Text = "نقدی";
            PriceSend = Price;
            lblNameCustomer.Text = cbUser.GetItemText(cbUser.SelectedItem);



        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            new FrmSabtNam().ShowDialog();
            Refresh();
        }

        public void Refresh()
        {
            using (Entities3 db = new Entities3())
            {
                List<string> Name = new List<string>();
                var data = db.TblUsers.Where(u => u.ID != 0).ToList();
                foreach (var item in data)
                {
                    Name.Add(item.Name);
                }
                cbUser.DataSource = Name;
            }
            lblNameCustomer.Text = cbUser.GetItemText(cbUser.SelectedItem);

        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void cbInstallment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInstallment.Checked)
            {
                if (new frmInstallment().ShowDialog() == DialogResult.OK)
                {
                    cbInstallment.Checked = true;
                    lblTypeBuy.Text = "اقساطی";
                    InterestPercentageInterview Percent = new InterestPercentageInterview();
                    ListBuyToDb[0].Price = Percent.Computing(ListBuyToDb[0].Installments, PriceSend);
                    CalculateThePrice cal = new CalculateThePrice();
                    ListBuyToDb[0].Price = cal.FinallyPrice(ListBuyToDb[0].Price, ListBuyToDb[0].Prepayment);
                    lblPrice.Text = ListBuyToDb[0].Price.ToString();
                }
                else
                {
                    lblTypeBuy.Text = "نقدی";
                    cbCash.Checked = true;
                    cbInstallment.Checked = false;
                }
            }


        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            lblTypeBuy.Text = "نقدی";
        }
        
        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNameCustomer.Text = cbUser.GetItemText(cbUser.SelectedItem);
        }

        public void FineIDCustomer(Entities3 db)
        {
            var database = db.TblUsers.Where(i => i.Name.Contains(cbUser.SelectedValue.ToString())).ToList();
            foreach (var item in database)
            {
                IDCustomer = item.ID;
            }
        }
        frmSabtKharid SabtKharid = Application.OpenForms.OfType<frmSabtKharid>().FirstOrDefault();

        private void btnFinallyBuy_Click(object sender, EventArgs e)
        {
            if (cbCash.Checked && cbUser.SelectedIndex >= 0)
            {
                using (Entities3 db = new Entities3())
                {
                    FineIDCustomer(db);
                    SubmitKalaToDb submit = new SubmitKalaToDb(db,dgv, IDCustomer, mojoodi, SerialBuy);
                    SubmitBuyUserToDb SubmitUser = new SubmitBuyUserToDb(ListBuyToDb, IDCustomer, db, cbUser.SelectedValue.ToString(), PriceSend, SerialBuy,lblTypeBuy.Text, PriceSend);

                    using (FrmMesssage fm = new FrmMesssage())
                    {
                        fm.Text = "(( خرید نهایی ))";
                        fm.LblText.Text = "خرید با موفقیت ثبت شد";
                        fm.PicKhabar.Visible = true;
                        fm.PicOk.Visible = true;

                        fm.ShowDialog();
                        
                    }
                    this.Close();
                    SabtKharid.Close();
                }
            }
            else
            {
                using (Entities3 db = new Entities3())
                {
                    FineIDCustomer(db);
                    SubmitKalaToDb SubmitKala = new SubmitKalaToDb(db, dgv, IDCustomer, mojoodi, SerialBuy);
                    SubmitBuyUserToDb SubmitUser = new SubmitBuyUserToDb(ListBuyToDb, IDCustomer, db, cbUser.SelectedValue.ToString(), PriceSend, SerialBuy,lblTypeBuy.Text, PriceSend);
                    using (FrmMesssage fm = new FrmMesssage())
                    {
                        fm.Text = "(( خرید نهایی ))";
                        fm.LblText.Text = "خرید با موفقیت ثبت شد";
                        fm.PicKhabar.Visible = true;
                        fm.PicOk.Visible = true;

                        fm.ShowDialog();
                    }
                    this.Close();
                    SabtKharid.Close();




                }
            }
        }
    }
}
