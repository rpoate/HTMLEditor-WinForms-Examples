Imports System.IO

Partial Public Class Form1
    Inherits Form

    Private oEdit As Zoople.HTMLEditControl

    Public Sub New()
        InitializeComponent()
        oEdit = New Zoople.HTMLEditControl With {
            .Parent = Me.panel3,
            .Dock = DockStyle.Fill,
            .HideDOMToolbar = False,
            .HideMainToolbar = True,
            .DocumentHTML = "<h2>Custom Menu and Toolstrip.</h2><img align='right' src='https://zoople.tech/img/logo.png?1' /><p>This instance of the control is using a <i>custom menu bar</i> and <b>toolstrip</b>.</p><p>The CurrentSelectionInfoUpdated event contains information regarding the status of the avaliable clipboard operations, text / control attributes for the current selection in the editor as you see when clicking on the <b>bold</b> or <i>italic</i> text</p>",
            .ShowPropertyGrid = False,
            .CSSText = "BODY {font-family: Arial Unicode MS, Arial, Sans-Serif; border: none;} .courierText {font-family: courier;} .BlueBorder {border: 1px solid rgb(77, 178, 255); padding-left:3px; padding-right: 3px}",
            .LicenceKey = "YourLicenseKey",
            .LicenceKeyInlineSpelling = "InlineSpellingLicenceKey",
            .EnableInlineSpelling = True
        }
        AddHandler toolStrip1.Items.Add("Insert Signature").Click, AddressOf SigClick
        panel3.Controls.Add(oEdit)
    End Sub

    Private Sub SigClick(ByVal sender As Object, ByVal e As EventArgs)
        oEdit.InsertHTMLELement("p").InnerHtml = "<b><i>Isaac Newtown<br />p. 555-098723</i></b>"
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        AddHandler oEdit.CurrentSelectionInfoUpdated, AddressOf Editor_CurrentSelectionInfoUpdated
        AddHandler oEdit.CancellableUserInteraction, AddressOf OEdit_CancellableUserInteraction
    End Sub

    Private Sub OEdit_CancellableUserInteraction(ByVal sender As Object, ByVal e As Zoople.CancellableUserInteractionEventsArgs)
        If e.InteractionType = "onkeydown" Then

            If e.Keys.Keycode = CInt(Keys.S) AndAlso e.Keys.Control Then
                e.Cancel = True
                SaveDocument()
            Else

                If e.Keys.Keycode = CInt(Keys.O) AndAlso e.Keys.Control Then
                    e.Cancel = True
                    OpenDocument()
                Else

                    If e.Keys.Keycode = CInt(Keys.N) AndAlso e.Keys.Control Then
                        e.Cancel = True
                        newToolStripButton_Click(Me, Nothing)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Editor_CurrentSelectionInfoUpdated(ByVal sender As Object, ByVal e As Zoople.SelectionInfoUpdatedEventArgs)
        copyToolStripButton.Enabled = e.SelectionStatus.CanCopy
        cutToolStripButton.Enabled = e.SelectionStatus.CanCut
        pasteToolStripButton.Enabled = e.SelectionStatus.CanPaste
        copyToolStripMenuItem.Enabled = e.SelectionStatus.CanCopy
        cutToolStripMenuItem.Enabled = e.SelectionStatus.CanCut
        pasteToolStripMenuItem.Enabled = e.SelectionStatus.CanPaste
        undoToolStripMenuItem.Enabled = e.SelectionStatus.CanUndo
        redoToolStripMenuItem.Enabled = e.SelectionStatus.CanRedo
        BoldtoolStripButton.Checked = e.SelectionStatus.IsBold
        UnderlinetoolStripButton.Checked = e.SelectionStatus.IsUnderline
        ItalictoolStripButton.Checked = e.SelectionStatus.IsItalic
    End Sub

    Private Sub cutToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cutToolStripButton.Click
        oEdit.cut_document()
    End Sub

    Private Sub copyToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripButton.Click
        oEdit.copy_document()
    End Sub

    Private Sub pasteToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pasteToolStripButton.Click
        oEdit.paste_document()
    End Sub

    Private Sub printToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printToolStripButton.Click
        oEdit.print_Document()
    End Sub

    Private Sub newToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripButton.Click
        NewDocument()
    End Sub

    Private Sub NewDocument()
        If oEdit.IsDirty Then
            Dim oResult As DialogResult
            oResult = MessageBox.Show("Save Changes?", "Editor", MessageBoxButtons.YesNoCancel)

            Select Case oResult
                Case DialogResult.Yes

                    If SaveDocument() Then
                        Exit Select
                    Else
                        Return
                    End If

                Case DialogResult.Cancel
                    Return
            End Select
        End If

        oEdit.DocumentHTML = ""
    End Sub

    Private Sub undoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles undoToolStripMenuItem.Click
        oEdit.undo_document()
    End Sub

    Private Sub redoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles redoToolStripMenuItem.Click
        oEdit.redo_document()
    End Sub

    Private Sub openToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripButton.Click
        If oEdit.IsDirty Then
            Dim oResult As DialogResult
            oResult = MessageBox.Show("Save Changes?", "Editor", MessageBoxButtons.YesNoCancel)

            Select Case oResult
                Case DialogResult.Yes

                    If SaveDocument() Then
                        Exit Select
                    Else
                        Return
                    End If

                Case DialogResult.Cancel
                    Return
            End Select
        End If

        OpenDocument()
    End Sub

    Private Function SaveDocument() As Boolean
        Dim oDialog As SaveFileDialog = New SaveFileDialog With {
            .Filter = "HTML Files|*.html",
            .OverwritePrompt = True
        }

        If oDialog.ShowDialog(Me) = DialogResult.OK Then
            Return SaveHTMLFile(oDialog.FileName)
        Else
            Return False
        End If
    End Function

    Private Function SaveHTMLFile(ByVal fileName As String) As Boolean
        Try
            File.WriteAllText(fileName, oEdit.DocumentHTML)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save File Failed")
            Return False
        End Try
    End Function

    Private Sub OpenDocument()
        Dim oDialog As OpenFileDialog = New OpenFileDialog With {
            .Filter = "HTML files (*.html)|*.html|HTM files (*.htm)|*.htm|All files (*.*)|*.*",
            .CheckFileExists = True,
            .Multiselect = False
        }
        If oDialog.ShowDialog(Me) = DialogResult.OK Then LoadHTMLFile(oDialog.FileName)
    End Sub

    Private Sub LoadHTMLFile(ByVal fileName As String)
        Dim FileContent As String = New StreamReader(fileName).ReadToEnd()

        If FileContent.IndexOf("<body>", StringComparison.OrdinalIgnoreCase) > 0 Then
            Dim bodyopenpos As Integer = FileContent.IndexOf("<body>", StringComparison.OrdinalIgnoreCase)
            Dim bodyclosepos As Integer = FileContent.IndexOf("</body>", StringComparison.OrdinalIgnoreCase)
            oEdit.DocumentHTML = FileContent.Substring(bodyopenpos + 6, bodyclosepos - bodyopenpos - 6)
        Else
            oEdit.DocumentHTML = FileContent
        End If
    End Sub

    Private Sub newToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripMenuItem.Click
        NewDocument()
    End Sub

    Private Sub AlignLeftToolstripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AlignLeftToolstripButton.Click
        oEdit.Justify_Left()
    End Sub

    Private Sub AlignCenterToolstripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AlignCenterToolstripButton.Click
        oEdit.Justify_Center()
    End Sub

    Private Sub AlignRightToolstripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AlignRightToolstripButton.Click
        oEdit.Justify_Right()
    End Sub

    Private Sub AlignFullToolstripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AlignFullToolstripButton.Click
        oEdit.Justify_Full()
    End Sub

    Private Sub InsertImageToolstripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InsertImageToolstripButton.Click
        oEdit.Insert_Image()
    End Sub

    Private Sub cutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripMenuItem.Click
        cutToolStripButton_Click(sender, e)
    End Sub

    Private Sub copyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripMenuItem.Click
        copyToolStripButton_Click(sender, e)
    End Sub

    Private Sub pasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pasteToolStripMenuItem.Click
        pasteToolStripButton_Click(sender, e)
    End Sub

    Private Sub printPreviewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printPreviewToolStripMenuItem.Click
        oEdit.print_Preview()
    End Sub

    Private Sub selectAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectAllToolStripMenuItem.Click
        oEdit.SelectAll_Document()
    End Sub

    Private Sub BoldtoolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BoldtoolStripButton.Click
        oEdit.bold_document()
    End Sub

    Private Sub ItalictoolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ItalictoolStripButton.Click
        oEdit.Italic_document()
    End Sub

    Private Sub UnderlinetoolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UnderlinetoolStripButton.Click
        oEdit.Underline_document()
    End Sub

    Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        MessageBox.Show("HTML Editor with a custom menu bar and tool strip", "Zoople HTML Editor .NET", MessageBoxButtons.OK)
    End Sub

    Private Sub saveToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveToolStripButton.Click
        SaveDocument()
    End Sub

    Private Sub saveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveToolStripMenuItem.Click
        SaveDocument()
    End Sub

    Private Sub RemoveFormattingToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveFormattingToolStripButton.Click
        Me.oEdit.Remove_Formatting()
    End Sub

    Private Sub ForeColorToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ForeColorToolStripButton.Click
        Dim color As String = GetColor()

        If color IsNot Nothing Then
            Me.oEdit.Document.ExecCommand("ForeColor", False, color)
        End If
    End Sub

    Private Sub HighlightColorToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HighlightColorToolStripButton.Click
        Dim color As String = GetColor()

        If color IsNot Nothing Then
            Me.oEdit.Document.ExecCommand("BackColor", False, color)
        End If
    End Sub

    Private Function GetColor() As String
        Dim colorDialog As ColorDialog = New ColorDialog()

        Try
            If colorDialog.ShowDialog() = DialogResult.OK Then
                Return "rgb(" & colorDialog.Color.R & "," & colorDialog.Color.G & "," & colorDialog.Color.B & ")"
            Else
                Return Nothing
            End If
        Catch
            Return Nothing
        End Try

    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        oEdit.SpellCheckDocument(True)
    End Sub
End Class

