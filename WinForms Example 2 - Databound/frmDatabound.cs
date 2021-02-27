using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Example_2___Databound
{


    public partial class frmDatabound : Form
    {

        public frmDatabound()
        {
            InitializeComponent();
        }

        private void frmDatabound_Load(object sender, EventArgs e)
        {
            this.htmlEditControl1.CSSText = "BODY {font-family: Arial;} .greenbackground {background-color: green;}";

            this.dataSet1.DataTable1.Rows.Add(1, "<h1>This is record 1</h1><p>Enter your text</p>");
            this.dataSet1.DataTable1.Rows.Add(2, "<h1>This is record 2</h1><p>Enter your text</p>");
            this.dataSet1.DataTable1.Rows.Add(3, "<img align=right  src='https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png' /><h1>This is record 3</h1><p>Enter your text</p>");
        }
    }
}
