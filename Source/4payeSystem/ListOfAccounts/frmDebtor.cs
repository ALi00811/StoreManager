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

namespace _4payeSystem.ListOfAccounts
{
    public partial class frmDebtor : Form
    {
        public frmDebtor()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            using (Entities3 db = new Entities3())
            {
                var data = db.StorePTblurchases.Where(d => d.installment == 1).ToList();
                foreach (var item in data)
                {
                    dgvUserDebtor.Rows.Add(item.Name_kala);
                }
            }
        }
        private void dgvUserDebtor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void RefreshKala()
        {
            using (Entities3 db = new Entities3())
            {
                string name = "";
                foreach (DataGridViewCell item in dgvUserDebtor.SelectedCells)
                {
                    name = item.Value.ToString();
                }
                var data = db.StorePTblurchases.Where(d => d.Name_kala.Contains(name) && d.installment != 0).ToList();

                dgvInfoKala.AutoGenerateColumns = false;
                
                dgvInfoKala.DataSource = data;
            }
        }

        private void dgvUserDebtor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshKala();
            dgvInfoKala.Visible = true;
            btnClearing.Visible = true;
        }

        private void btnClearing_Click(object sender, EventArgs e)
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
                        string Kala_Name = dgvInfoKala.CurrentRow.Cells["Name_kala"].Value.ToString();
                        int id = Convert.ToInt16(dgvInfoKala.CurrentRow.Cells["ID"].Value);
                        var data = (from c in db.StorePTblurchases where c.Name_kala.Contains(Kala_Name) && c.ID == id select c).FirstOrDefault();
                        data.installment = 0;
                        db.SaveChanges();

                        RefreshKala();
                        
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
    }
}
