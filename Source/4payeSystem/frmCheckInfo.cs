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

namespace _4payeSystem
{
    public partial class frmCheckInfo : Form
    {
        public frmCheckInfo( int record)
        {
            InitializeComponent();
            using (Entities3 db = new Entities3())
            {
                var data = db.TblBuys.Where(d => d.Record == record).ToList();
                dgvCheckInfo.AutoGenerateColumns = false;
                foreach (var item in data)
                {
                    dgvCheckInfo.Rows.Add(
                        item.Check_number1,item.Date_Check1.Value.ToShamsi(),
                        item.Check_number2,item.Date_Check2.Value.ToShamsi(),
                        item.Check_number3,item.Date_Check3.Value.ToShamsi(),
                        item.Check_number4,item.Date_Check4.Value.ToShamsi(),
                        item.Check_number5,item.Date_Check5.Value.ToShamsi(),
                        item.Check_number6,item.Date_Check6.Value.ToShamsi()
                        );
                }
                
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
