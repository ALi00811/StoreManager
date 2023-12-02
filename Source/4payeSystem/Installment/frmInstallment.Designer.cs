namespace _4payeSystem
{
    partial class frmInstallment
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
            this.gpInstallment = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbOneMonth = new System.Windows.Forms.RadioButton();
            this.cbLongTime = new System.Windows.Forms.RadioButton();
            this.lblCheck = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtDueDate = new Atf.UI.DateTimeSelector();
            this.txtCheckNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnWriteCheck = new DevComponents.DotNetBar.ButtonX();
            this.txtPrepayment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gpTypeInstallment = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancell = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gpInstallment.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.gpTypeInstallment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpInstallment
            // 
            this.gpInstallment.BackColor = System.Drawing.Color.Transparent;
            this.gpInstallment.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpInstallment.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpInstallment.Controls.Add(this.cbOneMonth);
            this.gpInstallment.Controls.Add(this.cbLongTime);
            this.gpInstallment.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpInstallment.Location = new System.Drawing.Point(305, 12);
            this.gpInstallment.Name = "gpInstallment";
            this.gpInstallment.Size = new System.Drawing.Size(167, 97);
            // 
            // 
            // 
            this.gpInstallment.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpInstallment.Style.BackColorGradientAngle = 90;
            this.gpInstallment.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpInstallment.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpInstallment.Style.BorderBottomWidth = 1;
            this.gpInstallment.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpInstallment.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpInstallment.Style.BorderLeftWidth = 1;
            this.gpInstallment.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpInstallment.Style.BorderRightWidth = 1;
            this.gpInstallment.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpInstallment.Style.BorderTopWidth = 1;
            this.gpInstallment.Style.CornerDiameter = 4;
            this.gpInstallment.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpInstallment.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpInstallment.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpInstallment.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpInstallment.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpInstallment.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpInstallment.TabIndex = 10;
            this.gpInstallment.Text = "شرایط";
            // 
            // cbOneMonth
            // 
            this.cbOneMonth.AutoSize = true;
            this.cbOneMonth.Checked = true;
            this.cbOneMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOneMonth.Font = new System.Drawing.Font("Aviny", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbOneMonth.Location = new System.Drawing.Point(89, 9);
            this.cbOneMonth.Name = "cbOneMonth";
            this.cbOneMonth.Size = new System.Drawing.Size(63, 31);
            this.cbOneMonth.TabIndex = 1;
            this.cbOneMonth.TabStop = true;
            this.cbOneMonth.Text = "یک ماه";
            this.cbOneMonth.UseVisualStyleBackColor = true;
            this.cbOneMonth.CheckedChanged += new System.EventHandler(this.cbOneMonth_CheckedChanged);
            // 
            // cbLongTime
            // 
            this.cbLongTime.AutoSize = true;
            this.cbLongTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLongTime.Font = new System.Drawing.Font("Aviny", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbLongTime.Location = new System.Drawing.Point(11, 9);
            this.cbLongTime.Name = "cbLongTime";
            this.cbLongTime.Size = new System.Drawing.Size(75, 31);
            this.cbLongTime.TabIndex = 0;
            this.cbLongTime.Text = "بلند مدت";
            this.cbLongTime.UseVisualStyleBackColor = true;
            this.cbLongTime.CheckedChanged += new System.EventHandler(this.cbLongTime_CheckedChanged);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblCheck.Location = new System.Drawing.Point(192, 7);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(82, 33);
            this.lblCheck.TabIndex = 11;
            this.lblCheck.Text = "شماره چک :";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dtDueDate);
            this.groupPanel1.Controls.Add(this.txtCheckNumber);
            this.groupPanel1.Controls.Add(this.btnWriteCheck);
            this.groupPanel1.Controls.Add(this.txtPrepayment);
            this.groupPanel1.Controls.Add(this.gpTypeInstallment);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.lblCheck);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(277, 337);
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
            this.groupPanel1.TabIndex = 13;
            this.groupPanel1.Text = "اطلاعات";
            // 
            // dtDueDate
            // 
            this.dtDueDate.Location = new System.Drawing.Point(3, 41);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(177, 42);
            this.dtDueDate.TabIndex = 19;
            this.dtDueDate.UsePersianFormat = true;
            // 
            // txtCheckNumber
            // 
            // 
            // 
            // 
            this.txtCheckNumber.Border.Class = "TextBoxBorder";
            this.txtCheckNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCheckNumber.Location = new System.Drawing.Point(3, 0);
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.PreventEnterBeep = true;
            this.txtCheckNumber.Size = new System.Drawing.Size(177, 41);
            this.txtCheckNumber.TabIndex = 0;
            this.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCheckNumber.WatermarkText = "شماره چک";
            // 
            // btnWriteCheck
            // 
            this.btnWriteCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWriteCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWriteCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteCheck.HoverImage = global::_4payeSystem.Properties.Resources.Filter_List_icon;
            this.btnWriteCheck.Image = global::_4payeSystem.Properties.Resources.checklist_icon;
            this.btnWriteCheck.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnWriteCheck.Location = new System.Drawing.Point(35, 232);
            this.btnWriteCheck.Name = "btnWriteCheck";
            this.btnWriteCheck.Size = new System.Drawing.Size(191, 60);
            this.btnWriteCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnWriteCheck.TabIndex = 18;
            this.btnWriteCheck.Text = "ثبت مشخاص چک ها";
            this.btnWriteCheck.Visible = false;
            this.btnWriteCheck.Click += new System.EventHandler(this.btnWriteCheck_Click);
            // 
            // txtPrepayment
            // 
            this.txtPrepayment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtPrepayment.Border.Class = "TextBoxBorder";
            this.txtPrepayment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrepayment.Location = new System.Drawing.Point(3, 87);
            this.txtPrepayment.Name = "txtPrepayment";
            this.txtPrepayment.PreventEnterBeep = true;
            this.txtPrepayment.Size = new System.Drawing.Size(177, 41);
            this.txtPrepayment.TabIndex = 1;
            this.txtPrepayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrepayment.WatermarkText = "مبلغ پیش پرداخت";
            // 
            // gpTypeInstallment
            // 
            this.gpTypeInstallment.BackColor = System.Drawing.Color.Transparent;
            this.gpTypeInstallment.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpTypeInstallment.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpTypeInstallment.Controls.Add(this.label3);
            this.gpTypeInstallment.Controls.Add(this.label2);
            this.gpTypeInstallment.Controls.Add(this.label1);
            this.gpTypeInstallment.Controls.Add(this.rb12);
            this.gpTypeInstallment.Controls.Add(this.rb3);
            this.gpTypeInstallment.Controls.Add(this.rb6);
            this.gpTypeInstallment.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpTypeInstallment.Location = new System.Drawing.Point(6, 130);
            this.gpTypeInstallment.Name = "gpTypeInstallment";
            this.gpTypeInstallment.Size = new System.Drawing.Size(262, 100);
            // 
            // 
            // 
            this.gpTypeInstallment.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpTypeInstallment.Style.BackColorGradientAngle = 90;
            this.gpTypeInstallment.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpTypeInstallment.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpTypeInstallment.Style.BorderBottomWidth = 1;
            this.gpTypeInstallment.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpTypeInstallment.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpTypeInstallment.Style.BorderLeftWidth = 1;
            this.gpTypeInstallment.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpTypeInstallment.Style.BorderRightWidth = 1;
            this.gpTypeInstallment.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpTypeInstallment.Style.BorderTopWidth = 1;
            this.gpTypeInstallment.Style.CornerDiameter = 4;
            this.gpTypeInstallment.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpTypeInstallment.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpTypeInstallment.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpTypeInstallment.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpTypeInstallment.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpTypeInstallment.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpTypeInstallment.TabIndex = 15;
            this.gpTypeInstallment.Text = "تعداد قساط";
            this.gpTypeInstallment.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "10%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(193, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "6%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "25%";
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.BackColor = System.Drawing.Color.Transparent;
            this.rb12.Location = new System.Drawing.Point(3, -6);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(73, 37);
            this.rb12.TabIndex = 14;
            this.rb12.Text = "12 ماهه";
            this.rb12.UseVisualStyleBackColor = false;
            this.rb12.CheckedChanged += new System.EventHandler(this.rb12_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Transparent;
            this.rb3.Checked = true;
            this.rb3.Location = new System.Drawing.Point(174, -6);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(71, 37);
            this.rb3.TabIndex = 14;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 ماهه";
            this.rb3.UseVisualStyleBackColor = false;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.BackColor = System.Drawing.Color.Transparent;
            this.rb6.Location = new System.Drawing.Point(91, -6);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(71, 37);
            this.rb6.TabIndex = 14;
            this.rb6.Text = "6 ماهه";
            this.rb6.UseVisualStyleBackColor = false;
            this.rb6.CheckedChanged += new System.EventHandler(this.rb6_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(184, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "پیش پرداخت:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(192, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "تاریخ سر رسید :";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.HoverImage = global::_4payeSystem.Properties.Resources.checklist_icon;
            this.btnSave.Image = global::_4payeSystem.Properties.Resources._0269;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(319, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 47);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancell.BackColor = System.Drawing.Color.Brown;
            this.btnCancell.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancell.HoverImage = global::_4payeSystem.Properties.Resources.Alarm_Error_icon;
            this.btnCancell.Image = global::_4payeSystem.Properties.Resources._0036;
            this.btnCancell.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancell.Location = new System.Drawing.Point(319, 302);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(131, 47);
            this.btnCancell.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancell.TabIndex = 14;
            this.btnCancell.Text = "کنسل";
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4payeSystem.Properties.Resources.document_scroll_icon;
            this.pictureBox1.Location = new System.Drawing.Point(319, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.gpInstallment);
            this.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "frmInstallment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خرید اقساطی";
            this.gpInstallment.ResumeLayout(false);
            this.gpInstallment.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.gpTypeInstallment.ResumeLayout(false);
            this.gpTypeInstallment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpInstallment;
        private System.Windows.Forms.RadioButton cbOneMonth;
        private System.Windows.Forms.RadioButton cbLongTime;
        private System.Windows.Forms.Label lblCheck;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancell;
        private DevComponents.DotNetBar.Controls.GroupPanel gpTypeInstallment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrepayment;
        private DevComponents.DotNetBar.ButtonX btnWriteCheck;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCheckNumber;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Atf.UI.DateTimeSelector dtDueDate;
        private System.Windows.Forms.Label label5;
    }
}