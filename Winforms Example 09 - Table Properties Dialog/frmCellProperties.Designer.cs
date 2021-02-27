namespace Winforms_Example_09___Table_Properties_Dialog_CS
{
    partial class frmCellProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCellProperties));
            this.grpCellProperties = new System.Windows.Forms.GroupBox();
            this.cboCellBorderStyle = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cboCellBorderWidth = new System.Windows.Forms.ComboBox();
            this.btnCellBackgroundColor = new System.Windows.Forms.Button();
            this.btnCellBorderColor = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCellBackgroundColor = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtCellBorderColor = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpCellProperties.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCellProperties
            // 
            this.grpCellProperties.Controls.Add(this.cboCellBorderStyle);
            this.grpCellProperties.Controls.Add(this.Label7);
            this.grpCellProperties.Controls.Add(this.cboCellBorderWidth);
            this.grpCellProperties.Controls.Add(this.btnCellBackgroundColor);
            this.grpCellProperties.Controls.Add(this.btnCellBorderColor);
            this.grpCellProperties.Controls.Add(this.Label8);
            this.grpCellProperties.Controls.Add(this.txtCellBackgroundColor);
            this.grpCellProperties.Controls.Add(this.Label9);
            this.grpCellProperties.Controls.Add(this.Label10);
            this.grpCellProperties.Controls.Add(this.txtCellBorderColor);
            this.grpCellProperties.Location = new System.Drawing.Point(7, 12);
            this.grpCellProperties.Name = "grpCellProperties";
            this.grpCellProperties.Size = new System.Drawing.Size(303, 131);
            this.grpCellProperties.TabIndex = 7;
            this.grpCellProperties.TabStop = false;
            this.grpCellProperties.Text = "Cell Properties";
            // 
            // cboCellBorderStyle
            // 
            this.cboCellBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCellBorderStyle.FormattingEnabled = true;
            this.cboCellBorderStyle.Items.AddRange(new object[] {
            "solid",
            "dashed",
            "dotted",
            "double",
            "none"});
            this.cboCellBorderStyle.Location = new System.Drawing.Point(135, 72);
            this.cboCellBorderStyle.Name = "cboCellBorderStyle";
            this.cboCellBorderStyle.Size = new System.Drawing.Size(99, 21);
            this.cboCellBorderStyle.TabIndex = 15;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(45, 76);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(64, 13);
            this.Label7.TabIndex = 14;
            this.Label7.Text = "Border Style";
            // 
            // cboCellBorderWidth
            // 
            this.cboCellBorderWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCellBorderWidth.FormattingEnabled = true;
            this.cboCellBorderWidth.Items.AddRange(new object[] {
            "none",
            "1px",
            "2px",
            "3px",
            "4px",
            "5px",
            "6px",
            "7px",
            "8px",
            "9px"});
            this.cboCellBorderWidth.Location = new System.Drawing.Point(135, 45);
            this.cboCellBorderWidth.Name = "cboCellBorderWidth";
            this.cboCellBorderWidth.Size = new System.Drawing.Size(99, 21);
            this.cboCellBorderWidth.TabIndex = 13;
            // 
            // btnCellBackgroundColor
            // 
            this.btnCellBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("btnCellBackgroundColor.Image")));
            this.btnCellBackgroundColor.Location = new System.Drawing.Point(243, 94);
            this.btnCellBackgroundColor.Name = "btnCellBackgroundColor";
            this.btnCellBackgroundColor.Size = new System.Drawing.Size(55, 29);
            this.btnCellBackgroundColor.TabIndex = 12;
            this.btnCellBackgroundColor.UseVisualStyleBackColor = true;
            this.btnCellBackgroundColor.Click += new System.EventHandler(this.btnCellBackgroundColor_Click);
            // 
            // btnCellBorderColor
            // 
            this.btnCellBorderColor.Image = ((System.Drawing.Image)(resources.GetObject("btnCellBorderColor.Image")));
            this.btnCellBorderColor.Location = new System.Drawing.Point(243, 13);
            this.btnCellBorderColor.Name = "btnCellBorderColor";
            this.btnCellBorderColor.Size = new System.Drawing.Size(55, 30);
            this.btnCellBorderColor.TabIndex = 11;
            this.btnCellBorderColor.UseVisualStyleBackColor = true;
            this.btnCellBorderColor.Click += new System.EventHandler(this.btnCellBorderColor_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(22, 102);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(92, 13);
            this.Label8.TabIndex = 10;
            this.Label8.Text = "Background Color";
            // 
            // txtCellBackgroundColor
            // 
            this.txtCellBackgroundColor.Location = new System.Drawing.Point(135, 99);
            this.txtCellBackgroundColor.Name = "txtCellBackgroundColor";
            this.txtCellBackgroundColor.Size = new System.Drawing.Size(100, 20);
            this.txtCellBackgroundColor.TabIndex = 8;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(45, 49);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(69, 13);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Border Width";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(49, 22);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(65, 13);
            this.Label10.TabIndex = 6;
            this.Label10.Text = "Border Color";
            // 
            // txtCellBorderColor
            // 
            this.txtCellBorderColor.Location = new System.Drawing.Point(135, 19);
            this.txtCellBorderColor.Name = "txtCellBorderColor";
            this.txtCellBorderColor.Size = new System.Drawing.Size(100, 20);
            this.txtCellBorderColor.TabIndex = 4;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnCancel);
            this.GroupBox3.Controls.Add(this.btnOK);
            this.GroupBox3.Location = new System.Drawing.Point(8, 149);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(303, 52);
            this.GroupBox3.TabIndex = 6;
            this.GroupBox3.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(134, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmCellProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 208);
            this.Controls.Add(this.grpCellProperties);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCellProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cell Properties";
            this.grpCellProperties.ResumeLayout(false);
            this.grpCellProperties.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpCellProperties;
        internal System.Windows.Forms.ComboBox cboCellBorderStyle;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cboCellBorderWidth;
        internal System.Windows.Forms.Button btnCellBackgroundColor;
        internal System.Windows.Forms.Button btnCellBorderColor;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCellBackgroundColor;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtCellBorderColor;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
    }
}