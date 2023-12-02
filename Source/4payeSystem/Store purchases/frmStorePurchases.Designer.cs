namespace _4payeSystem.Store_purchases
{
    partial class frmStorePurchases
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.numPriceSell = new System.Windows.Forms.NumericUpDown();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.numPriceBuy = new System.Windows.Forms.NumericUpDown();
            this.btnClearAll = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameKala = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.rbInstallment = new System.Windows.Forms.RadioButton();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.numPriceSell);
            this.groupPanel1.Controls.Add(this.numNumber);
            this.groupPanel1.Controls.Add(this.numPriceBuy);
            this.groupPanel1.Controls.Add(this.btnClearAll);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.txtSerialNumber);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.txtMark);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.txtNameKala);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(610, 341);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "اطلاعات محصول";
            // 
            // numPriceSell
            // 
            this.numPriceSell.Location = new System.Drawing.Point(163, 195);
            this.numPriceSell.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPriceSell.Name = "numPriceSell";
            this.numPriceSell.Size = new System.Drawing.Size(300, 41);
            this.numPriceSell.TabIndex = 4;
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(163, 54);
            this.numNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(300, 41);
            this.numNumber.TabIndex = 1;
            this.numNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPriceBuy
            // 
            this.numPriceBuy.Location = new System.Drawing.Point(163, 148);
            this.numPriceBuy.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPriceBuy.Name = "numPriceBuy";
            this.numPriceBuy.Size = new System.Drawing.Size(300, 41);
            this.numPriceBuy.TabIndex = 3;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.HoverImage = global::_4payeSystem.Properties.Resources.Refresh_icon;
            this.btnClearAll.Image = global::_4payeSystem.Properties.Resources._2Recycle_Bin_Empty;
            this.btnClearAll.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClearAll.Location = new System.Drawing.Point(3, 247);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(114, 49);
            this.btnClearAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "پاک کردن";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(496, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "قیمت فروش :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(499, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "قیمت خرید :";
            // 
            // txtSerialNumber
            // 
            // 
            // 
            // 
            this.txtSerialNumber.Border.Class = "TextBoxBorder";
            this.txtSerialNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSerialNumber.Location = new System.Drawing.Point(163, 242);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.PreventEnterBeep = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(300, 41);
            this.txtSerialNumber.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(496, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "شماره سریال :";
            // 
            // txtMark
            // 
            // 
            // 
            // 
            this.txtMark.Border.Class = "TextBoxBorder";
            this.txtMark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMark.Location = new System.Drawing.Point(163, 99);
            this.txtMark.Name = "txtMark";
            this.txtMark.PreventEnterBeep = true;
            this.txtMark.Size = new System.Drawing.Size(300, 41);
            this.txtMark.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(520, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "برند :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(518, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "تعداد";
            // 
            // txtNameKala
            // 
            // 
            // 
            // 
            this.txtNameKala.Border.Class = "TextBoxBorder";
            this.txtNameKala.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameKala.Location = new System.Drawing.Point(163, 5);
            this.txtNameKala.Name = "txtNameKala";
            this.txtNameKala.PreventEnterBeep = true;
            this.txtNameKala.Size = new System.Drawing.Size(300, 41);
            this.txtNameKala.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(496, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام محصول :";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.HoverImage = global::_4payeSystem.Properties.Resources._1147;
            this.btnClose.Image = global::_4payeSystem.Properties.Resources._1147;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(12, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 49);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "بازگشت";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.HoverImage = global::_4payeSystem.Properties.Resources._0269;
            this.btnSave.Image = global::_4payeSystem.Properties.Resources.shopping_bag_icon;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(138, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 49);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ثبت";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbInstallment
            // 
            this.rbInstallment.AutoSize = true;
            this.rbInstallment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbInstallment.Location = new System.Drawing.Point(264, 367);
            this.rbInstallment.Name = "rbInstallment";
            this.rbInstallment.Size = new System.Drawing.Size(117, 37);
            this.rbInstallment.TabIndex = 6;
            this.rbInstallment.TabStop = true;
            this.rbInstallment.Text = "پرداخت درآینده";
            this.rbInstallment.UseVisualStyleBackColor = true;
            // 
            // frmStorePurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 416);
            this.Controls.Add(this.rbInstallment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStorePurchases";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت اجناس خریداری شده";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnClearAll;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMark;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNameKala;
        public System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.ButtonX btnSave;
        public System.Windows.Forms.NumericUpDown numPriceSell;
        public System.Windows.Forms.NumericUpDown numNumber;
        public System.Windows.Forms.NumericUpDown numPriceBuy;
        public DevComponents.DotNetBar.Controls.TextBoxX txtSerialNumber;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbInstallment;
    }
}