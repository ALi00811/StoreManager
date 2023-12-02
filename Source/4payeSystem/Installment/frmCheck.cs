using _4payeSystem.Customer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4payeSystem.Installment
{
    public partial class frmCheck : Form
    {
        public int InstallmentMonth { get; set; }
        public frmCheck(int InstallmentMonth)
        {
            InitializeComponent();
            this.InstallmentMonth = InstallmentMonth;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            List<string> ListText = new List<string>();
            List<Atf.UI.DateTimeSelector> ListTime = new List<Atf.UI.DateTimeSelector>();


            if (txtCheckNumber1.Text != "" && txtCheckNumber2.Text != "" && dtDateCheck1.Value != null && dtDateCheck2.Value != null)
            {

                ListText.Add(txtCheckNumber1.Text);
                ListText.Add(txtCheckNumber2.Text);
                ListText.Add(txtCheckNumber3.Text);
                ListText.Add(txtCheckNumber4.Text);
                ListText.Add(txtCheckNumber5.Text);
                ListText.Add(txtCheckNumber6.Text);

                ListTime.Add(dtDateCheck1);
                ListTime.Add(dtDateCheck2);
                ListTime.Add(dtDateCheck3);
                ListTime.Add(dtDateCheck4);
                ListTime.Add(dtDateCheck5);
                ListTime.Add(dtDateCheck6);

                SubmitCheckNumberToDb SubmitCheck = new SubmitCheckNumberToDb(ListText, ListTime, InstallmentMonth);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "اطلاعات ناقص";
                    fm.LblText.Text = "ثبت حداقل 2 چک الزامی است";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;
                    fm.ShowDialog();
                }
            }
        }
    }
}
