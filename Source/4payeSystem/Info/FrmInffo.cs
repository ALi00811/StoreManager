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
    public partial class FrmInffo : Form
    {
        public FrmInffo()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(link.Text);
            using (FrmMesssage fm = new FrmMesssage())
            {
                fm.Text = "(( کپی ))";
                fm.LblText.Text = "آدرس سایت کپی شد \n\r\r با ما همراه باشید";
                fm.PicKhabar.Visible = true;
                fm.PicOk.Visible = true;

                fm.ShowDialog();

            }
        }
    }
}
