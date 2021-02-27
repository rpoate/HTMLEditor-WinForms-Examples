namespace Winforms_Example_09___Table_Properties_Dialog_CS
{
    partial class frmTableProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableProperties));
            this.cboCellBorderStyle = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cboCellBorderWidth = new System.Windows.Forms.ComboBox();
            this.btnCellBackgroundColor = new System.Windows.Forms.Button();
            this.cboBorderStyle = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.cboBorderWidth = new System.Windows.Forms.ComboBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCellBackgroundColor = new System.Windows.Forms.TextBox();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtBackgroundColor = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCellBorderColor = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.chkApplyCellProperties = new System.Windows.Forms.CheckBox();
            this.txtBorderColor = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCellBorderColor = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.grpCellProperties = new System.Windows.Forms.GroupBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.grpCellProperties.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // cboBorderStyle
            // 
            this.cboBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBorderStyle.FormattingEnabled = true;
            this.cboBorderStyle.Items.AddRange(new object[] {
            "solid",
            "dashed",
            "dotted",
            "double",
            "none"});
            this.cboBorderStyle.Location = new System.Drawing.Point(134, 72);
            this.cboBorderStyle.Name = "cboBorderStyle";
            this.cboBorderStyle.Size = new System.Drawing.Size(99, 21);
            this.cboBorderStyle.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(44, 76);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 13);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Border Style";
            // 
            // cboBorderWidth
            // 
            this.cboBorderWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBorderWidth.FormattingEnabled = true;
            this.cboBorderWidth.Items.AddRange(new object[] {
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
            this.cboBorderWidth.Location = new System.Drawing.Point(134, 45);
            this.cboBorderWidth.Name = "cboBorderWidth";
            this.cboBorderWidth.Size = new System.Drawing.Size(99, 21);
            this.cboBorderWidth.TabIndex = 13;
            this.cboBorderWidth.SelectedIndexChanged += new System.EventHandler(this.cboBorderWidth_SelectedIndexChanged);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("btnBackgroundColor.Image")));
            this.btnBackgroundColor.Location = new System.Drawing.Point(242, 94);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(55, 29);
            this.btnBackgroundColor.TabIndex = 12;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
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
            // btnBorderColor
            // 
            this.btnBorderColor.Image = ((System.Drawing.Image)(resources.GetObject("btnBorderColor.Image")));
            this.btnBorderColor.Location = new System.Drawing.Point(242, 13);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(55, 30);
            this.btnBorderColor.TabIndex = 11;
            this.btnBorderColor.UseVisualStyleBackColor = true;
            this.btnBorderColor.Click += new System.EventHandler(this.btnBorderColor_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(21, 102);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(92, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Background Color";
            // 
            // txtBackgroundColor
            // 
            this.txtBackgroundColor.Location = new System.Drawing.Point(134, 99);
            this.txtBackgroundColor.Name = "txtBackgroundColor";
            this.txtBackgroundColor.Size = new System.Drawing.Size(100, 20);
            this.txtBackgroundColor.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(44, 49);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Border Width";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(48, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Border Color";
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
            // chkApplyCellProperties
            // 
            this.chkApplyCellProperties.AutoSize = true;
            this.chkApplyCellProperties.Location = new System.Drawing.Point(141, 230);
            this.chkApplyCellProperties.Name = "chkApplyCellProperties";
            this.chkApplyCellProperties.Size = new System.Drawing.Size(122, 17);
            this.chkApplyCellProperties.TabIndex = 10;
            this.chkApplyCellProperties.Text = "Apply Cell Properties";
            this.chkApplyCellProperties.UseVisualStyleBackColor = true;
            this.chkApplyCellProperties.CheckedChanged += new System.EventHandler(this.chkApplyCellProperties_CheckedChanged);
            // 
            // txtBorderColor
            // 
            this.txtBorderColor.Location = new System.Drawing.Point(134, 19);
            this.txtBorderColor.Name = "txtBorderColor";
            this.txtBorderColor.Size = new System.Drawing.Size(100, 20);
            this.txtBorderColor.TabIndex = 4;
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
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnCancel);
            this.GroupBox3.Controls.Add(this.btnOK);
            this.GroupBox3.Location = new System.Drawing.Point(8, 390);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(303, 52);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            // 
            // txtCellBorderColor
            // 
            this.txtCellBorderColor.Location = new System.Drawing.Point(135, 19);
            this.txtCellBorderColor.Name = "txtCellBorderColor";
            this.txtCellBorderColor.Size = new System.Drawing.Size(100, 20);
            this.txtCellBorderColor.TabIndex = 4;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cboBorderStyle);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.cboBorderWidth);
            this.GroupBox2.Controls.Add(this.btnBackgroundColor);
            this.GroupBox2.Controls.Add(this.btnBorderColor);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.txtBackgroundColor);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtBorderColor);
            this.GroupBox2.Location = new System.Drawing.Point(8, 90);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(303, 131);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Table Properties";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(79, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Rows";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(66, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Columns";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(134, 44);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 1;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(134, 17);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 20);
            this.txtColumns.TabIndex = 0;
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
            this.grpCellProperties.Enabled = false;
            this.grpCellProperties.Location = new System.Drawing.Point(7, 253);
            this.grpCellProperties.Name = "grpCellProperties";
            this.grpCellProperties.Size = new System.Drawing.Size(303, 131);
            this.grpCellProperties.TabIndex = 9;
            this.grpCellProperties.TabStop = false;
            this.grpCellProperties.Text = "Cell Properties";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtRows);
            this.GroupBox1.Controls.Add(this.txtColumns);
            this.GroupBox1.Location = new System.Drawing.Point(8, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(303, 81);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            // 
            // frmTableProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 447);
            this.Controls.Add(this.chkApplyCellProperties);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.grpCellProperties);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTableProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table Properties";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.grpCellProperties.ResumeLayout(false);
            this.grpCellProperties.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboCellBorderStyle;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cboCellBorderWidth;
        internal System.Windows.Forms.Button btnCellBackgroundColor;
        internal System.Windows.Forms.ComboBox cboBorderStyle;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cboBorderWidth;
        internal System.Windows.Forms.Button btnBackgroundColor;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCellBackgroundColor;
        internal System.Windows.Forms.Button btnBorderColor;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtBackgroundColor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCellBorderColor;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.CheckBox chkApplyCellProperties;
        internal System.Windows.Forms.TextBox txtBorderColor;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtCellBorderColor;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtRows;
        internal System.Windows.Forms.TextBox txtColumns;
        internal System.Windows.Forms.GroupBox grpCellProperties;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}