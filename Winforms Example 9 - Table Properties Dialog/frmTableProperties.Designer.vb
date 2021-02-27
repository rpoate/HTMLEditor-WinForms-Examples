<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableProperties
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableProperties))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.txtColumns = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboBorderStyle = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBorderWidth = New System.Windows.Forms.ComboBox()
        Me.btnBackgroundColor = New System.Windows.Forms.Button()
        Me.btnBorderColor = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBackgroundColor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBorderColor = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grpCellProperties = New System.Windows.Forms.GroupBox()
        Me.cboCellBorderStyle = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCellBorderWidth = New System.Windows.Forms.ComboBox()
        Me.btnCellBackgroundColor = New System.Windows.Forms.Button()
        Me.btnCellBorderColor = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCellBackgroundColor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCellBorderColor = New System.Windows.Forms.TextBox()
        Me.chkApplyCellProperties = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpCellProperties.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRows)
        Me.GroupBox1.Controls.Add(Me.txtColumns)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 81)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rows"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Columns"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtRows
        '
        Me.txtRows.Location = New System.Drawing.Point(134, 44)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(100, 20)
        Me.txtRows.TabIndex = 1
        '
        'txtColumns
        '
        Me.txtColumns.Location = New System.Drawing.Point(134, 17)
        Me.txtColumns.Name = "txtColumns"
        Me.txtColumns.Size = New System.Drawing.Size(100, 20)
        Me.txtColumns.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboBorderStyle)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboBorderWidth)
        Me.GroupBox2.Controls.Add(Me.btnBackgroundColor)
        Me.GroupBox2.Controls.Add(Me.btnBorderColor)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBackgroundColor)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtBorderColor)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 131)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Table Properties"
        '
        'cboBorderStyle
        '
        Me.cboBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorderStyle.FormattingEnabled = True
        Me.cboBorderStyle.Items.AddRange(New Object() {"solid", "dashed", "dotted", "double", "none"})
        Me.cboBorderStyle.Location = New System.Drawing.Point(134, 72)
        Me.cboBorderStyle.Name = "cboBorderStyle"
        Me.cboBorderStyle.Size = New System.Drawing.Size(99, 21)
        Me.cboBorderStyle.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Border Style"
        '
        'cboBorderWidth
        '
        Me.cboBorderWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorderWidth.FormattingEnabled = True
        Me.cboBorderWidth.Items.AddRange(New Object() {"none", "1px", "2px", "3px", "4px", "5px", "6px", "7px", "8px", "9px"})
        Me.cboBorderWidth.Location = New System.Drawing.Point(134, 45)
        Me.cboBorderWidth.Name = "cboBorderWidth"
        Me.cboBorderWidth.Size = New System.Drawing.Size(99, 21)
        Me.cboBorderWidth.TabIndex = 13
        '
        'btnBackgroundColor
        '
        Me.btnBackgroundColor.Image = CType(resources.GetObject("btnBackgroundColor.Image"), System.Drawing.Image)
        Me.btnBackgroundColor.Location = New System.Drawing.Point(242, 94)
        Me.btnBackgroundColor.Name = "btnBackgroundColor"
        Me.btnBackgroundColor.Size = New System.Drawing.Size(55, 29)
        Me.btnBackgroundColor.TabIndex = 12
        Me.btnBackgroundColor.UseVisualStyleBackColor = True
        '
        'btnBorderColor
        '
        Me.btnBorderColor.Image = CType(resources.GetObject("btnBorderColor.Image"), System.Drawing.Image)
        Me.btnBorderColor.Location = New System.Drawing.Point(242, 13)
        Me.btnBorderColor.Name = "btnBorderColor"
        Me.btnBorderColor.Size = New System.Drawing.Size(55, 30)
        Me.btnBorderColor.TabIndex = 11
        Me.btnBorderColor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Background Color"
        '
        'txtBackgroundColor
        '
        Me.txtBackgroundColor.Location = New System.Drawing.Point(134, 99)
        Me.txtBackgroundColor.Name = "txtBackgroundColor"
        Me.txtBackgroundColor.Size = New System.Drawing.Size(100, 20)
        Me.txtBackgroundColor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Border Width"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Border Color"
        '
        'txtBorderColor
        '
        Me.txtBorderColor.Location = New System.Drawing.Point(134, 19)
        Me.txtBorderColor.Name = "txtBorderColor"
        Me.txtBorderColor.Size = New System.Drawing.Size(100, 20)
        Me.txtBorderColor.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnOK)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 399)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 52)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(222, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(134, 19)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'grpCellProperties
        '
        Me.grpCellProperties.Controls.Add(Me.cboCellBorderStyle)
        Me.grpCellProperties.Controls.Add(Me.Label7)
        Me.grpCellProperties.Controls.Add(Me.cboCellBorderWidth)
        Me.grpCellProperties.Controls.Add(Me.btnCellBackgroundColor)
        Me.grpCellProperties.Controls.Add(Me.btnCellBorderColor)
        Me.grpCellProperties.Controls.Add(Me.Label8)
        Me.grpCellProperties.Controls.Add(Me.txtCellBackgroundColor)
        Me.grpCellProperties.Controls.Add(Me.Label9)
        Me.grpCellProperties.Controls.Add(Me.Label10)
        Me.grpCellProperties.Controls.Add(Me.txtCellBorderColor)
        Me.grpCellProperties.Enabled = False
        Me.grpCellProperties.Location = New System.Drawing.Point(11, 262)
        Me.grpCellProperties.Name = "grpCellProperties"
        Me.grpCellProperties.Size = New System.Drawing.Size(303, 131)
        Me.grpCellProperties.TabIndex = 3
        Me.grpCellProperties.TabStop = False
        Me.grpCellProperties.Text = "Cell Properties"
        '
        'cboCellBorderStyle
        '
        Me.cboCellBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCellBorderStyle.FormattingEnabled = True
        Me.cboCellBorderStyle.Items.AddRange(New Object() {"solid", "dashed", "dotted", "double", "none"})
        Me.cboCellBorderStyle.Location = New System.Drawing.Point(135, 72)
        Me.cboCellBorderStyle.Name = "cboCellBorderStyle"
        Me.cboCellBorderStyle.Size = New System.Drawing.Size(99, 21)
        Me.cboCellBorderStyle.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Border Style"
        '
        'cboCellBorderWidth
        '
        Me.cboCellBorderWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCellBorderWidth.FormattingEnabled = True
        Me.cboCellBorderWidth.Items.AddRange(New Object() {"none", "1px", "2px", "3px", "4px", "5px", "6px", "7px", "8px", "9px"})
        Me.cboCellBorderWidth.Location = New System.Drawing.Point(135, 45)
        Me.cboCellBorderWidth.Name = "cboCellBorderWidth"
        Me.cboCellBorderWidth.Size = New System.Drawing.Size(99, 21)
        Me.cboCellBorderWidth.TabIndex = 13
        '
        'btnCellBackgroundColor
        '
        Me.btnCellBackgroundColor.Image = CType(resources.GetObject("btnCellBackgroundColor.Image"), System.Drawing.Image)
        Me.btnCellBackgroundColor.Location = New System.Drawing.Point(243, 94)
        Me.btnCellBackgroundColor.Name = "btnCellBackgroundColor"
        Me.btnCellBackgroundColor.Size = New System.Drawing.Size(55, 29)
        Me.btnCellBackgroundColor.TabIndex = 12
        Me.btnCellBackgroundColor.UseVisualStyleBackColor = True
        '
        'btnCellBorderColor
        '
        Me.btnCellBorderColor.Image = CType(resources.GetObject("btnCellBorderColor.Image"), System.Drawing.Image)
        Me.btnCellBorderColor.Location = New System.Drawing.Point(243, 13)
        Me.btnCellBorderColor.Name = "btnCellBorderColor"
        Me.btnCellBorderColor.Size = New System.Drawing.Size(55, 30)
        Me.btnCellBorderColor.TabIndex = 11
        Me.btnCellBorderColor.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Background Color"
        '
        'txtCellBackgroundColor
        '
        Me.txtCellBackgroundColor.Location = New System.Drawing.Point(135, 99)
        Me.txtCellBackgroundColor.Name = "txtCellBackgroundColor"
        Me.txtCellBackgroundColor.Size = New System.Drawing.Size(100, 20)
        Me.txtCellBackgroundColor.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Border Width"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Border Color"
        '
        'txtCellBorderColor
        '
        Me.txtCellBorderColor.Location = New System.Drawing.Point(135, 19)
        Me.txtCellBorderColor.Name = "txtCellBorderColor"
        Me.txtCellBorderColor.Size = New System.Drawing.Size(100, 20)
        Me.txtCellBorderColor.TabIndex = 4
        '
        'chkApplyCellProperties
        '
        Me.chkApplyCellProperties.AutoSize = True
        Me.chkApplyCellProperties.Location = New System.Drawing.Point(145, 239)
        Me.chkApplyCellProperties.Name = "chkApplyCellProperties"
        Me.chkApplyCellProperties.Size = New System.Drawing.Size(122, 17)
        Me.chkApplyCellProperties.TabIndex = 5
        Me.chkApplyCellProperties.Text = "Apply Cell Properties"
        Me.chkApplyCellProperties.UseVisualStyleBackColor = True
        '
        'frmTableProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 460)
        Me.Controls.Add(Me.chkApplyCellProperties)
        Me.Controls.Add(Me.grpCellProperties)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTableProperties"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table Properties"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.grpCellProperties.ResumeLayout(False)
        Me.grpCellProperties.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRows As TextBox
    Friend WithEvents txtColumns As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBackgroundColor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBorderColor As TextBox
    Friend WithEvents btnBackgroundColor As Button
    Friend WithEvents btnBorderColor As Button
    Friend WithEvents cboBorderWidth As ComboBox
    Friend WithEvents cboBorderStyle As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents grpCellProperties As GroupBox
    Friend WithEvents cboCellBorderStyle As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCellBorderWidth As ComboBox
    Friend WithEvents btnCellBackgroundColor As Button
    Friend WithEvents btnCellBorderColor As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCellBackgroundColor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCellBorderColor As TextBox
    Friend WithEvents chkApplyCellProperties As CheckBox
End Class
