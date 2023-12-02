using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4payeSystem
{
    public partial class FrmMesssage : Form
    {
        public Boolean Result = false;
        public FrmMesssage()
        {
            InitializeComponent();
        }

        private void PicYes_Click(object sender, EventArgs e)
        {
            Result = true;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PicCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicOk_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
