using System;
using System.Windows.Forms;

namespace WinForms_Examples
{
    public partial class frmMain : Form
    {

        Zoople.HTMLEditControl oEdit;

        public frmMain()
        {

            InitializeComponent();

            oEdit = new Zoople.HTMLEditControl
            {
                Dock = DockStyle.Fill,
                DocumentHTML = "<h2>The simplest and most extensible Winforms HTML Editor.</h2><img align='right' src='https://zoople.tech/img/logo.png?1' /><p>Caters for all levels of end-user, from the most basic to people with advanced HTML knowledge.</p><p>Complete HTML DOM manipulation is achievable, simply and without the need for COM references</p>",
                ShowPropertyGrid = true,
                CSSText = "BODY {font-family: Arial Unicode MS, Arial, Sans-Serif; border: none;} .courierText {font-family: courier;} .BlueBackground {background-color: blue; }",
                LicenceKey = "YourLicenseKey",
                LicenceKeyInlineSpelling = "InlineSpellingLicenseKey",
                EnableInlineSpelling = false,
                CleanMSWordHTMLOnPaste = true,
                FontSizesList = "8pt;10pt;12pt;16pt;22pt;",
                HideDOMToolbar = false
            };

            Controls.Add(oEdit);

        }
    }
}
