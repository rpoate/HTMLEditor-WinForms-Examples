Public Class frmTableProperties

    Public Property Cancelled As Boolean = True

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Cancelled = False
        Me.Hide()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Cancelled = True
        Me.Hide()

    End Sub
End Class