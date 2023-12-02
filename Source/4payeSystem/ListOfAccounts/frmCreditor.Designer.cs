namespace _4payeSystem.ListOfAccounts
{
    partial class frmCreditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpInfo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCheckInfo = new DevComponents.DotNetBar.ButtonX();
            this.btnClearing = new DevComponents.DotNetBar.ButtonX();
            this.dgvUserInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Record = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInfo = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvUserCreditor = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Name_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserCreditor)).BeginInit();
            this.SuspendLayout();
            // 
            // gpInfo
            // 
            this.gpInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpInfo.Controls.Add(this.btnCheckInfo);
            this.gpInfo.Controls.Add(this.btnClearing);
            this.gpInfo.Controls.Add(this.dgvUserInfo);
            this.gpInfo.Controls.Add(this.txtInfo);
            this.gpInfo.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpInfo.Location = new System.Drawing.Point(8, 12);
            this.gpInfo.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Size = new System.Drawing.Size(477, 437);
            // 
            // 
            // 
            this.gpInfo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpInfo.Style.BackColorGradientAngle = 90;
            this.gpInfo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpInfo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpInfo.Style.BorderBottomWidth = 1;
            this.gpInfo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpInfo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpInfo.Style.BorderLeftWidth = 1;
            this.gpInfo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpInfo.Style.BorderRightWidth = 1;
            this.gpInfo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpInfo.Style.BorderTopWidth = 1;
            this.gpInfo.Style.CornerDiameter = 4;
            this.gpInfo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpInfo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpInfo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpInfo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpInfo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpInfo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpInfo.TabIndex = 3;
            this.gpInfo.Text = "اطلاعات";
            // 
            // btnCheckInfo
            // 
            this.btnCheckInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckInfo.HoverImage = global::_4payeSystem.Properties.Resources.document_scroll_icon;
            this.btnCheckInfo.Image = global::_4payeSystem.Properties.Resources.Calendar_icon;
            this.btnCheckInfo.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCheckInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnCheckInfo.Location = new System.Drawing.Point(135, 349);
            this.btnCheckInfo.Name = "btnCheckInfo";
            this.btnCheckInfo.Size = new System.Drawing.Size(140, 39);
            this.btnCheckInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckInfo.TabIndex = 2;
            this.btnCheckInfo.Text = "جزئیات چک ها";
            this.btnCheckInfo.Visible = false;
            this.btnCheckInfo.Click += new System.EventHandler(this.btnCheckInfo_Click);
            // 
            // btnClearing
            // 
            this.btnClearing.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearing.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearing.HoverImage = global::_4payeSystem.Properties.Resources.money_wallet_icon;
            this.btnClearing.Image = global::_4payeSystem.Properties.Resources.payment_icon;
            this.btnClearing.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClearing.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnClearing.Location = new System.Drawing.Point(16, 349);
            this.btnClearing.Name = "btnClearing";
            this.btnClearing.Size = new System.Drawing.Size(113, 39);
            this.btnClearing.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearing.TabIndex = 2;
            this.btnClearing.Text = "تسویه";
            this.btnClearing.Visible = false;
            this.btnClearing.Click += new System.EventHandler(this.btnClearing_Click);
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.DateTime_Buy,
            this.Installments,
            this.Prepayment,
            this.Record});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserInfo.EnableHeadersVisualStyles = false;
            this.dgvUserInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvUserInfo.Location = new System.Drawing.Point(12, 8);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.Size = new System.Drawing.Size(447, 335);
            this.dgvUserInfo.TabIndex = 1;
            this.dgvUserInfo.Visible = false;
            this.dgvUserInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserInfo_CellClick);
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نام";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "بدهی باقی مانده";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // DateTime_Buy
            // 
            this.DateTime_Buy.DataPropertyName = "DateTime_Buy";
            this.DateTime_Buy.HeaderText = "تاریخ خرید";
            this.DateTime_Buy.Name = "DateTime_Buy";
            this.DateTime_Buy.ReadOnly = true;
            // 
            // Installments
            // 
            this.Installments.DataPropertyName = "Installments";
            this.Installments.HeaderText = "تعداد ماه اقساط";
            this.Installments.Name = "Installments";
            this.Installments.ReadOnly = true;
            // 
            // Prepayment
            // 
            this.Prepayment.DataPropertyName = "Prepayment";
            this.Prepayment.HeaderText = "پیش پرداخت";
            this.Prepayment.Name = "Prepayment";
            this.Prepayment.ReadOnly = true;
            // 
            // Record
            // 
            this.Record.DataPropertyName = "Record";
            this.Record.HeaderText = "رکورد";
            this.Record.Name = "Record";
            this.Record.ReadOnly = true;
            this.Record.Visible = false;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.BackColor = System.Drawing.Color.Transparent;
            this.txtInfo.ForeColor = System.Drawing.Color.Black;
            this.txtInfo.Location = new System.Drawing.Point(50, 161);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(366, 33);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "برای نمایش اطلاعات یک شخص را از لیست خریداران انتخاب کنید";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvUserCreditor);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(491, 13);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(236, 436);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "لیست خریداران";
            // 
            // dgvUserCreditor
            // 
            this.dgvUserCreditor.AllowUserToAddRows = false;
            this.dgvUserCreditor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserCreditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserCreditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserCreditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Customer});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserCreditor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserCreditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserCreditor.EnableHeadersVisualStyles = false;
            this.dgvUserCreditor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvUserCreditor.Location = new System.Drawing.Point(0, 0);
            this.dgvUserCreditor.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.dgvUserCreditor.Name = "dgvUserCreditor";
            this.dgvUserCreditor.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserCreditor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserCreditor.Size = new System.Drawing.Size(230, 394);
            this.dgvUserCreditor.TabIndex = 0;
            this.dgvUserCreditor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserCreditor_CellClick);
            // 
            // Name_Customer
            // 
            this.Name_Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_Customer.DataPropertyName = "Name_Customer";
            this.Name_Customer.HeaderText = "شخص";
            this.Name_Customer.Name = "Name_Customer";
            this.Name_Customer.ReadOnly = true;
            // 
            // frmCreditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست بستانکاری";
            this.Load += new System.EventHandler(this.frmCreditor_Load);
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserCreditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpInfo;
        private System.Windows.Forms.Label txtInfo;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUserCreditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Customer;
        private DevComponents.DotNetBar.ButtonX btnClearing;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUserInfo;
        private DevComponents.DotNetBar.ButtonX btnCheckInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Record;
    }
}