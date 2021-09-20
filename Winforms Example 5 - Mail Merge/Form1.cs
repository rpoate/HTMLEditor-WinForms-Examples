using System;
using System.Windows.Forms;

namespace Winforms_Example_4___Mail_Merge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripItem InsertFieldButton = this.htmlEditControl1.ToolStripItems.Add("Insert Field");
            InsertFieldButton.Click += InsertFieldButton_Click;
            InsertFieldButton.Padding = new Padding(2);
            InsertFieldButton.Margin = new Padding(2);

            ToolStripComboBox FieldCombo = new ToolStripComboBox("FieldCombo");
            FieldCombo.Items.Add("Salutation");
            FieldCombo.Items.Add("Company");
            FieldCombo.Items.Add("Email");
            FieldCombo.Padding = new Padding(1);
            FieldCombo.Margin = new Padding(2);
            FieldCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            this.htmlEditControl1.ToolStripItems.Add(FieldCombo);

            ToolStripItem PerformMergeButton = this.htmlEditControl1.ToolStripItems.Add("Perform Merge");
            PerformMergeButton.Click += PerformMergeButton_Click;
            PerformMergeButton.Padding = new Padding(2);
            PerformMergeButton.Margin = new Padding(2);

            this.htmlEditControl1.CSSText = "body {font-family: arial}";
            this.htmlEditControl2.CSSText = "body {font-family: arial}";

            this.htmlEditControl1.DocumentHTML = "<p>Dear <a data-merge=\"Salutation\" href=\"#\">Salutation</a>,</p><p>Please find a quote for <a data-merge=\"Company\" href=\"#\">Company</a>&nbsp;attached</p><p>Our records show that your email address is registered as <a data-merge=\"Email\" href=\"#\">Email</a></p><p>regards</p><p><strong>Some Other Company</strong></p>";

            this.htmlEditControl1.Focus();

        }

        private void PerformMergeButton_Click(object sender, EventArgs e)
        {

            htmlEditControl2.DocumentHTML = htmlEditControl1.DocumentHTML;

            foreach (HtmlElement link in htmlEditControl2.Document.Links)
            {
                switch (link.GetAttribute("data-merge"))
                {
                    case "Salutation":
                        link.OuterText = "Mr. Smith";
                        break;
                    case "Company":
                        link.OuterText = "Smith and Co.";
                        break;
                    case "Email":
                        link.InnerText = "smith@smithandco.com";
                        link.SetAttribute("href", "mailto:smith@smithandco.com");
                        break;
                }
            }
        }

        private void InsertFieldButton_Click(object sender, EventArgs e)
        {
            if (((ToolStripComboBox)this.htmlEditControl1.ToolStripItems["FieldCombo"]).SelectedItem != null)
                this.htmlEditControl1.InsertAtCursor("<a data-merge=\"" + ((ToolStripComboBox)this.htmlEditControl1.ToolStripItems["FieldCombo"]).SelectedItem.ToString() +
                    "\" href=\"#\">" + ((ToolStripComboBox)this.htmlEditControl1.ToolStripItems["FieldCombo"]).SelectedItem.ToString() + "</a>", Zoople.HTMLEditControl.ed_InsertType.ed_InsertReplaceSelection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
