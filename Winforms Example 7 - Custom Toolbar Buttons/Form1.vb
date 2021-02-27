Imports Zoople

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.HtmlEditControl1.CSSText = "body {font-family: tahoma}"
        Me.HtmlEditControl1.DocumentHTML = "<p>The editor has had&nbsp;two elements added to the main toolbar. The &lt;hr&gt; button and a dropdown to insert HTML snippets.</p>"

        Dim oSep As ToolStripSeparator = New ToolStripSeparator()
        oSep.Padding = New Padding(3)
        Me.HtmlEditControl1.ToolStripItems.Add(oSep)

        Dim oHorizontalRule As ToolStripButton = New ToolStripButton(Image.FromFile("Images\hr.png"))
        oHorizontalRule.Padding = New Padding(3)
        oHorizontalRule.ToolTipText = "Insert Horizontal Rule"
        oHorizontalRule.Text = "hr"
        oHorizontalRule.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        Me.HtmlEditControl1.ToolStripItems.Add(oHorizontalRule)

        AddHandler oHorizontalRule.Click, AddressOf oHorizontalRule_Click

        Dim oDropDown As ToolStripDropDownButton = New ToolStripDropDownButton("Insert Snippets")
        oDropDown.Padding = New Padding(3)
        Me.HtmlEditControl1.ToolStripItems.Add(oDropDown)

        Dim oblockquote As ToolStripButton = New ToolStripButton("WWF block quote")
        oblockquote.Width = 150
        oblockquote.AutoSize = True
        AddHandler oblockquote.Click, AddressOf oblockquote_Click

        oDropDown.DropDownItems.Add(oblockquote)

        Dim oSignature As ToolStripButton = New ToolStripButton("Signature")
        oSignature.Width = 150
        oSignature.AutoSize = True
        AddHandler oSignature.Click, AddressOf oSignature_Click

        oDropDown.DropDownItems.Add(oSignature)

        Dim oGoogleImage As ToolStripButton = New ToolStripButton("Google Image")
        oGoogleImage.Width = 150
        oGoogleImage.AutoSize = True
        AddHandler oGoogleImage.Click, AddressOf oGoogleImage_Click

        oDropDown.DropDownItems.Add(oGoogleImage)

        Dim oSep2 As ToolStripSeparator = New ToolStripSeparator()
        oSep2.Padding = New Padding(3)
        Me.HtmlEditControl1.ToolStripItems.Add(oSep2)

    End Sub

    Private Sub oHorizontalRule_Click(sender As Object, e As EventArgs)
        Me.HtmlEditControl1.InsertHTMLELement("hr")
    End Sub

    Private Sub oblockquote_Click(sender As Object, e As EventArgs)

        Dim blockquote As HtmlElement = Me.HtmlEditControl1.InsertHTMLELement("blockquote")

        blockquote.InnerHtml = "For 50 years, WWF has been protecting the future of nature. The world's leading conservation organization, WWF works in 100 countries and is supported by 1.2 million members in the United States and close to 5 million globally."
        blockquote.SetAttribute("cite", "http://www.worldwildlife.org/who/index.html")

    End Sub

    Private Sub oSignature_Click(sender As Object, e As EventArgs)

        Dim signature As HtmlElement = Me.HtmlEditControl1.InsertHTMLELement("footer")

        signature.AppendChild(signature.Document.CreateElement("p")).InnerHtml = "Julius Ceasar"
        signature.AppendChild(signature.Document.CreateElement("p")).InnerHtml = "1 Old Rome Way, Rome, Italy"
        signature.AppendChild(signature.Document.CreateElement("p")).InnerHtml = "p (123) 456 789"
        signature.AppendChild(signature.Document.CreateElement("p")).InnerHtml = "e <a href=""mailto: julius@allrome.com"">julius@allrome.com</a>"

    End Sub

    Private Sub oGoogleImage_Click(sender As Object, e As EventArgs)

        Dim gImage As HtmlElement = Me.HtmlEditControl1.InsertHTMLELement("image")

        gImage.SetAttribute("src", "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png")

    End Sub

End Class
