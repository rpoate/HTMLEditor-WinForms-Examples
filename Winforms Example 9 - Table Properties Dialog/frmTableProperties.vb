Imports System.Text

Public Class frmTableProperties

    Private m_Adding As Boolean
    Public Cancelled As Boolean = True

    Public Property Adding As Boolean
        Get
            Return m_Adding
        End Get
        Set(value As Boolean)
            Me.txtColumns.Enabled = value
            Me.txtRows.Enabled = value
            m_Adding = value
        End Set
    End Property

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Cancelled = False
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Cancelled = True
        Me.Hide()
    End Sub

    Private Sub btnBorderColor_Click(sender As Object, e As EventArgs) Handles btnBorderColor.Click

        Dim oColor As Color = GetColor()

        If Not oColor = Nothing Then

            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendFormat("#")
            sb.Append(BitConverter.ToString(New Byte() {oColor.R}))
            sb.Append(BitConverter.ToString(New Byte() {oColor.G}))
            sb.Append(BitConverter.ToString(New Byte() {oColor.B}))

            txtBorderColor.Text = sb.ToString
        End If

    End Sub

    Private Sub btnBackgroundColor_Click(sender As Object, e As EventArgs) Handles btnBackgroundColor.Click

        Dim oColor As Color = GetColor()

        If Not oColor = Nothing Then

            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendFormat("#")
            sb.Append(BitConverter.ToString(New Byte() {oColor.R}))
            sb.Append(BitConverter.ToString(New Byte() {oColor.G}))
            sb.Append(BitConverter.ToString(New Byte() {oColor.B}))

            txtBackgroundColor.Text = sb.ToString
        End If

    End Sub

    Private Function GetColor() As Color

        Dim oColorDialog As New ColorDialog
        Dim oDialogResult As DialogResult

        oDialogResult = oColorDialog.ShowDialog(Me)

        If oDialogResult = DialogResult.OK Then
            Return oColorDialog.Color
        Else
            Return Nothing
        End If

    End Function

    Private Sub chkApplyCellProperties_CheckedChanged(sender As Object, e As EventArgs) Handles chkApplyCellProperties.CheckedChanged

        grpCellProperties.Enabled = Me.chkApplyCellProperties.Checked

    End Sub

    Private Sub btnCellBorderColor_Click(sender As Object, e As EventArgs) Handles btnCellBorderColor.Click

        Dim oColor As Color = GetColor()

        If Not oColor = Nothing Then

            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendFormat("#")
            sb.Append(BitConverter.ToString(New Byte() {oColor.R}))
            sb.Append(BitConverter.ToString(New Byte() {oColor.G}))
            sb.Append(BitConverter.ToString(New Byte() {oColor.B}))

            txtCellBorderColor.Text = sb.ToString
        End If

    End Sub

    Private Sub btnCellBackgroundColor_Click(sender As Object, e As EventArgs) Handles btnCellBackgroundColor.Click

        Dim oColor As Color = GetColor()

        If Not oColor = Nothing Then

            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendFormat("#")
            sb.Append(BitConverter.ToString(New Byte() {oColor.R}))
            sb.Append(BitConverter.ToString(New Byte() {oColor.G}))
            sb.Append(BitConverter.ToString(New Byte() {oColor.B}))

            txtCellBackgroundColor.Text = sb.ToString
        End If

    End Sub
End Class