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
using _4payeSystem.Print;
using _4payeSystem.Convertor;

namespace _4payeSystem
{

    public partial class FrmSavabeq : Form
    {
        Entities3 database = new Entities3();
        private void searching()
        {
            if (TxtSearchName.Text != "")
            {

                var query = (from tarakonesh in database.TblBuys where tarakonesh.Name.Contains(TxtSearchName.Text) select tarakonesh);
                GrdList.DataSource = query.ToList();
            }

        }
        public FrmSavabeq()
        {
            InitializeComponent();
            SetCulomns();

        }
        protected void SetCulomns()
        {
            using (Entities3 db = new Entities3())
            {
                GrdList.AutoGenerateColumns = false;
                var data = db.TblBuys.ToList();
                foreach (var item in data)
                {
                    
                    GrdList.Rows.Add(
                        item.ID,item.Name, Analize(item.Price,item.Prepayment), item.Type_Buy,item.DateTime_Buy.ToShamsi(),item.SerialBuy
                        );
                }
            }
        }
        protected long? Analize(long? APrice ,long? Prepayment )
        {
            long? price = 0;
            if (Prepayment == null)
            {
                Prepayment = 0;
            }
            price = APrice + Prepayment;
            return price;
        }
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            searching();
        }

        private void FrmSavabeq_Load(object sender, EventArgs e)
        {
        }

        private void GrdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            searching();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (Entities3 db = new Entities3())
            {
                var SerialBuy = GrdList.CurrentRow.Cells["SerialBuy"].Value.ToString();
                var User = db.TblBuys.Where(u => u.SerialBuy.Contains(SerialBuy)).ToList();
                var kalas = db.TblBuyKalas.Where(k => k.SerialBuy.Contains(SerialBuy)).ToList();
                PrintReport print = new PrintReport();
                string type = GrdList.CurrentRow.Cells["Type_Buy"].Value.ToString();
                if (type == "نقدی")
                {
                    print.PrintRepoertCash(stiPrint, User, kalas, type);
                }
                else
                {
                    print.PrintReportInstallment(stiPrint, User, kalas, type);

                }
            }


        }
    }
}
