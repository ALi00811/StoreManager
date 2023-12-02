namespace _4payeSystem
{
    partial class frmCheckInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvCheckInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.Check_number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Check1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_number2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Check2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_number3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Check3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_number4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Check4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_number5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Check5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check_number6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Check6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvCheckInfo);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(559, 301);
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
            this.groupPanel1.Text = "اطلاعات چک ها";
            // 
            // dgvCheckInfo
            // 
            this.dgvCheckInfo.AllowUserToAddRows = false;
            this.dgvCheckInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check_number1,
            this.Date_Check1,
            this.Check_number2,
            this.Date_Check2,
            this.Check_number3,
            this.Date_Check3,
            this.Check_number4,
            this.Date_Check4,
            this.Check_number5,
            this.Date_Check5,
            this.Check_number6,
            this.Date_Check6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckInfo.EnableHeadersVisualStyles = false;
            this.dgvCheckInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvCheckInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvCheckInfo.Name = "dgvCheckInfo";
            this.dgvCheckInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheckInfo.Size = new System.Drawing.Size(553, 259);
            this.dgvCheckInfo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.HoverImage = global::_4payeSystem.Properties.Resources.Alarm_Error_icon;
            this.btnClose.Image = global::_4payeSystem.Properties.Resources._1147;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(423, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 38);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "بازگشت";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Check_number1
            // 
            this.Check_number1.DataPropertyName = "Check_number1";
            this.Check_number1.HeaderText = "چک اول";
            this.Check_number1.Name = "Check_number1";
            this.Check_number1.ReadOnly = true;
            // 
            // Date_Check1
            // 
            this.Date_Check1.DataPropertyName = "Date_Check1";
            this.Date_Check1.HeaderText = "تاریخ چک اول";
            this.Date_Check1.Name = "Date_Check1";
            this.Date_Check1.ReadOnly = true;
            // 
            // Check_number2
            // 
            this.Check_number2.DataPropertyName = "Check_number2";
            this.Check_number2.HeaderText = "چک دوم";
            this.Check_number2.Name = "Check_number2";
            this.Check_number2.ReadOnly = true;
            // 
            // Date_Check2
            // 
            this.Date_Check2.DataPropertyName = "Date_Check2";
            this.Date_Check2.HeaderText = "تاریخ چک دوم";
            this.Date_Check2.Name = "Date_Check2";
            this.Date_Check2.ReadOnly = true;
            // 
            // Check_number3
            // 
            this.Check_number3.DataPropertyName = "Check_number3";
            this.Check_number3.HeaderText = "چک سوم";
            this.Check_number3.Name = "Check_number3";
            this.Check_number3.ReadOnly = true;
            // 
            // Date_Check3
            // 
            this.Date_Check3.DataPropertyName = "Date_Check3";
            this.Date_Check3.HeaderText = "تاریخ چک سوم";
            this.Date_Check3.Name = "Date_Check3";
            this.Date_Check3.ReadOnly = true;
            // 
            // Check_number4
            // 
            this.Check_number4.DataPropertyName = "Check_number4";
            this.Check_number4.HeaderText = "چک چهارم";
            this.Check_number4.Name = "Check_number4";
            this.Check_number4.ReadOnly = true;
            // 
            // Date_Check4
            // 
            this.Date_Check4.DataPropertyName = "Date_Check4";
            this.Date_Check4.HeaderText = "تاریخ چک چهارم";
            this.Date_Check4.Name = "Date_Check4";
            this.Date_Check4.ReadOnly = true;
            // 
            // Check_number5
            // 
            this.Check_number5.DataPropertyName = "Check_number5";
            this.Check_number5.HeaderText = "چک پنجم";
            this.Check_number5.Name = "Check_number5";
            this.Check_number5.ReadOnly = true;
            // 
            // Date_Check5
            // 
            this.Date_Check5.DataPropertyName = "Date_Check5";
            this.Date_Check5.HeaderText = "تاریخ چک پنجم";
            this.Date_Check5.Name = "Date_Check5";
            this.Date_Check5.ReadOnly = true;
            // 
            // Check_number6
            // 
            this.Check_number6.DataPropertyName = "Check_number6";
            this.Check_number6.HeaderText = "چک ششم";
            this.Check_number6.Name = "Check_number6";
            this.Check_number6.ReadOnly = true;
            // 
            // Date_Check6
            // 
            this.Date_Check6.DataPropertyName = "Date_Check6";
            this.Date_Check6.HeaderText = "تاریخ چک ششم";
            this.Date_Check6.Name = "Date_Check6";
            this.Date_Check6.ReadOnly = true;
            // 
            // frmCheckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "frmCheckInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCheckInfo";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCheckInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check_number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Check1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check_number2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Check2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check_number3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Check3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check_number4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Check4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check_number5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Check5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check_number6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Check6;
    }
}