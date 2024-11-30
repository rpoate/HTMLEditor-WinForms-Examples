
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
using Zoople;

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
                DocumentHTML = "<img align='right' src='images/anna2.jpg' style='width: 200px;'/><h2>Saving as an Email with inline images.</h2><p>This example shows how to save an eml file containing inline (embedded) images</p>",
                ShowPropertyGrid = false,
                CSSText = "BODY {font-family: Arial Unicode MS, Arial, Sans-Serif;}",
                LicenceKey = "YourLicenseKey",
                LicenceKeyInlineSpelling = "YourInlineSpellingLicenseKey",
                EnableInlineSpelling = true,
                BaseURL = Application.StartupPath.Replace("\\", "/"),
                UseRelativeURLs = true,
                ImageStorageLocation = Path.Combine(Application.StartupPath, "images")
            };

            Controls.Add(oEdit);

            var oButton = oEdit.ToolStripItems.Add("Save As Email");
            oButton.Click += AsEmail_Click;
            oButton.Padding = new Padding(3);

            var oButtonSpell = oEdit.ToolStripItems.Add("Check Spelling");
            oButtonSpell.Click += OButtonSpell_Click;
            oButtonSpell.Padding = new Padding(3);

        }

        private void OButtonSpell_Click(object sender, EventArgs e)
        {
            oEdit.SpellCheckDocument(true);
        }

        private void AsEmail_Click(object sender, EventArgs e)
        {

            HtmlDocument oMailDoc;

            if (oEdit.DocumentClone != null)
            {
                oMailDoc = oEdit.DocumentClone;
            }
            else
            {
                MessageBox.Show("Error - Document not initialized", "HTML Editor Example");
                return;
            }

            MailMessage newMail = new MailMessage();
            newMail.To.Add(new MailAddress("you@your.address"));
            newMail.From = (new MailAddress("someone@their.address"));
            newMail.Subject = "Test Subject";
            newMail.IsBodyHtml = true;

            List<LinkedResource> inlineLogoList = new List<LinkedResource>();

            foreach (HtmlElement oImage in oMailDoc.GetElementsByTagName("img"))
            {
                Uri oUri = new Uri(oImage.GetAttribute("src"));
                if (oUri.IsFile)
                {
                    var inlineLogo = new LinkedResource(oUri.LocalPath, "image/" + new FileInfo(oUri.LocalPath).Extension.Substring(1))
                    {
                        ContentId = Guid.NewGuid().ToString()
                    };
                    oImage.SetAttribute("src", "cid:" + inlineLogo.ContentId);

                    if (GetElementInlineStyleValue(oImage, "width") != "")
                        oImage.SetAttribute("width", GetElementInlineStyleValue(oImage, "width").Replace("px", ""));
                    else if (oImage.GetAttribute("width") != "0")
                        oImage.Style = ChangeElementStyle(oImage, "width", oImage.GetAttribute("width").Contains("px") ? 
                            oImage.GetAttribute("width") : oImage.GetAttribute("width") + "px");

                    if (GetElementInlineStyleValue(oImage, "height") != "")
                        oImage.SetAttribute("height", GetElementInlineStyleValue(oImage, "height").Replace("px", ""));
                    else if (oImage.GetAttribute("height") != "0")
                        oImage.Style = ChangeElementStyle(oImage, "height", oImage.GetAttribute("height").Contains("px") ? 
                            oImage.GetAttribute("height") : oImage.GetAttribute("height") + "px");

                    inlineLogoList.Add(inlineLogo);
                }
            }

            var view = AlternateView.CreateAlternateViewFromString(oMailDoc.Body.OuterHtml, null, "text/html");

            foreach (LinkedResource inlineLogo in inlineLogoList)
            {
                view.LinkedResources.Add(inlineLogo);
            }

            newMail.AlternateViews.Add(view);

            var view2 = AlternateView.CreateAlternateViewFromString(oMailDoc.Body.InnerText, Encoding.ASCII, "text/plain");
            newMail.AlternateViews.Add(view2);

            SmtpClient client = new SmtpClient("mysmtphost")
            {
                DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                PickupDirectoryLocation = Application.StartupPath + "/SMTPPickupFolder"
            };
            client.Send(newMail);

            MessageBox.Show("Successfully saved to \r\n\r\n " + Application.StartupPath + "/SMTPPickupFolder");

        }

        public string ChangeElementStyle(HtmlElement Element, string Attribute, string Value)
        {
            try
            {
                if (Value == null || Value == "")
                    return RemoveElementStyle(Element.Style, Attribute);
                else
                    return UpdateElementStyle(Element.Style, Attribute, Value);
            }
            catch
            {
                return Element.Style;
            }
        }

        private string RemoveElementStyle(string CurrentStyle, string Attribute)
        {
            string[] AllAttributes = new string[0];
            string NewStyle = "";

            if (CurrentStyle != null)
                AllAttributes = CurrentStyle.Split(char.Parse(";"));

            try
            {
                foreach (string FullAttribute in AllAttributes)
                {
                    if (FullAttribute != null && FullAttribute.Trim() != "")
                    {
                        if (FullAttribute.Substring(0, FullAttribute.IndexOf(":")).ToLower().Trim() != Attribute.ToLower().Trim())
                            NewStyle += FullAttribute + "; ";
                    }
                }
                return NewStyle;
            }
            catch
            {
                return "";
            }
        }


        private string UpdateElementStyle(string CurrentStyle, string Attribute, string Value)
        {
            string[] AllAttributes = new string[1];
            string NewStyle = "";
            bool FoundAttribute = false;

            if (CurrentStyle != null)
                AllAttributes = CurrentStyle.Split(char.Parse(";"));

            try
            {
                foreach (string FullAttribute in AllAttributes)
                {
                    if (FullAttribute != null && FullAttribute.Trim() != "")
                    {
                        if (FullAttribute.Substring(0, FullAttribute.IndexOf(":")).ToLower().Trim() == Attribute.ToLower().Trim())
                        {
                            NewStyle += FullAttribute.Substring(0, (FullAttribute.IndexOf(":")) + 1) + ": " + Value + "; ";
                            FoundAttribute = true;
                        }
                        else
                            NewStyle += FullAttribute + "; ";
                    }
                }

                if (!FoundAttribute)
                    NewStyle += Attribute + ": " + Value + "; ";

                return NewStyle;
            }
            catch
            {
                return "";
            }
        }

        public string GetElementInlineStyleValue(HtmlElement Element, string Attribute)
        {
            string CurrentStyle;
            string value = "";

            try
            {
                CurrentStyle = Element.Style;

                if (CurrentStyle != null)
                {
                    if (!CurrentStyle.Trim().EndsWith(";"))
                        CurrentStyle += ";";

                    string[] AllAttributes = CurrentStyle.Split(char.Parse(";"));

                    foreach (string FullAttribute in AllAttributes)
                    {
                        if (FullAttribute != null && FullAttribute.Trim() != "")
                        {
                            if (FullAttribute.Substring(0, FullAttribute.IndexOf(":")).ToLower().Trim() == Attribute.Trim().ToLower())
                            {
                                value = FullAttribute.Substring(FullAttribute.IndexOf(":") + 1).Trim();
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
            }

            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
