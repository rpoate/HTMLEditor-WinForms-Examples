
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Example_11___Email_Message
{
    public partial class Form1 : Form
    {

        Zoople.HTMLEditControl oEdit;

        public Form1()
        {
            InitializeComponent();

            oEdit = new Zoople.HTMLEditControl
            {
                Dock = DockStyle.Fill,
                DocumentHTML = "<img align='right' src='images/anna2.jpg' width='200px'/><h2>Saving as an Email with inline images.</h2><p>This example shows how to save an eml file containing inline (embedded) images</p>",
                ShowPropertyGrid = false,
                CSSText = "BODY {font-family: Arial Unicode MS, Arial, Sans-Serif;}",
                LicenceKey = "YourLicenseKey",
                LicenceKeyInlineSpelling = "YourInlineSpellingLicenseKey",
                EnableInlineSpelling = true,
                BaseURL = Application.StartupPath.Replace("\\", "/"),
                UseRelativeURLs = true,
                ImageStorageLocation = Path.Combine( Application.StartupPath , "images")
            };

            Controls.Add(oEdit);

            var oButton = oEdit.ToolStripItems.Add("Save As Email");
            oButton.Click += AsEmail_Click;
            oButton.Padding = new Padding(3);

            var oButtonSpell = oEdit.ToolStripItems.Add("Check Spelling");
            oButtonSpell.Click += OButtonSpell_Click;
            oButtonSpell.Padding = new Padding(3);

            oEdit.SpellCheckComplete += OEdit_SpellCheckComplete;
        }

        private void OEdit_SpellCheckComplete(object sender, EventArgs e)
        {
            MessageBox.Show("Spelling Check Completed");
        }

        private void OButtonSpell_Click(object sender, EventArgs e)
        {
            oEdit.SpellCheckDocument(true);
        }

        private void AsEmail_Click(object sender, EventArgs e)
        {

            string EditorHTML = oEdit.DocumentHTML;

            MailMessage newMail = new MailMessage();
            newMail.To.Add(new MailAddress("you@your.address"));
            newMail.From = (new MailAddress("someone@their.address"));
            newMail.Subject = "Test Subject";
            newMail.IsBodyHtml = true;

            List<LinkedResource> inlineLogoList = new List<LinkedResource>();

            foreach (HtmlElement oImage in oEdit.GetItemsByTagName("img"))
            {
                Uri oUri = new Uri(oImage.GetAttribute("src"));
                if (oUri.IsFile)
                {
                    var inlineLogo = new LinkedResource(oUri.LocalPath, "image/" + new FileInfo(oUri.LocalPath).Extension.Substring(1))
                    {
                        ContentId = Guid.NewGuid().ToString()
                    };
                    oImage.SetAttribute("src", "cid:" + inlineLogo.ContentId);
                    inlineLogoList.Add(inlineLogo);
                }
            }
             
            var view = AlternateView.CreateAlternateViewFromString(oEdit.Document.Body.OuterHtml, null, "text/html");

            foreach (LinkedResource inlineLogo in inlineLogoList)
            {
                view.LinkedResources.Add(inlineLogo);
            }

            newMail.AlternateViews.Add(view);

            var view2 = AlternateView.CreateAlternateViewFromString(oEdit.Document.Body.InnerText, Encoding.ASCII, "text/plain");
            newMail.AlternateViews.Add(view2);

            SmtpClient client = new SmtpClient("mysmtphost")
            {
                DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                PickupDirectoryLocation = Application.StartupPath + "/SMTPPickupFolder"
            };
            client.Send(newMail);

            oEdit.DocumentHTML = EditorHTML;

            MessageBox.Show("Successfully saved to \r\n\r\n " + Application.StartupPath + "/SMTPPickupFolder");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
