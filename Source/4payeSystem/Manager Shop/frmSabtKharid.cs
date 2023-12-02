using _4payeSystem.Customer;
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

namespace _4payeSystem.Manager_Shop
{
    public partial class frmSabtKharid : Form
    {
        Entities3 db = new Entities3();
        List<Buy> ListBuyDb = new List<Buy>();
        List<BuyKala> ListBuyKalaDb = new List<BuyKala>();
        public int PriceSend { get; set; }
        public string price { get; set; }
        public int Mojoodi { get; set; }
        public frmSabtKharid()
        {
            InitializeComponent();
            dgvKala.AutoGenerateColumns = false;
            dgvKala.Columns[2].DefaultCellStyle.Format = ("#,0");
            dgvKala.DataSource = db.StorePTblurchases.Where(a => a.Number != 0).ToList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmSabtKharid_Load(object sender, EventArgs e)
        {

        }


        // Mosahebe Qeimat Mahsoolat Sabad Kharid
        public int SetPrice()
        {
            int Price = 0;
            for (int i = 0; i < dgvBuy.RowCount; i++)
            {
                var price = Convert.ToInt32(dgvBuy.Rows[i].Cells[1].Value) * Convert.ToInt32(dgvBuy.Rows[i].Cells[2].Value);
                Price += price;
            }
            PriceSend = Price;
            return Price;
        }
        List<string> listBuy = new List<string>();
        private void dgvKala_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow SelectedRow in dgvKala.SelectedRows)
            {
                if (listBuy.Contains(dgvKala.SelectedCells[0].Value.ToString()))
                {

                }
                else
                {
                    dgvBuy.Rows.Add(SelectedRow.Cells[0].Value, SelectedRow.Cells[1].Value, 1);
                    listBuy.Add(dgvKala.SelectedCells[0].Value.ToString());
                    lblPrice.Text = SetPrice().ToString("#,0");
                }

            }
        }
        private void Searching()
        {
            var query = (from kala in db.TblForooshgahs where kala.KalaName.Contains(txtSearch.Text) select kala);
            dgvKala.DataSource = query.ToList();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Searching();
        }

        private void dgvBuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numTedad.Value = Convert.ToDecimal(dgvBuy.SelectedCells[2].Value);
        }

        private void numTedad_ValueChanged(object sender, EventArgs e)
        {
            if (dgvBuy.Rows.Count > 0)
            {
                dgvBuy.SelectedCells[2].Value = numTedad.Value;
                lblPrice.Text = SetPrice().ToString("#,0");
            }
            else
            {
                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "(( توجه ))";
                    fm.LblText.Text = "محصولی را ابتدا انتخاب کنید";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;

                    fm.ShowDialog();
                }
            }
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            numTedad.Value += 1;
        }

        private void btnMines_Click(object sender, EventArgs e)
        {
            numTedad.Value -= 1;
        }

        private void btnCleayer_Click(object sender, EventArgs e)
        {
            if (dgvBuy.Rows.Count > 0)
            {
                dgvBuy.Rows.Clear();
                listBuy.Clear();
                lblPrice.Text = SetPrice().ToString("#,0");

            }
            else
            {
                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "(( توجه ))";
                    fm.LblText.Text = "سبد خالی میباشد";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;

                    fm.ShowDialog();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvBuy.Rows.Count > 0)
            {
                listBuy.Remove(dgvBuy.SelectedCells[0].Value.ToString());
                dgvBuy.Rows.RemoveAt(dgvBuy.SelectedRows[0].Index);
                lblPrice.Text = SetPrice().ToString("#,0");
            }
            else
            {
                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "(( توجه ))";
                    fm.LblText.Text = "سبد خالی میباشد";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;

                    fm.ShowDialog();
                }
            }
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvBuy.Rows.Count > 0)
            {
                int mojoodi = Convert.ToInt16(dgvKala.CurrentRow.Cells[2].Value);
                using (frmSetCustomer frm = new frmSetCustomer(ListBuyKalaDb , PriceSend,mojoodi))
                {
                    for (int i = 0; i < dgvBuy.Rows.Count; i++)
                    {
                        
                        ListBuyKalaDb.Add(new BuyKala() { Name_kala = dgvBuy.Rows[i].Cells[0].Value.ToString() , Number = Convert.ToInt16(dgvBuy.Rows[i].Cells[2].Value),Price = Convert.ToInt32(dgvBuy.Rows[i].Cells[1].Value) });
                        
                    }
                    frm.lblPrice.Text = SetPrice().ToString("#,0");
                    frm.ShowDialog();

                }
            }
            else
            {
                using (FrmMesssage fm = new FrmMesssage())
                {
                    fm.Text = "(( توجه ))";
                    fm.LblText.Text = "سبد خالی میباشد";
                    fm.PicHoshdar.Visible = true;
                    fm.PicOk.Visible = true;

                    fm.ShowDialog();
                }
            }

        }
    }
}
