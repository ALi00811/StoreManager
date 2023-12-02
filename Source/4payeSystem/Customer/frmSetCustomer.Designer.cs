namespace _4payeSystem.Customer
{
    partial class frmSetCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewUser = new DevComponents.DotNetBar.ButtonX();
            this.cbUser = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbInstallment = new System.Windows.Forms.RadioButton();
            this.cbCash = new System.Windows.Forms.RadioButton();
            this.btnFinallyBuy = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.gp = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTypeBuy = new System.Windows.Forms.Label();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.Image = global::_4payeSystem.Properties.Resources.Actions_list_add_user_icon;
            this.btnNewUser.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnNewUser.Location = new System.Drawing.Point(5, 78);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(165, 46);
            this.btnNewUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.Text = "مشتری جدید";
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // cbUser
            // 
            this.cbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUser.DisplayMember = "Text";
            this.cbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.ItemHeight = 39;
            this.cbUser.Location = new System.Drawing.Point(5, 29);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(165, 45);
            this.cbUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbUser.TabIndex = 0;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "یک شخص را انتخاب کنید";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cbUser);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.btnNewUser);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(440, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(182, 177);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 5;
            this.groupPanel1.Text = "اطلاعات خریدار";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.cbInstallment);
            this.groupPanel2.Controls.Add(this.cbCash);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(440, 196);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(182, 153);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 6;
            this.groupPanel2.Text = "نحوه پرداخت";
            // 
            // cbInstallment
            // 
            this.cbInstallment.AutoSize = true;
            this.cbInstallment.BackColor = System.Drawing.Color.Transparent;
            this.cbInstallment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInstallment.Location = new System.Drawing.Point(51, 40);
            this.cbInstallment.Name = "cbInstallment";
            this.cbInstallment.Size = new System.Drawing.Size(76, 41);
            this.cbInstallment.TabIndex = 8;
            this.cbInstallment.Text = "قسطی";
            this.cbInstallment.UseVisualStyleBackColor = false;
            this.cbInstallment.CheckedChanged += new System.EventHandler(this.cbInstallment_CheckedChanged);
            // 
            // cbCash
            // 
            this.cbCash.AutoSize = true;
            this.cbCash.BackColor = System.Drawing.Color.Transparent;
            this.cbCash.Checked = true;
            this.cbCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCash.Location = new System.Drawing.Point(60, 3);
            this.cbCash.Name = "cbCash";
            this.cbCash.Size = new System.Drawing.Size(67, 41);
            this.cbCash.TabIndex = 7;
            this.cbCash.TabStop = true;
            this.cbCash.Text = "نقدی";
            this.cbCash.UseVisualStyleBackColor = false;
            this.cbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // btnFinallyBuy
            // 
            this.btnFinallyBuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinallyBuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinallyBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinallyBuy.Image = global::_4payeSystem.Properties.Resources.coin_add_icon;
            this.btnFinallyBuy.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnFinallyBuy.Location = new System.Drawing.Point(13, 356);
            this.btnFinallyBuy.Name = "btnFinallyBuy";
            this.btnFinallyBuy.Size = new System.Drawing.Size(150, 47);
            this.btnFinallyBuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinallyBuy.TabIndex = 7;
            this.btnFinallyBuy.Text = "نهایی کردن خرید";
            this.btnFinallyBuy.Click += new System.EventHandler(this.btnFinallyBuy_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX2.Image = global::_4payeSystem.Properties.Resources.Actions_list_remove_user_icon;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX2.Location = new System.Drawing.Point(169, 356);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(115, 47);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 8;
            this.buttonX2.Text = "انصراف";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // gp
            // 
            this.gp.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp.Controls.Add(this.lblPrice);
            this.gp.Controls.Add(this.lblTypeBuy);
            this.gp.Controls.Add(this.lblNameCustomer);
            this.gp.Controls.Add(this.label3);
            this.gp.Controls.Add(this.label4);
            this.gp.Controls.Add(this.label2);
            this.gp.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp.Location = new System.Drawing.Point(4, 12);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(430, 337);
            // 
            // 
            // 
            this.gp.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp.Style.BackColorGradientAngle = 90;
            this.gp.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp.Style.BorderBottomWidth = 1;
            this.gp.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp.Style.BorderLeftWidth = 1;
            this.gp.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp.Style.BorderRightWidth = 1;
            this.gp.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp.Style.BorderTopWidth = 1;
            this.gp.Style.CornerDiameter = 4;
            this.gp.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp.TabIndex = 9;
            this.gp.Text = "بازبینی";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(127, 241);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 37);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "مبلغ نهایی :";
            // 
            // lblTypeBuy
            // 
            this.lblTypeBuy.AutoSize = true;
            this.lblTypeBuy.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeBuy.Location = new System.Drawing.Point(224, 14);
            this.lblTypeBuy.Name = "lblTypeBuy";
            this.lblTypeBuy.Size = new System.Drawing.Size(75, 37);
            this.lblTypeBuy.TabIndex = 0;
            this.lblTypeBuy.Text = "نوع خرید :";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblNameCustomer.Location = new System.Drawing.Point(136, 62);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(58, 37);
            this.lblNameCustomer.TabIndex = 0;
            this.lblNameCustomer.Text = "خریدار :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(337, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "خریدار :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(328, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "نوع خرید :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(317, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "مبلغ نهایی :";
            // 
            // frmSetCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.ControlBox = false;
            this.Controls.Add(this.gp);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.btnFinallyBuy);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Aviny", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت اطلاعات مشتری";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.gp.ResumeLayout(false);
            this.gp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnNewUser;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbUser;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnFinallyBuy;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.GroupPanel gp;
        private System.Windows.Forms.Label lblTypeBuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton cbInstallment;
        private System.Windows.Forms.RadioButton cbCash;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.Label label3;
    }
}