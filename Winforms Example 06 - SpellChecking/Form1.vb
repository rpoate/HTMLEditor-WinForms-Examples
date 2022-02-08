Imports Zoople

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim oSpellCheckButton As ToolStripItem
        Dim oSpellCheckButtonDialog As ToolStripItem

        oSpellCheckButton = Me.HtmlEditControl1.ToolStripItems.Add("Spell Check")
        oSpellCheckButton.Padding = New Padding(3)
        AddHandler oSpellCheckButton.Click, AddressOf SpellCheckButton_Click

        oSpellCheckButtonDialog = Me.HtmlEditControl1.ToolStripItems.Add("Spell Check (w/ Dialog)")
        oSpellCheckButtonDialog.Padding = New Padding(3)
        AddHandler oSpellCheckButtonDialog.Click, AddressOf SpellCheckButtonDialog_Click

        Me.HtmlEditControl1.DocumentHTML = "<p>Supposedly humans cna still unrdestand mispselled wodrs, gvien context..</p>"
        Me.HtmlEditControl1.CSSText = "body {font-family: Arial; font-size: 12pt}"
        Me.HtmlEditControl1.EnableInlineSpelling = True
        Me.HtmlEditControl1.LicenceKeyInlineSpelling = ""

        ' add some custom autotext replacements
        Me.HtmlEditControl1.SpellingAutoCorrectionList.Add("cw", "&copy;")
        Me.HtmlEditControl1.SpellingAutoCorrectionList.Add("td", "trademark")
        Me.HtmlEditControl1.SpellingAutoCorrectionList.Add("pp", "<span style='color:red'>pianissimo</span>")

    End Sub

    Private Sub SpellCheckButtonDialog_Click(sender As Object, e As EventArgs)
        Me.HtmlEditControl1.SpellCheckDocument(True)
    End Sub

    Private Sub SpellCheckButton_Click(sender As Object, e As EventArgs)
        Me.HtmlEditControl1.SpellCheckDocument(False)
    End Sub

    Private Sub HtmlEditControl1_DocumentLoadComplete(sender As Object, e As EventArgs) Handles HtmlEditControl1.DocumentLoadComplete
        Me.HtmlEditControl1.SpellCheckDocument(False)
    End Sub
End Class
