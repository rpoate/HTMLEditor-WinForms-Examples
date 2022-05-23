using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Example_3___Language_Localisation
{
    public partial class frmLanguage : Form
    {
        Zoople.HTMLEditControl oEdit;

        public frmLanguage()
        {

            InitializeComponent();

        }

        private void frmLanguage_Load(object sender, EventArgs e)
        {
            oEdit = new Zoople.HTMLEditControl
            {
                Dock = DockStyle.Fill,
                CSSText = "BODY {border: 0; font-family: Arial}",
                DocumentHTML = "<h1>Localisation</h2><p>The editor component is localisable into other languages via customisable XML files.</p><p>There are six language xml files included the installation package; French, Italian, Dutch, Spanish, German and English.</p>"
            };
            oEdit.ConfigurationError += oEdit_ConfigurationError;

            this.toolStripContainer1.ContentPanel.Controls.Add(oEdit);
        }

        private void oEdit_ConfigurationError(object sender, Zoople.ConfigurationErrorEventArgs e)
        {
            MessageBox.Show(e.ErrDesc, e.ErrSource);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.LanguageFile = "LanguageFiles\\english.xml";
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.LanguageFile = "LanguageFiles\\french.xml";
        }

        private void italianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.LanguageFile = "LanguageFiles\\italian.xml";
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.LanguageFile = "LanguageFiles\\german.xml";
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.LanguageFile = "LanguageFiles\\spanish.xml";
        }

        private void dutchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oEdit.LanguageFile = "LanguageFiles\\dutch.xml";
        }

        private void useAsViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (useAsViewerToolStripMenuItem.Text == "Use As Viewer") { 
                oEdit.EditingDisabled =  true;
                this.useAsViewerToolStripMenuItem.Text = "Use As Editor";
                oEdit.HideDOMToolbar = true;
                oEdit.HideMainToolbar = true;
            } 
            else
            {
                oEdit.EditingDisabled = false;
                this.useAsViewerToolStripMenuItem.Text = "Use As Viewer";
                oEdit.HideDOMToolbar = false;
                oEdit.HideMainToolbar = false;
            }

        }
    }
}
