using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4payeSystem.Model;

namespace _4payeSystem
{
    public partial class FrmUserManagement : Form
    {
        Entities3 database = new Entities3();

        public object PicUserImage { get; private set; }

        public FrmUserManagement()
        {
            InitializeComponent();
            GrdList.AutoGenerateColumns = false;
            GrdList.DataSource = database.TblUsers.ToList();
        }

        private void FrmUserManagement_Load(object sender, EventArgs e)
        {
            GrdList.DataSource = database.TblUsers.ToList();
        }

        private void GrdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GrdList.AutoGenerateColumns = false;
            GrdList.DataSource = database.TblUsers.ToList();
        }

        private void Searching()
        {
            if (TxtSearchCode.Text != "")
            {
                int code = Convert.ToInt32(TxtSearchCode.Text);
                var query = (from ozvvha in database.TblUsers where ozvvha.Name.Contains(TxtSearchName.Text) && ozvvha.ID == code || ozvvha.MeliCode.Contains(TxtSearchCode.Text) select ozvvha );
                

                GrdList.DataSource = query.ToList();
            }
            else
            {
                
                var query = (from ozvvha in database.TblUsers where ozvvha.Name.Contains(TxtSearchName.Text) select ozvvha);
                GrdList.DataSource = query.ToList();
            }
        }


        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            Searching();
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {

            using (FrmMesssage fm = new FrmMesssage())
            {
                if (GrdList.RowCount == 0)
                {

                    fm.Text = "(( اخطار ))";
                    fm.LblText.Text = "کاربری برا نمایش وجود ندارد";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;

                    fm.ShowDialog();

                    return;
                }
            }
            try
            {


                using (FrmDetails fd = new FrmDetails())
                {
                    fd.LblCode.Text = GrdList.CurrentRow.Cells["ID"].Value.ToString();
                    fd.LblName.Text = GrdList.CurrentRow.Cells["UserName"].Value.ToString();
                    fd.LblTT.Text = GrdList.CurrentRow.Cells["BirthDate"].Value.ToString();
                    fd.LblTE.Text = GrdList.CurrentRow.Cells["EtebarDate"].Value.ToString();
                    fd.LblTS.Text = GrdList.CurrentRow.Cells["OzviatDate"].Value.ToString();
                    fd.LblKomod.Text = GrdList.CurrentRow.Cells["komod"].Value.ToString();

                    fd.PicUserImage.Load(Application.StartupPath + "\\Pics\\" + GrdList.CurrentRow.Cells[0].Value.ToString() + ".jpg");
                    fd.ShowDialog();
                }
            }
            catch
            {
                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "خطا";
                    fm.LblText.Text = "در نمایش اطلاعات کاربر خطایی وجود دارد";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;
                    fm.ShowDialog();
                }
                
            }

        }

        

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            using (FrmMesssage fm = new FrmMesssage())
            {
                if (GrdList.RowCount == 0)
                {

                    fm.Text = "(( اخطار ))";
                    fm.LblText.Text = "کاربری برا ویرایش وجود ندارد";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;

                    fm.ShowDialog();

                    return;
                }
            }

            string sindex = "";



            using (FrmUserEdit fue = new FrmUserEdit())
            {
                int i;
                for (i = 1; i <= 31; i++)
                {
                    fue.CmbDayBirth.Items.Add(i.ToString());
                }

                for (i = 1; i <= 12; i++)
                {
                    fue.CmbMonthBirth.Items.Add(i.ToString());
                }

                for (i = 1350; i <= 1450; i++)
                {
                    fue.CmbYearBirth.Items.Add(i.ToString());
                }
                ///////////////////////////////

                // input User Singin //
                for (i = 1; i <= 31; i++)
                {
                    fue.CmbDaySabt.Items.Add(i.ToString());

                }

                for (i = 1; i <= 12; i++)
                {
                    fue.CmbMonthSabt.Items.Add(i.ToString());
                }

                for (i = 1350; i <= 1450; i++)
                {
                    fue.CmbYearSabt.Items.Add(i.ToString());
                }
                ////////////////////////

                // input User Date License //
                for (i = 1; i <= 31; i++)
                {
                    fue.CmbDayEtebar.Items.Add(i.ToString());
                }

                for (i = 1; i <= 12; i++)
                {
                    fue.CmbMonthEtebar.Items.Add(i.ToString());
                }

                for (i = 1350; i <= 1450; i++)
                {
                    fue.CmbYearEtebar.Items.Add(i.ToString());
                }

                // Set Defult in App
                fue.CmbDayBirth.SelectedIndex = 0;
                fue.CmbMonthBirth.SelectedIndex = 0;
                fue.CmbYearBirth.SelectedIndex = 0;
                fue.CmbDayEtebar.SelectedIndex = 0;
                fue.CmbMonthEtebar.SelectedIndex = 0;
                fue.CmbYearEtebar.SelectedIndex = 0;
                fue.CmbMonthSabt.SelectedIndex = 0;
                fue.CmbDaySabt.SelectedIndex = 0;
                fue.CmbYearSabt.SelectedIndex = 0;



                fue.code = Convert.ToInt32(GrdList.CurrentRow.Cells["ID"].Value.ToString());


                fue.TxtName.Text = GrdList.CurrentRow.Cells["UserName"].Value.ToString();

                fue.txtMeliCode.Text = GrdList.CurrentRow.Cells["MeliCode"].Value.ToString();
                //Edit for FormSabtName (DateBirthday)
                sindex = GrdList.CurrentRow.Cells["BirthDate"].Value.ToString().Substring(0, 4);
                fue.CmbYearBirth.SelectedIndex = Convert.ToInt32(sindex) - 1350;


                sindex = GrdList.CurrentRow.Cells["BirthDate"].Value.ToString().Substring(5, 2);
                sindex = sindex.Replace("/", "");
                fue.CmbMonthBirth.SelectedIndex = Convert.ToInt32(sindex) - 1;


                sindex = GrdList.CurrentRow.Cells["BirthDate"].Value.ToString().Substring(GrdList.CurrentRow.Cells["BirthDate"].Value.ToString().Length - 2, 2);
                sindex = sindex.Replace("/", "");
                fue.CmbDayBirth.SelectedIndex = Convert.ToInt32(sindex) - 1;

                //------------------------
                //Edit for FormSabtName (DateEtebar)
                sindex = GrdList.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(0, 4);
                fue.CmbYearEtebar.SelectedIndex = Convert.ToInt32(sindex) - 1350;


                sindex = GrdList.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(5, 2);
                sindex = sindex.Replace("/", "");
                fue.CmbMonthEtebar.SelectedIndex = Convert.ToInt32(sindex) - 1;


                sindex = GrdList.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(GrdList.CurrentRow.Cells["BirthDate"].Value.ToString().Length - 2, 2);
                sindex = sindex.Replace("/", "");
                fue.CmbDayEtebar.SelectedIndex = Convert.ToInt32(sindex) - 1;

                //----------------------
                //Edit for FormSabtName (OzviatDate)
                sindex = GrdList.CurrentRow.Cells["OzviatDate"].Value.ToString().Substring(0, 4);
                fue.CmbYearSabt.SelectedIndex = Convert.ToInt32(sindex) - 1350;


                sindex = GrdList.CurrentRow.Cells["OzviatDate"].Value.ToString().Substring(5, 2);
                sindex = sindex.Replace("/", "");
                fue.CmbMonthSabt.SelectedIndex = Convert.ToInt32(sindex) - 1;


                sindex = GrdList.CurrentRow.Cells["OzviatDate"].Value.ToString().Substring(GrdList.CurrentRow.Cells["BirthDate"].Value.ToString().Length - 2, 2);
                sindex = sindex.Replace("/", "");
                fue.CmbDaySabt.SelectedIndex = Convert.ToInt32(sindex) - 1;

                //----------------------

                fue.PicUserImage.Load(Application.StartupPath + "\\Pics\\" + GrdList.CurrentRow.Cells[0].Value.ToString() + ".jpg");



                fue.ShowDialog();

                database = fue.database;
                GrdList.DataSource = database.TblUsers.ToList();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FrmMesssage fm = new FrmMesssage();

            if(GrdList.RowCount == 0)
            {
                
                fm.Text = "(( اخطار ))";
                fm.LblText.Text = "کاربری برا حذف وجود ندارد";
                fm.PicHoshdar.Visible = true;
                fm.PicOk.Visible = true;

                fm.ShowDialog();

                return;
            }





            fm.Text = "(( حذف عضو ))";
            fm.LblText.Text = "از حذف کاربر اطمینان دارید؟";
            fm.PicHoshdar.Visible = true;
            fm.PicYes.Visible = true;
            fm.PicNo.Visible = true;

            fm.ShowDialog();

            if (fm.Result == true)
            {
                int Code = Convert.ToInt32(GrdList.CurrentRow.Cells["ID"].Value.ToString());
                var query = (from ozvha in database.TblUsers where ozvha.ID == Code select ozvha).SingleOrDefault();
                database.TblUsers.Remove(query);
                database.SaveChanges();

                GrdList.DataSource = database.TblUsers.ToList();

                try
                {
                    System.IO.File.Delete(Application.StartupPath + "\\Pics\\" + Code + ".jpg");
                }
                catch
                {

                }
            }
        }
        
        private void TxtSearchCode_TextChanged(object sender, EventArgs e)
        {
            ReplaceNumber.ChangeNum(TxtSearchCode);
            Searching();
        }

        private void TxtSearchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

        private void GrdList_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(null, null);
        }
    }
}
