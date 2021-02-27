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
        Me.txtCols = New System.Windows.Forms.TextBox()
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dudBorderWidth = New System.Windows.Forms.DomainUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBorderColor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBorderStyle = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtCols
        '
        Me.txtCols.Enabled = False
        Me.txtCols.Location = New System.Drawing.Point(105, 12)
        Me.txtCols.Name = "txtCols"
        Me.txtCols.Size = New System.Drawing.Size(114, 20)
        Me.txtCols.TabIndex = 0
        '
        'txtRows
        '
        Me.txtRows.Enabled = False
        Me.txtRows.Location = New System.Drawing.Point(105, 47)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(114, 20)
        Me.txtRows.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Columns"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rows"
        '
        'dudBorderWidth
        '
        Me.dudBorderWidth.Items.Add("1px")
        Me.dudBorderWidth.Items.Add("2px")
        Me.dudBorderWidth.Items.Add("3px")
        Me.dudBorderWidth.Items.Add("4px")
        Me.dudBorderWidth.Items.Add("5px")
        Me.dudBorderWidth.Items.Add("6px")
        Me.dudBorderWidth.Location = New System.Drawing.Point(105, 82)
        Me.dudBorderWidth.Name = "dudBorderWidth"
        Me.dudBorderWidth.Size = New System.Drawing.Size(52, 20)
        Me.dudBorderWidth.TabIndex = 4
        Me.dudBorderWidth.Text = "DomainUpDown1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Border Width"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 199)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(107, 36)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(138, 199)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 36)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Border Color"
        '
        'txtBorderColor
        '
        Me.txtBorderColor.Location = New System.Drawing.Point(105, 118)
        Me.txtBorderColor.Name = "txtBorderColor"
        Me.txtBorderColor.Size = New System.Drawing.Size(114, 20)
        Me.txtBorderColor.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Border Style"
        '
        'cboBorderStyle
        '
        Me.cboBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorderStyle.FormattingEnabled = True
        Me.cboBorderStyle.Items.AddRange(New Object() {"none", "hidden", "dotted", "dashed", "solid", "double", "groove", "ridge", "inset", "outset"})
        Me.cboBorderStyle.Location = New System.Drawing.Point(105, 153)
        Me.cboBorderStyle.Name = "cboBorderStyle"
        Me.cboBorderStyle.Size = New System.Drawing.Size(114, 21)
        Me.cboBorderStyle.TabIndex = 12
        '
        'frmTableProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 249)
        Me.Controls.Add(Me.cboBorderStyle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBorderColor)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dudBorderWidth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRows)
        Me.Controls.Add(Me.txtCols)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTableProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table Properties"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCols As TextBox
    Friend WithEvents txtRows As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dudBorderWidth As DomainUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBorderColor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboBorderStyle As ComboBox
End Class
