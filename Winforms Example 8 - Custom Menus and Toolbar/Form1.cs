 using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Winforms_Example_8___Custom_Menus_and_Toolbar
{
    public partial class Form1 : Form
    {
        Zoople.HTMLEditControl oEdit;

        public Form1()
        {

            InitializeComponent();

            oEdit = new Zoople.HTMLEditControl
            {
                Parent = this.panel3,
                Dock = DockStyle.Fill,
                HideDOMToolbar = false,
                HideMainToolbar = true,
                DocumentHTML = "<h2>Custom Menu and Toolstrip.</h2><img align='right' src='https://zoople.tech/img/logo.png?1' /><p>This instance of the control is using a <i>custom menu bar</i> and <b>toolstrip</b>.</p><p>The CurrentSelectionInfoUpdated event contains information regarding the status of the avaliable clipboard operations, text / control attributes for the current selection in the editor as you see when clicking on the <b>bold</b> or <i>italic</i> text</p>",
                ShowPropertyGrid = false,
                CSSText = "BODY {font-family: Arial Unicode MS, Arial, Sans-Serif; border: none;} .courierText {font-family: courier;} .BlueBorder {border: 1px solid rgb(77, 178, 255); padding-left:3px; padding-right: 3px}",
                LicenceKey = "YourLicenseKey",
                LicenceKeyInlineSpelling = "InlineSpellingLicence",
                EnableInlineSpelling = true
            };

            toolStrip1.Items.Add("Insert Signature").Click += SigClick;

            panel3.Controls.Add(oEdit);

        }

        private void SigClick(object sender, EventArgs e)
        {
            oEdit.InsertHTMLElement("p").InnerHtml = "<b><i>Isaac Newtown<br />p. 555-098723</i></b>";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oEdit.CurrentSelectionInfoUpdated += Editor_CurrentSelectionInfoUpdated;
            oEdit.CancellableUserInteraction += OEdit_CancellableUserInteraction;
        }

        private void OEdit_CancellableUserInteraction(object sender, Zoople.CancellableUserInteractionEventsArgs e)
        {

            if (e.InteractionType == "onkeydown")
            {
                if (e.Keys.Keycode == (int)Keys.S && e.Keys.Control)
                {
                    e.Cancel = true;
                    SaveDocument();
                }
                else
                {
                    if (e.Keys.Keycode == (int)Keys.O && e.Keys.Control)
                    {
                        e.Cancel = true;
                        OpenDocument();
                    }
                    else
                    {
                        if (e.Keys.Keycode == (int)Keys.N && e.Keys.Control)
                        {
                            e.Cancel = true;
                            newToolStripButton_Click(this, null);
                        }
                    }
                }
            }
        }

        private void Editor_CurrentSelectionInfoUpdated(object sender, Zoople.SelectionInfoUpdatedEventArgs e)
        {

            copyToolStripButton.Enabled = e.SelectionStatus.CanCopy;
            cutToolStripButton.Enabled = e.SelectionStatus.CanCut;
            pasteToolStripButton.Enabled = e.SelectionStatus.CanPaste;

            copyToolStripMenuItem.Enabled = e.SelectionStatus.CanCopy;
            cutToolStripMenuItem.Enabled = e.SelectionStatus.CanCut;
            pasteToolStripMenuItem.Enabled = e.SelectionStatus.CanPaste;

            undoToolStripMenuItem.Enabled = e.SelectionStatus.CanUndo;
            redoToolStripMenuItem.Enabled = e.SelectionStatus.CanRedo;

            BoldtoolStripButton.Checked = e.SelectionStatus.IsBold;
            UnderlinetoolStripButton.Checked = e.SelectionStatus.IsUnderline;
            ItalictoolStripButton.Checked = e.SelectionStatus.IsItalic;

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            oEdit.cut_document();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            oEdit.copy_document();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            oEdit.paste_document();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            oEdit.print_Document();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void NewDocument()
        {
            if (oEdit.IsDirty)
            {

                DialogResult oResult;

                oResult = MessageBox.Show("Save Changes?", "Editor", MessageBoxButtons.YesNoCancel);

                switch (oResult)
                {
                    case DialogResult.Yes:

                        if (SaveDocument())
                            break;
                        else
                            return;

                    case DialogResult.Cancel:

                        return;

                }
            }

            oEdit.DocumentHTML = "";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.undo_document();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.redo_document();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (oEdit.IsDirty)
            {

                DialogResult oResult;

                oResult = MessageBox.Show("Save Changes?", "Editor", MessageBoxButtons.YesNoCancel);

                switch (oResult)
                {
                    case DialogResult.Yes:

                        if (SaveDocument())
                            break;
                        else
                            return;

                    case DialogResult.Cancel:

                        return;

                }
            }

            OpenDocument();
        }

        private bool SaveDocument()
        {
            SaveFileDialog oDialog = new SaveFileDialog
            {
                Filter = "HTML Files|*.html",
                OverwritePrompt = true
            };

            if (oDialog.ShowDialog(this) == DialogResult.OK)
            {
                return SaveHTMLFile(oDialog.FileName);

            }
            else { return false; }

        }

        private bool SaveHTMLFile(string fileName)
        {
            try
            {
                File.WriteAllText(fileName, oEdit.DocumentHTML);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save File Failed");
                return false;
            }
        }

        private void OpenDocument()
        {
            OpenFileDialog oDialog = new OpenFileDialog
            {
                Filter = "HTML files (*.html)|*.html|HTM files (*.htm)|*.htm|All files (*.*)|*.*",
                CheckFileExists = true,
                Multiselect = false
            };

            if (oDialog.ShowDialog(this) == DialogResult.OK)
            {
                oEdit.BaseURL = "file:///" + new FileInfo(oDialog.FileName).DirectoryName;
                oEdit.UseRelativeURLs = true;
                LoadHTMLFile(oDialog.FileName);
            }
        }

        private void LoadHTMLFile(string fileName)
        {
            // In order to load the visible contents from a fully formed HTML document we
            // create a regex removing the meta information from the html document.
            // This strips out the meta information contained in the <head> element.
            // Note that doing so strips out CSS and any <script> tags contained in the <head> element.
            // CSS should be set using the CSSText property of the editor.

            string FileContent = new StreamReader(fileName).ReadToEnd();


            if (FileContent.IndexOf("<body>", StringComparison.OrdinalIgnoreCase) > 0)
            {
                int bodyopenpos = FileContent.IndexOf("<body>", StringComparison.OrdinalIgnoreCase);
                int bodyclosepos = FileContent.IndexOf("</body>", StringComparison.OrdinalIgnoreCase);

                oEdit.DocumentHTML = FileContent.Substring(bodyopenpos + 6, bodyclosepos - bodyopenpos - 6);
            }
            else
            {
                oEdit.DocumentHTML = FileContent;
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void AlignLeftToolstripButton_Click(object sender, EventArgs e)
        {
            oEdit.Justify_Left();
        }

        private void AlignCenterToolstripButton_Click(object sender, EventArgs e)
        {
            oEdit.Justify_Center();
        }

        private void AlignRightToolstripButton_Click(object sender, EventArgs e)
        {
            oEdit.Justify_Right();
        }

        private void AlignFullToolstripButton_Click(object sender, EventArgs e)
        {
            oEdit.Justify_Full();
        }

        private void InsertImageToolstripButton_Click(object sender, EventArgs e)
        {
            oEdit.Insert_Image();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton_Click(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton_Click(sender, e);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton_Click(sender, e);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.print_Preview();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.SelectAll_Document();
        }

        private void BoldtoolStripButton_Click(object sender, EventArgs e)
        {
            oEdit.bold_document();
        }

        private void ItalictoolStripButton_Click(object sender, EventArgs e)
        {
            oEdit.Italic_document();
        }

        private void UnderlinetoolStripButton_Click(object sender, EventArgs e)
        {
            oEdit.Underline_document();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HTML Editor with a custom menu bar and tool strip", "Zoople HTML Editor .NET", MessageBoxButtons.OK);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void RemoveFormattingToolStripButton_Click(object sender, EventArgs e)
        {
            this.oEdit.Remove_Formatting();
        }

        private void ForeColorToolStripButton_Click(object sender, EventArgs e)
        {
            string color = GetColor();

            if (color != null)
            {
                this.oEdit.Document.ExecCommand("ForeColor", false, color);
            }
        }

        private void HighlightColorToolStripButton_Click(object sender, EventArgs e)
        {
            string color = GetColor();

            if (color != null)
            {
                this.oEdit.Document.ExecCommand("BackColor", false, color);
            }

        }

        private string GetColor()
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                return "rgb(" + colorDialog.Color.R + "," + colorDialog.Color.G + "," + colorDialog.Color.B + ")";
            }
            else
            {
                return null;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            oEdit.SpellCheckDocument(true);
        }
    }
}
