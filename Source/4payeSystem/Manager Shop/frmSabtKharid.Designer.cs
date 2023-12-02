namespace _4payeSystem.Manager_Shop
{
    partial class frmSabtKharid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKala = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.numTedad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMines = new DevComponents.DotNetBar.ButtonX();
            this.btnPlus = new DevComponents.DotNetBar.ButtonX();
            this.btnCleayer = new DevComponents.DotNetBar.ButtonX();
            this.btnRemove = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.dgvBuy = new System.Windows.Forms.DataGridView();
            this.KalaNameBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mojudi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKala)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKala
            // 
            this.dgvKala.AllowUserToAddRows = false;
            this.dgvKala.AllowUserToDeleteRows = false;
            this.dgvKala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KalaName,
            this.Price,
            this.Mojudi});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Aviny", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKala.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKala.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvKala.Location = new System.Drawing.Point(2, 29);
            this.dgvKala.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dgvKala.Name = "dgvKala";
            this.dgvKala.ReadOnly = true;
            this.dgvKala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKala.Size = new System.Drawing.Size(369, 387);
            this.dgvKala.TabIndex = 0;
            this.dgvKala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKala_CellClick);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnClose);
            this.groupPanel1.Controls.Add(this.lblPrice);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.txtSearch);
            this.groupPanel1.Controls.Add(this.dgvKala);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Aviny", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(394, 14);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(379, 585);
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
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "کالاهای موجود";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(258, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 43);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Aviny", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPrice.Location = new System.Drawing.Point(59, 492);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(25, 37);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Aviny", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(151, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "مبلغ نهایی :";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Location = new System.Drawing.Point(27, 431);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(333, 35);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSearch.WatermarkText = "جست و جوی کالا موذد نظر";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.numTedad);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.btnMines);
            this.groupPanel2.Controls.Add(this.btnPlus);
            this.groupPanel2.Controls.Add(this.btnCleayer);
            this.groupPanel2.Controls.Add(this.btnRemove);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.Controls.Add(this.dgvBuy);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Aviny", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel2.Location = new System.Drawing.Point(8, 14);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(377, 585);
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
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "لیست سفارش";
            this.groupPanel2.Click += new System.EventHandler(this.groupPanel2_Click);
            // 
            // numTedad
            // 
            this.numTedad.Location = new System.Drawing.Point(55, 442);
            this.numTedad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTedad.Name = "numTedad";
            this.numTedad.Size = new System.Drawing.Size(30, 35);
            this.numTedad.TabIndex = 4;
            this.numTedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTedad.ValueChanged += new System.EventHandler(this.numTedad_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aviny", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(132, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "تعداد خرید :";
            // 
            // btnMines
            // 
            this.btnMines.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMines.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMines.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.btnMines.Image = global::_4payeSystem.Properties.Resources._1075;
            this.btnMines.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnMines.Location = new System.Drawing.Point(3, 441);
            this.btnMines.Name = "btnMines";
            this.btnMines.Size = new System.Drawing.Size(46, 39);
            this.btnMines.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMines.TabIndex = 2;
            this.btnMines.Click += new System.EventHandler(this.btnMines_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPlus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.btnPlus.Image = global::_4payeSystem.Properties.Resources.Actions_list_add_icon;
            this.btnPlus.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnPlus.Location = new System.Drawing.Point(91, 440);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(41, 39);
            this.btnPlus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnCleayer
            // 
            this.btnCleayer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCleayer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCleayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleayer.Image = global::_4payeSystem.Properties.Resources._2Recycle_Bin_Empty;
            this.btnCleayer.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnCleayer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnCleayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCleayer.Location = new System.Drawing.Point(3, 502);
            this.btnCleayer.Name = "btnCleayer";
            this.btnCleayer.Size = new System.Drawing.Size(127, 44);
            this.btnCleayer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCleayer.TabIndex = 1;
            this.btnCleayer.Text = "خالی کردن سبد";
            this.btnCleayer.Click += new System.EventHandler(this.btnCleayer_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Image = global::_4payeSystem.Properties.Resources.Recycle_Bin_Full_icon;
            this.btnRemove.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnRemove.Location = new System.Drawing.Point(136, 502);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 44);
            this.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "حذف کالا";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::_4payeSystem.Properties.Resources.shop_cart_apply_icon;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(248, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 44);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "نهایی کردن خرید";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBuy
            // 
            this.dgvBuy.AllowUserToAddRows = false;
            this.dgvBuy.AllowUserToDeleteRows = false;
            this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KalaNameBuy,
            this.PriceBuy,
            this.Num});
            this.dgvBuy.Location = new System.Drawing.Point(3, 24);
            this.dgvBuy.Name = "dgvBuy";
            this.dgvBuy.ReadOnly = true;
            this.dgvBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuy.Size = new System.Drawing.Size(365, 387);
            this.dgvBuy.TabIndex = 0;
            this.dgvBuy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuy_CellClick);
            // 
            // KalaNameBuy
            // 
            this.KalaNameBuy.HeaderText = "نام کالا";
            this.KalaNameBuy.Name = "KalaNameBuy";
            this.KalaNameBuy.ReadOnly = true;
            // 
            // PriceBuy
            // 
            this.PriceBuy.HeaderText = "قیمت";
            this.PriceBuy.Name = "PriceBuy";
            this.PriceBuy.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.HeaderText = "تعداد خرید";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // KalaName
            // 
            this.KalaName.DataPropertyName = "Name_kala";
            this.KalaName.HeaderText = "محصول";
            this.KalaName.Name = "KalaName";
            this.KalaName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PriceSell";
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Mojudi
            // 
            this.Mojudi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mojudi.DataPropertyName = "Number";
            this.Mojudi.HeaderText = "موجود در انبار";
            this.Mojudi.Name = "Mojudi";
            this.Mojudi.ReadOnly = true;
            // 
            // frmSabtKharid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Aviny", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSabtKharid";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت خرید";
            this.Load += new System.EventHandler(this.frmSabtKharid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKala)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKala;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnCleayer;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.DataGridView dgvBuy;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.ButtonX btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalaNameBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.NumericUpDown numTedad;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnMines;
        private DevComponents.DotNetBar.ButtonX btnPlus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mojudi;
    }
}