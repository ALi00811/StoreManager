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
using _4payeSystem.Store_purchases;

namespace _4payeSystem
{
    public partial class FrmForooshGah : Form
    {
        Entities3 database = new Entities3();

        public FrmForooshGah()
        {
            InitializeComponent();
            GrdList.AutoGenerateColumns = false;
            GrdList.Columns[2].DefaultCellStyle.Format = ("#,0");
            GrdList.DataSource = database.StorePTblurchases.ToList();
        }

        private void GrdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GrdList.DataSource = database.StorePTblurchases.ToList();
        }
        private void searching()
        {
            var query = (from kala in database.StorePTblurchases where kala.Name_kala.Contains(TxtSearchName.Text) select kala);
            GrdList.DataSource = query.ToList();
        }
        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            searching();
        }
        public void refresh()
        {
            GrdList.DataSource = database.StorePTblurchases.ToList();
        }
        
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using (FrmMesssage fm = new FrmMesssage())
            {
                if (GrdList.RowCount == 0)
                {
                    fm.Text = "(( اخطار ))";
                    fm.LblText.Text = "کالایی برا نمایش انتخاب نشده است";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;
                    fm.ShowDialog();
                    return;
                }
                else
                {
                    if (Convert.ToInt16(GrdList.CurrentRow.Cells[4].Value.ToString()) == 0)
                    {
                        GrdList.CurrentRow.Cells[4].Value = 1;
                    }
                    using (frmStorePurchases frmedit = new frmStorePurchases())
                    {
                        frmedit.ID = Convert.ToInt16(GrdList.CurrentRow.Cells[0].Value.ToString());
                        frmedit.Type = 1;
                        frmedit.txtNameKala.Text = GrdList.CurrentRow.Cells[1].Value.ToString();
                        frmedit.numNumber.Value = Convert.ToInt16(GrdList.CurrentRow.Cells[4].Value.ToString());
                        frmedit.txtMark.Text = GrdList.CurrentRow.Cells[3].Value.ToString();
                        frmedit.numPriceBuy.Value = Convert.ToInt64(GrdList.CurrentRow.Cells[6].Value.ToString());
                        frmedit.numPriceSell.Value = Convert.ToInt64(GrdList.CurrentRow.Cells[2].Value.ToString());
                        frmedit.txtSerialNumber.Text = GrdList.CurrentRow.Cells[5].Value.ToString();
                        frmedit.Text = "ویرایش کالا";
                        frmedit.ShowDialog();
                    }
                }
                
                refresh();

            }
        }
        private void GrdList_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(null, null);
        }
        private void Refresh()
        {
            GrdList.DataSource = database.StorePTblurchases.ToList();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {

            FrmMesssage fm = new FrmMesssage();

            if (GrdList.RowCount == 0)
            {
                fm.Text = "(( اخطار ))";
                fm.LblText.Text = "کالایی برا حذف وجود ندارد";
                fm.PicHoshdar.Visible = true;
                fm.PicOk.Visible = true;

                fm.ShowDialog();

                return;
            }





            fm.Text = "(( حذف کالا ))";
            fm.LblText.Text = "از حذف کالا اطمینان دارید؟";
            fm.PicHoshdar.Visible = true;
            fm.PicYes.Visible = true;
            fm.PicNo.Visible = true;

            fm.ShowDialog();

            if (fm.Result == true)
            {
                int Code = Convert.ToInt32(GrdList.CurrentRow.Cells["ID"].Value.ToString());
                var query = (from kala in database.StorePTblurchases where kala.ID == Code select kala).SingleOrDefault();
                database.StorePTblurchases.Remove(query);
                database.SaveChanges();

                Refresh();
            }
        }

        private void FrmForooshGah_Load(object sender, EventArgs e)
        {


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
