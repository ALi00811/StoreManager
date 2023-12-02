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
    public partial class FrmUserEdit : Form
    {
        public int code = 0;
        public Entities3 database = new Entities3();
        Boolean IsPicChanged = false;
        public FrmUserEdit()
        {
            InitializeComponent();
        }

        private void FrmUserEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void PicSave1_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
            {
                var query = ( from ozvha in database.TblUsers where ozvha.ID == code select ozvha ).SingleOrDefault();
                query.Name = TxtName.Text;
                query.BirthDate = CmbYearBirth.Text + "/" + CmbMonthBirth.Text + "/" + CmbDayBirth.Text;
                query.OzviatDate = CmbYearSabt.Text + "/" + CmbMonthSabt.Text + "/" + CmbDaySabt.Text;
                query.EtebarDate = CmbYearEtebar.Text + "/" + CmbMonthEtebar.Text + "/" + CmbDayEtebar.Text;

                database.SaveChanges();
                if (IsPicChanged == true)
                {
                    PicUserImage.Image.Save(Application.StartupPath + "\\Pics\\" + code + ".jpg");
                }
                FrmMesssage fm = new FrmMesssage();
                fm.Text = "ویرایش عضو";
                fm.LblText.Text = "ویرایش با موفقیت انجام شد";
                fm.PicHoshdar.Visible = true;
                fm.PicOk.Visible = true;
                fm.ShowDialog();
                this.Close();


            }

        }

        private void PicCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "(*.*)|*.*";
                ofd.Title = ("تصویر را انتخاب کنید");
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName == Application.StartupPath + "\\Pics\\" + code.ToString() + ".jpg")
                    {
                        MessageBox.Show("تصویر تکراری است!!");

                    }

                    else
                    {
                        PicUserImage.Load(ofd.FileName);
                        IsPicChanged = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("فایل غیر مجاز");
            }
        }
    }
}
