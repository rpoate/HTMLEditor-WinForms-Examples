using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Winforms_Example_09___Table_Properties_Dialog_CS
{
    public partial class Form1 : Form
    {

        private ToolStripItem btnTableProperties;
        private ToolStripItem btnCellProperties;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTableProperties = this.htmlEditControl1.ToolStripItems.Add("Table Properties");
            btnTableProperties.Padding = new Padding(2);
            btnTableProperties.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnTableProperties.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            btnTableProperties.Enabled = false;
            btnTableProperties.Click += btnTableProperties_Click;

            btnCellProperties = this.htmlEditControl1.ToolStripItems.Add("Cell Properties");
            btnCellProperties.Padding = new Padding(2);
            btnCellProperties.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCellProperties.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            btnCellProperties.Enabled = false;
            btnCellProperties.Click += btnCellProperties_Click;

            this.htmlEditControl1.CSSText = "table {border-collapse: separate !important; } body {font-family: Arial}";
            this.htmlEditControl1.DocumentHTML = "<p>In this example the editor has had two custom buttons added to it's menu bar; a table properties and individual cell properties button. They are only enabled if the user clicks into a table cell. </p><table style='width: 100%;'><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr></table><p></p>";

        }

        private void btnCellProperties_Click(object sender, EventArgs e)
        {
            HtmlElement oTD = FindTDElement(this.htmlEditControl1.CurrentWindowsFormsElement);
            frmCellProperties oFrmTD = new frmCellProperties();
            Dictionary<string, string> oDict = new Dictionary<string, string>();
            InlineCssParser oCellCSS;

            oCellCSS = new InlineCssParser(oTD.Style);

            if (oCellCSS.HasName("background-color"))
                oFrmTD.txtCellBackgroundColor.Text = oCellCSS.GetValue("background-color");

            if (oCellCSS.HasName("border-color"))
                oFrmTD.txtCellBorderColor.Text = oCellCSS.GetValue("border-color");

            if (oCellCSS.HasName("border-width"))
                oFrmTD.cboCellBorderWidth.SelectedItem = oCellCSS.GetValue("border-width");

            if (oCellCSS.HasName("border-style"))
                oFrmTD.cboCellBorderStyle.SelectedItem = oCellCSS.GetValue("border-style");



            oFrmTD.ShowDialog(this);

            if (!oFrmTD.Cancelled)
            {
                if (oFrmTD.txtCellBackgroundColor.Text != "")
                    oCellCSS.SetValue("background-color", oFrmTD.txtCellBackgroundColor.Text);
                if (oFrmTD.txtCellBorderColor.Text != "")
                    oCellCSS.SetValue("border-color", oFrmTD.txtCellBorderColor.Text);

                if (oFrmTD.cboCellBorderWidth.SelectedItem != null)
                    oCellCSS.SetValue("border-width", oFrmTD.cboCellBorderWidth.SelectedItem.ToString());
                if (oFrmTD.cboCellBorderStyle.SelectedItem != null)
                    oCellCSS.SetValue("border-style", oFrmTD.cboCellBorderStyle.SelectedItem.ToString());

                oTD.Style = oCellCSS.InlineCss;
            }

            oFrmTD.Close();
        }

        private void btnTableProperties_Click(object sender, EventArgs e)
        {
            HtmlElement oTable = FindTableElement(this.htmlEditControl1.CurrentWindowsFormsElement);
            frmTableProperties oFrmTable = new frmTableProperties();
            Dictionary<string, string> oDict = new Dictionary<string, string>();
            InlineCssParser oTableCSS;
            InlineCssParser oCellCSS;

            oFrmTable.Adding = oTable == null;

            if (!oFrmTable.Adding)
            {
                try
                {
                    oFrmTable.txtRows.Text = oTable.GetElementsByTagName("TR").Count.ToString();
                    oFrmTable.txtColumns.Text = oTable.GetElementsByTagName("TR")[0].GetElementsByTagName("TD").Count.ToString();
                }
                catch
                {
                    MessageBox.Show("Table element has no rows or first row has no coloumns.");
                    return;
                }

                oTableCSS = new InlineCssParser(oTable.Style);

                if (oTableCSS.HasName("background-color"))
                    oFrmTable.txtBackgroundColor.Text = oTableCSS.GetValue("background-color");

                if (oTableCSS.HasName("border-color"))
                    oFrmTable.txtBorderColor.Text = oTableCSS.GetValue("border-color");

                if (oTableCSS.HasName("border-width"))
                    oFrmTable.cboBorderWidth.SelectedItem = oTableCSS.GetValue("border-width");

                if (oTableCSS.HasName("border-style"))
                    oFrmTable.cboBorderStyle.SelectedItem = oTableCSS.GetValue("border-style");
            }
            else
                oTableCSS = new InlineCssParser(null);

            oFrmTable.ShowDialog(this);

            if (!oFrmTable.Cancelled)
            {
                oTableCSS.SetValue("background-color", oFrmTable.txtBackgroundColor.Text);
                oTableCSS.SetValue("border-color", oFrmTable.txtBorderColor.Text);

                if (oFrmTable.cboBorderWidth.SelectedItem != null)
                    oTableCSS.SetValue("border-width", oFrmTable.cboBorderWidth.SelectedItem.ToString());
                if (oFrmTable.cboBorderStyle.SelectedItem != null)
                    oTableCSS.SetValue("border-style", oFrmTable.cboBorderStyle.SelectedItem.ToString());

                oTable.Style = oTableCSS.InlineCss;

                if (oFrmTable.chkApplyCellProperties.Checked)
                {
                    oCellCSS = new InlineCssParser("");

                    oCellCSS.SetValue("background-color", oFrmTable.txtCellBackgroundColor.Text);
                    oCellCSS.SetValue("border-color", oFrmTable.txtCellBorderColor.Text);
                    if (oFrmTable.cboCellBorderWidth.SelectedItem != null)
                        oCellCSS.SetValue("border-width", oFrmTable.cboCellBorderWidth.SelectedItem.ToString());
                    if (oFrmTable.cboCellBorderStyle.SelectedItem != null)
                        oCellCSS.SetValue("border-style", oFrmTable.cboCellBorderStyle.SelectedItem.ToString());

                    foreach (HtmlElement oRow in oTable.GetElementsByTagName("TR"))
                    {
                        foreach (HtmlElement oCell in oRow.GetElementsByTagName("TD"))
                            oCell.Style = oCellCSS.InlineCss;
                    }
                }
            }

            oFrmTable.Close();
        }

        private void htmlEditControl1_UserInteraction(object sender, Zoople.UserInteractionEventsArgs e)
        {
            btnTableProperties.Enabled = FindTableElement(this.htmlEditControl1.CurrentWindowsFormsElement) != null;
            btnCellProperties.Enabled = FindTDElement(this.htmlEditControl1.CurrentWindowsFormsElement) != null;
        }

        private HtmlElement FindTableElement(HtmlElement element)
        {
            if (element == null)
                return null;
            if (element.TagName.ToLowerInvariant() == "html")
                return null;

            if (element.TagName.ToLower() == "table")
                return element;
            else
                return FindTableElement(element.Parent);
        }

        private HtmlElement FindTDElement(HtmlElement element)
        {
            if (element == null)
                return null;
            if (element.TagName.ToLowerInvariant() == "html")
                return null;

            if (element.TagName.ToLower() == "td")
                return element;
            else
                return FindTDElement(element.Parent);
        }

    }
}
