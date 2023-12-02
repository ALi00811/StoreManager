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

namespace _4payeSystem.Store_purchases
{
    public partial class frmStorePurchases : Form
    {
        public int Type = 0;
        public int ID { get; set; }
        public frmStorePurchases()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected void Eraser()
        {
            txtMark.Text = "";
            txtNameKala.Text = "";
            txtSerialNumber.Text = "";
            numNumber.Value = 1;
            numPriceBuy.Value = 0;
            numPriceSell.Value = 0;
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Eraser();
        }
        protected void Submit()
        {
            using (FrmMesssage fm = new FrmMesssage())
            {

                fm.Text = "(( ثبت کالا ))";
                fm.LblText.Text = "ثبت با موفقیت ثبت شد";
                fm.PicKhabar.Visible = true;
                fm.PicOk.Visible = true;

                fm.ShowDialog();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameKala.Text != "" && numNumber.Value != 0 && numPriceBuy.Value != 0 && numPriceSell.Value != 0)
            {
                if (Type == 0)
                {
                    using (Entities3 db = new Entities3())
                    {
                        StorePTblurchas store = new StorePTblurchas();
                        try
                        {
                            store.Name_kala = txtNameKala.Text;
                            store.Number = (int)numNumber.Value;
                            store.Mark = txtMark.Text;
                            store.PriceBuy = (Int64)numPriceBuy.Value;
                            store.PriceSell = (Int64)numPriceSell.Value;
                            store.SerialNumber = txtSerialNumber.Text;
                            if (rbInstallment.Checked)
                            {
                                store.installment = 1;
                            }
                            else
                            {
                                store.installment = 0;
                            }
                            store.Price = (Int64)numPriceBuy.Value * (int)numNumber.Value;
                            

                        }
                        catch
                        {
                            Error();
                        }

                        db.StorePTblurchases.Add(store);
                        db.SaveChanges();
                        Submit();
                        Eraser();



                    }
                }
                else
                {
                    using (Entities3 db = new Entities3())
                    {
                        StorePTblurchas store = new StorePTblurchas();
                        try
                        {
                            
                            var data = (from d in db.StorePTblurchases where d.ID == ID select d).FirstOrDefault();

                            data.Name_kala = txtNameKala.Text;
                            data.Number = (int)numNumber.Value;
                            data.Mark = txtMark.Text;
                            data.PriceBuy = (Int64)numPriceBuy.Value;
                            data.PriceSell = (Int64)numPriceSell.Value;
                            data.SerialNumber = txtSerialNumber.Text;
                            if (rbInstallment.Checked)
                            {
                                data.installment = 1;
                            }
                            else
                            {
                                data.installment = 0;
                            }
                            data.Price = (Int64)numPriceBuy.Value * (int)numNumber.Value;
                            

                        }
                        catch
                        {
                            Error();
                        }

                        
                        db.SaveChanges();
                        Submit();
                        Eraser();

                    }
                }
            }

            else
            {
                using (FrmMesssage fm = new FrmMesssage())
                {

                    fm.Text = "(( توجه ))";
                    fm.LblText.Text = "مقادیر را کامل کنید";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;

                    fm.ShowDialog();
                }
            }
        }
        private void Error()
        {
            using (FrmMesssage fm = new FrmMesssage())
            {

                fm.Text = "(( توجه ))";
                fm.LblText.Text = "در ثبت کالا خطایی به وجود آمد";
                fm.PicHoshdar.Visible = true;
                fm.PicOk.Visible = true;

                fm.ShowDialog();
            }
        }
    }



}
