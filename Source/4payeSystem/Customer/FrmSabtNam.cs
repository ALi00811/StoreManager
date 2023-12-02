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
using _4payeSystem.Model;

namespace _4payeSystem
{
    public partial class FrmSabtNam : Form
    {
        Entities3 database = new Entities3();

        public FrmSabtNam()
        {
            InitializeComponent();
            // input User Birthday //
            int i;
            for (i = 1; i <= 31; i++)
            {
                CmbDayBirth.Items.Add(i.ToString());
            }

            for (i = 1; i <= 12; i++)
            {
                CmbMonthBirth.Items.Add(i.ToString());
            }

            for (i = 1350; i <= 1450; i++)
            {
                CmbYearBirth.Items.Add(i.ToString());
            }
            ///////////////////////////////

            // input User Singin //
            for (i = 1; i <= 31; i++)
            {
                CmbDaySabt.Items.Add(i.ToString());

            }

            for (i = 1; i <= 12; i++)
            {
                CmbMonthSabt.Items.Add(i.ToString());
            }

            for (i = 1350; i <= 1450; i++)
            {
                CmbYearSabt.Items.Add(i.ToString());
            }
            ////////////////////////

            // input User Date License //
            for (i = 1; i <= 31; i++)
            {
                CmbDayEtebar.Items.Add(i.ToString());
            }

            for (i = 1; i <= 12; i++)
            {
                CmbMonthEtebar.Items.Add(i.ToString());
            }

            for (i = 1350; i <= 1450; i++)
            {
                CmbYearEtebar.Items.Add(i.ToString());
            }

            // Set Defult in App
            CmbDayBirth.SelectedIndex = 0;
            CmbMonthBirth.SelectedIndex = 0;
            CmbYearBirth.SelectedIndex = 0;
            CmbDayEtebar.SelectedIndex = 0;
            CmbMonthEtebar.SelectedIndex = 0;
            CmbYearEtebar.SelectedIndex = 0;
            CmbMonthSabt.SelectedIndex = 0;
            CmbDaySabt.SelectedIndex = 0;
            CmbYearSabt.SelectedIndex = 0;



        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void PicAdd_Click(object sender, EventArgs e)
        {

        }

        private void FrmSabtNam_Load(object sender, EventArgs e)
        {

        }

        private void PicAdd1_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;
            PersianCalendar pc = new PersianCalendar();

            int daynum = pc.GetDayOfMonth(today);
            CmbDaySabt.SelectedIndex = daynum - 1;

            int monthnum = pc.GetMonth(today);
            CmbMonthSabt.SelectedIndex = monthnum - 1;

            int yearnum = pc.GetYear(today);
            CmbYearSabt.SelectedIndex = yearnum - 1350;




            PicUserImage.Load(Application.StartupPath + "\\Pics\\4paye.jpg");
            groupPanel2.Enabled = true;
            PicBrowse.Visible = true;
            PicBrowseN.Visible = false;
            groupPanel1.Enabled = true;
            PicAdd1.Visible = false;
            PicAddN.Visible = true;
            PicSave1.Visible = true;
            PicCancel1.Visible = true;
            PicCancelN.Visible = false;
            PicSaveN.Visible = false;


            TxtName.Text = "";
            TxtName.Focus();

        }

        private void PicSave1_Click(object sender, EventArgs e, int _)
        {



        }

        private void PicCancel1_Click(object sender, EventArgs e)
        {
            groupPanel2.Enabled = false;
            groupPanel1.Enabled = false;
            PicAdd1.Visible = true;
            PicAddN.Visible = false;
            PicSave1.Visible = false;
            PicCancel1.Visible = false;
            PicCancelN.Visible = true;
            PicSaveN.Visible = true;
            PicBrowseN.Visible = true;
        }

        private void CmbDaySabt_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDayEtebar.SelectedIndex = CmbDaySabt.SelectedIndex;


        }
        private void SetEtebar()
        {
            CmbDayEtebar.SelectedIndex = CmbDaySabt.SelectedIndex;
            if (CmbMonthSabt.SelectedIndex == 11)
            {
                CmbMonthEtebar.SelectedIndex = 0;
                CmbYearEtebar.SelectedIndex = CmbYearSabt.SelectedIndex + 1;
            }
            else
            {
                CmbMonthEtebar.SelectedIndex = CmbMonthSabt.SelectedIndex + 1;
                CmbYearEtebar.SelectedIndex = CmbYearSabt.SelectedIndex;
            }
        }

        private void CmbMonthSabt_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEtebar();
        }

        private void CmbYearSabt_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEtebar();
        }

        private void PicSaveN_Click(object sender, EventArgs e)
        {

        }

        private void PicSave1_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" && txtMeliCode.Text == "")
            {
                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "ویرایش اعضاء";
                    fm.LblText.Text = "لطفا نام و نام خانوادگی را وارد کنید";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;
                    fm.ShowDialog();
                }
            }
            else
            {
                TblUser tbl = new TblUser();
                tbl.Name = TxtName.Text;
                tbl.MeliCode = txtMeliCode.Text;
                tbl.BirthDate = CmbYearBirth.Text + "/" + CmbMonthBirth.Text + "/" + CmbDayBirth.Text;
                tbl.OzviatDate = CmbYearSabt.Text + "/" + CmbMonthSabt.Text + "/" + CmbDaySabt.Text;
                tbl.EtebarDate = CmbYearEtebar.Text + "/" + CmbMonthEtebar.Text + "/" + CmbDayEtebar.Text;
                tbl.Komod = "ندارد";

                database.TblUsers.Add(tbl);
                database.SaveChanges();


                PicUserImage.Image.Save(Application.StartupPath + "\\Pics\\" + tbl.ID.ToString() + ".jpg");

                barCodeCtrl1.BarCode = tbl.ID.ToString();
                barCodeCtrl1.SaveImage(Application.StartupPath + "\\Pics\\" + tbl.ID.ToString() + "_Barcode.jpg");



                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "افزودن عضو";
                    fm.LblText.Text = "ثبت با موفقیت انجام شد";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;
                    fm.ShowDialog();
                }
                this.Close();
                
                groupPanel2.Enabled = false;
                groupPanel1.Enabled = false;
                PicAdd1.Visible = true;
                PicAddN.Visible = false;
                PicSave1.Visible = false;
                PicCancel1.Visible = false;
                PicCancelN.Visible = true;
                PicSaveN.Visible = true;
                PicBrowseN.Visible = true;

            }

        }



        private void PicBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "(*.*)|*.*";
                    ofd.Title = ("تصویر را انتخاب کنید");
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        PicUserImage.Load(ofd.FileName);
                    }
                }
            }
            catch
            {
                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "انتخاب تصویر";
                    fm.LblText.Text = "فایل غیر مجاز است";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;
                    fm.ShowDialog();
                }

            }
        }

        private void PicUserImage_Click(object sender, EventArgs e)
        {

        }

        private void CmbDayBirth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PicBrowseN_Click(object sender, EventArgs e)
        {

        }

        private void PicCancelN_Click(object sender, EventArgs e)
        {

        }
    }
}
