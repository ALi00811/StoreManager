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
using _4payeSystem.Convertor;

namespace _4payeSystem.ListOfAccounts
{
    public partial class frmCreditor : Form
    {
        Entities3 db;
        public frmCreditor()
        {
            InitializeComponent();
            SetNameDGV();

        }
        private void SetNameDGV()
        {
            using (Entities3 db = new Entities3())
            {
                var data = db.TblBuys.Where(d => d.Installments != 0).ToList();
                foreach (var item in data)
                {
                    dgvUserCreditor.Rows.Add(item.Name);
                }
            }
        }

        public void RefreshUserInfo()
        {
            dgvUserInfo.Rows.Clear();
            using (Entities3 db = new Entities3())
            {
                string name = "";
                foreach (DataGridViewCell item in dgvUserCreditor.SelectedCells)
                {
                    name = item.Value.ToString();
                }
                var data = db.TblBuys.Where(d => d.Name.Contains(name) && d.Installments != 0).ToList();

                dgvUserInfo.AutoGenerateColumns = false;
                foreach (var item in data)
                {
                    dgvUserInfo.Rows.Add(
                        item.Name,item.Price,item.DateTime_Buy.ToShamsi(),item.Installments,item.Prepayment,item.Record
                        );
                }
                
                dgvUserInfo.Visible = true;
                btnCheckInfo.Visible = true;
                btnClearing.Visible = true;
            }
        }

        private void dgvUserCreditor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshUserInfo();
        }

        private void ViewInfoCheck()
        {
            using (Entities3 db = new Entities3())
            {
                var result = dgvUserInfo.CurrentRow.Cells["Record"].Value.ToString();
                int record = Convert.ToInt16(result);
                new frmCheckInfo(record).ShowDialog();
            }
        }

        private void btnCheckInfo_Click(object sender, EventArgs e)
        {
            ViewInfoCheck();
        }

        private void frmCreditor_Load(object sender, EventArgs e)
        {

        }

        private void dgvUserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewInfoCheck();
        }
        protected void Clearin()
        {
            using (FrmMesssage fm = new FrmMesssage())
            {
                fm.Text = "(( تسویه ))";
                fm.LblText.Text = "از تسویه حساب خریدار مطمئن هستید ؟؟";
                fm.PicHoshdar.Visible = true;
                fm.PicYes.Visible = true;
                fm.PicNo.Visible = true;




                if (fm.ShowDialog() == DialogResult.OK)
                {
                    using (Entities3 db = new Entities3())
                    {
                        int SelectRecord = Convert.ToInt16(dgvUserInfo.CurrentRow.Cells["Record"].Value);
                        var customer = (from c in db.TblBuys where c.Record == SelectRecord select c).FirstOrDefault();
                        customer.Installments = 0;
                        db.SaveChanges();

                        RefreshUserInfo();
                        SetNameDGV();

                        fm.Text = "(( تسویه ))";
                        fm.LblText.Text = "حساب خریدار با موفقیت تسویه شد";

                        fm.PicHoshdar.Visible = false;
                        fm.PicYes.Visible = false;
                        fm.PicNo.Visible = false;

                        fm.PicKhabar.Visible = true;
                        fm.PicOk.Visible = true;

                        fm.ShowDialog();



                    }
                }
            }
        }
        private void btnClearing_Click(object sender, EventArgs e)
        {
            Clearin();
        }
    }
}
