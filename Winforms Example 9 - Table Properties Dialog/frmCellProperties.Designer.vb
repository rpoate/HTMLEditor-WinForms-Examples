<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCellProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCellProperties))
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grpCellProperties.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grpCellProperties.Location = New System.Drawing.Point(12, 12)
        Me.grpCellProperties.Name = "grpCellProperties"
        Me.grpCellProperties.Size = New System.Drawing.Size(303, 131)
        Me.grpCellProperties.TabIndex = 5
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnOK)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 52)
        Me.GroupBox3.TabIndex = 4
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
        'frmCellProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 214)
        Me.Controls.Add(Me.grpCellProperties)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCellProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cell Properties"
        Me.grpCellProperties.ResumeLayout(False)
        Me.grpCellProperties.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
End Class
