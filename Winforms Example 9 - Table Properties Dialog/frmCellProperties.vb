Imports System.Text

Public Class frmCellProperties

    Public Cancelled As Boolean = True

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Cancelled = False
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Cancelled = True
        Me.Hide()
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