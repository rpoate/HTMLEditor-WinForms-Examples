Public Class Form1

    Dim btnTableProperties As ToolStripItem
    Dim btnCellProperties As ToolStripItem

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        btnTableProperties = Me.HtmlEditControl1.ToolStripItems.Add("Table Properties")
        btnTableProperties.Padding = New Padding(2)
        btnTableProperties.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnTableProperties.ImageScaling = ToolStripItemImageScaling.SizeToFit
        btnTableProperties.Enabled = False
        AddHandler btnTableProperties.Click, AddressOf btnTableProperties_Click

        btnCellProperties = Me.HtmlEditControl1.ToolStripItems.Add("Cell Properties")
        btnCellProperties.Padding = New Padding(2)
        btnCellProperties.DisplayStyle = ToolStripItemDisplayStyle.Text
        btnCellProperties.ImageScaling = ToolStripItemImageScaling.SizeToFit
        btnCellProperties.Enabled = False
        AddHandler btnCellProperties.Click, AddressOf btnCellProperties_Click

        Me.HtmlEditControl1.CSSText = "table {border-collapse: separate !important; } body {font-family: Arial}"
        Me.HtmlEditControl1.DocumentHTML = "<p>In this example the editor has had two custom buttons added to it's menu bar; a table properties and individual cell properties button. They are only enabled if the user clicks into a table cell. </p><table style='width: 100%;'><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr></table><p></p>"

    End Sub

    Private Sub btnCellProperties_Click(sender As Object, e As EventArgs)

        Dim oTD As HtmlElement = FindTDElement(Me.HtmlEditControl1.CurrentWindowsFormsElement)
        Dim oFrmTD As New frmCellProperties
        Dim oDict As New Dictionary(Of String, String)
        Dim oCellCSS As InlineCssParser

        oCellCSS = New InlineCssParser(oTD.Style)

        If oCellCSS.HasName("background-color") Then
            oFrmTD.txtCellBackgroundColor.Text = oCellCSS.GetValue("background-color")
        End If

        If oCellCSS.HasName("border-color") Then
            oFrmTD.txtCellBorderColor.Text = oCellCSS.GetValue("border-color")
        End If

        If oCellCSS.HasName("border-width") Then
            oFrmTD.cboCellBorderWidth.SelectedItem = oCellCSS.GetValue("border-width")
        End If

        If oCellCSS.HasName("border-style") Then
            oFrmTD.cboCellBorderStyle.SelectedItem = oCellCSS.GetValue("border-style")
        End If



        oFrmTD.ShowDialog(Me)

        If Not oFrmTD.Cancelled Then
            oCellCSS.SetValue("background-color", oFrmTD.txtCellBackgroundColor.Text)
            oCellCSS.SetValue("border-color", oFrmTD.txtCellBorderColor.Text)
            oCellCSS.SetValue("border-width", oFrmTD.cboCellBorderWidth.SelectedItem)
            oCellCSS.SetValue("border-style", oFrmTD.cboCellBorderStyle.SelectedItem)

            oTD.Style = oCellCSS.InlineCss

        End If

        oFrmTD.Close()

    End Sub

    Private Sub btnTableProperties_Click(sender As Object, e As EventArgs)

        Dim oTable As HtmlElement = FindTableElement(Me.HtmlEditControl1.CurrentWindowsFormsElement)
        Dim oFrmTable As New frmTableProperties
        Dim oDict As New Dictionary(Of String, String)
        Dim oTableCSS As InlineCssParser
        Dim oCellCSS As InlineCssParser

        oFrmTable.Adding = oTable = Nothing

        If Not oFrmTable.Adding Then
            Try
                oFrmTable.txtRows.Text = oTable.GetElementsByTagName("TR").Count
                oFrmTable.txtColumns.Text = oTable.GetElementsByTagName("TR")(0).GetElementsByTagName("TD").Count
            Catch
                MsgBox("Table element has no rows or first row has no coloumns.")
                Exit Sub
            End Try

            oTableCSS = New InlineCssParser(oTable.Style)

            If oTableCSS.HasName("background-color") Then
                oFrmTable.txtBackgroundColor.Text = oTableCSS.GetValue("background-color")
            End If

            If oTableCSS.HasName("border-color") Then
                oFrmTable.txtBorderColor.Text = oTableCSS.GetValue("border-color")
            End If

            If oTableCSS.HasName("border-width") Then
                oFrmTable.cboBorderWidth.SelectedItem = oTableCSS.GetValue("border-width")
            End If

            If oTableCSS.HasName("border-style") Then
                oFrmTable.cboBorderStyle.SelectedItem = oTableCSS.GetValue("border-style")
            End If

        Else
            oTableCSS = New InlineCssParser(vbNullString)
        End If

        oFrmTable.ShowDialog(Me)

        If Not oFrmTable.Cancelled Then
            oTableCSS.SetValue("background-color", oFrmTable.txtBackgroundColor.Text)
            oTableCSS.SetValue("border-color", oFrmTable.txtBorderColor.Text)
            oTableCSS.SetValue("border-width", oFrmTable.cboBorderWidth.SelectedItem)
            oTableCSS.SetValue("border-style", oFrmTable.cboBorderStyle.SelectedItem)

            oTable.Style = oTableCSS.InlineCss

            If oFrmTable.chkApplyCellProperties.Checked Then

                oCellCSS = New InlineCssParser("")

                oCellCSS.SetValue("background-color", oFrmTable.txtCellBackgroundColor.Text)
                oCellCSS.SetValue("border-color", oFrmTable.txtCellBorderColor.Text)
                oCellCSS.SetValue("border-width", oFrmTable.cboCellBorderWidth.SelectedItem)
                oCellCSS.SetValue("border-style", oFrmTable.cboCellBorderStyle.SelectedItem)

                For Each oRow As HtmlElement In oTable.GetElementsByTagName("TR")
                    For Each oCell As HtmlElement In oRow.GetElementsByTagName("TD")
                        oCell.Style = oCellCSS.InlineCss
                    Next
                Next
            End If

        End If

        oFrmTable.Close()

    End Sub

    Private Sub HtmlEditControl1_UserInteraction(sender As Object, e As Zoople.UserInteractionEventsArgs) Handles HtmlEditControl1.UserInteraction

        btnTableProperties.Enabled = Not FindTableElement(Me.HtmlEditControl1.CurrentWindowsFormsElement) = Nothing
        btnCellProperties.Enabled = Not FindTDElement(Me.HtmlEditControl1.CurrentWindowsFormsElement) = Nothing

    End Sub

    Private Function FindTableElement(ByVal element As HtmlElement) As HtmlElement

        If element Is Nothing Then Return Nothing
        If element.TagName.ToLowerInvariant() = "html" Then Return Nothing

        If element.TagName.ToLower() = "table" Then
            Return element
        Else
            Return FindTableElement(element.Parent)
        End If

    End Function

    Private Function FindTDElement(ByVal element As HtmlElement) As HtmlElement

        If element Is Nothing Then Return Nothing
        If element.TagName.ToLowerInvariant() = "html" Then Return Nothing

        If element.TagName.ToLower() = "td" Then
            Return element
        Else
            Return FindTDElement(element.Parent)
        End If

    End Function
End Class
