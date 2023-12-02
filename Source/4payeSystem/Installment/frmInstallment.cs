using _4payeSystem.Customer;
using _4payeSystem.Installment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4payeSystem
{
    public partial class frmInstallment : Form
    {
        public bool permision { get; set; } = false;
        public int InstallmentMonth { get; set; } = 1;
        public frmInstallment()
        {
            InitializeComponent();
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLongTime_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckNumber.ReadOnly = true;
            gpTypeInstallment.Visible = true;
            btnWriteCheck.Visible = true;

        }

        private void cbOneMonth_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckNumber.ReadOnly = false;
            gpTypeInstallment.Visible = false;
            btnWriteCheck.Visible = false;
        }

        private void btnWriteCheck_Click(object sender, EventArgs e)
        {
            if (new frmCheck(InstallmentMonth).ShowDialog() == DialogResult.OK)
            {
                permision = true;
            }
        }

        frmSetCustomer SetCustomer = Application.OpenForms.OfType<frmSetCustomer>().FirstOrDefault();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!permision)
            {
                if (cbOneMonth.Checked && txtCheckNumber.Text != "" && txtPrepayment.Text != "" && dtDueDate.Value != null)
                {
                    SetCustomer.ListBuyToDb.Add(new Model.TblBuy() { Check_number1 = txtCheckNumber.Text, Prepayment = Convert.ToInt64(txtPrepayment.Text), Date_Check1 = dtDueDate.Value,Installments = InstallmentMonth });
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    using (FrmMesssage fm = new FrmMesssage())
                    {
                        fm.Text = "اطلاعات ناقص";
                        fm.LblText.Text = "مقادیر را کامل کنید";
                        fm.PicHoshdar.Visible = true;
                        fm.PicOk.Visible = true;
                        fm.ShowDialog();
                    }
                }
            }
            else
            {
                if (txtPrepayment.Text != "")
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    using (FrmMesssage fm = new FrmMesssage())
                    {
                        fm.Text = "اطلاعات ناقص";
                        fm.LblText.Text = "مقادیر را کامل کنید";
                        fm.PicHoshdar.Visible = true;
                        fm.PicOk.Visible = true;
                        fm.ShowDialog();
                    }
                }
            }
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            InstallmentMonth = 3;
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            InstallmentMonth = 6;
        }

        private void rb12_CheckedChanged(object sender, EventArgs e)
        {
            InstallmentMonth = 12;
        }
    }
}
