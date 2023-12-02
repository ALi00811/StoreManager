using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using _4payeSystem.Manager_Shop;
using _4payeSystem.ListOfAccounts;
using _4payeSystem.Model;
using _4payeSystem.Store_purchases;
using _4payeSystem.Accounting;

namespace _4payeSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }
        
        private void ribbonBar1_ItemClick_1(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            analogClockControl1.Value = System.DateTime.Now;
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            new FrmForooshGah().ShowDialog();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            FrmSabtNam fsn = new FrmSabtNam();
            fsn.ShowDialog();
        }

        private void BtnManagerUser_Click(object sender, EventArgs e)
        {
            FrmUserManagement fum = new FrmUserManagement();
            fum.ShowDialog();
        }

        private void analogClockControl1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            analogClockControl1.Value = System.DateTime.Now;

            DateTime today = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();

            LblYear.Text = pc.GetYear(today).ToString("0000");
            LblMonth.Text = pc.GetMonth(today).ToString("00");
            LblDay.Text = pc.GetDayOfMonth(today).ToString("00");

            switch (pc.GetDayOfWeek(today).ToString())
            {
                case "Saturday":
                    {
                        LblDayName.Text = "(( شنیه ))";
                        break;
                    }
                case "Sunday":
                    {
                        LblDayName.Text = "(( یکشنبه ))";
                        break;
                    }
                case "Monday":
                    {
                        LblDayName.Text = "(( دوشنیه ))";
                        break;
                    }
                case "Tuesday":
                    {
                        LblDayName.Text = "(( سه شنیه ))";
                        break;
                    }
                case "Wednesday":
                    {
                        LblDayName.Text = "(( چهارشنبه ))";
                        break;
                    }
                case "Thursday":
                    {
                        LblDayName.Text = "(( پنج شنیه ))";
                        break;
                    }
                case "Friday":
                    {
                        LblDayName.Text = "(( جمعه ))";
                        break;
                    }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            using (FrmMesssage fm = new FrmMesssage())
            {
                fm.Text = "(( خروج ))";
                fm.LblText.Text = "از خروج خود اطمینان دارید؟";
                fm.PicSoal.Visible = true;
                fm.PicYes.Visible = true;
                fm.PicNo.Visible = true;

                fm.ShowDialog();

                if (fm.Result == true)
                {
                    Application.Exit();
                }
            }
        }

        private void BtnSavabeqUser_Click(object sender, EventArgs e)
        {
            FrmSavabeq fs = new FrmSavabeq();
            fs.ShowDialog();
        }
        

        private void BtnInffo_Click(object sender, EventArgs e)
        {
            new FrmInffo().ShowDialog();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            using (frmSabtKharid frm = new frmSabtKharid())
            {
                frm.ShowDialog();
            }

        }
        
        

        private void buttonItem1_Click_1(object sender, EventArgs e)
        {
            new frmCreditor().ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            new frmDebtor().ShowDialog();
        }

        private void btnInfo_Click_1(object sender, EventArgs e)
        {
            new FrmInffo().ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void btnPurchaseRecords_Click(object sender, EventArgs e)
        {
            new frmStorePurchases().ShowDialog();
        }

        private void btnShopManager_Click(object sender, EventArgs e)
        {
            new FrmForooshGah().ShowDialog();
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            new frmAccounting().ShowDialog();
        }
    }
}
