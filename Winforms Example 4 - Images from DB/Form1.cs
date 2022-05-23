using System;
using System.IO;
using System.Windows.Forms;

namespace Winforms_Example_4___Images_from_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            ToolStripItem oB = htmlEditControl1.ToolStripItems.Add("Insert Car Image 1");
            oB.Click += CarImage1Click;
            oB.Padding = new Padding(3);

            ToolStripItem oB2 = htmlEditControl1.ToolStripItems.Add("Insert Car Image 2");
            oB2.Click += CarImage2Click;
            oB2.Padding = new Padding(3);

            ToolStripItem oB3 = htmlEditControl1.ToolStripItems.Add("Iterate Images");
            oB3.Click += OB3_Click;
            oB3.Padding = new Padding(3);

            ToolStripItem oB4 = htmlEditControl1.ToolStripItems.Add("Embed Image from file system");
            oB4.Click += OB4_Click;
            oB4.Padding = new Padding(3);

            htmlEditControl1.CSSText = "Body {font-family: Arial}";
            htmlEditControl1.DocumentHTML = "<h2>Embedded images as Data URI.</h2><p>Images may be embedded as a base 64 string using the following notation:</p><p><font color=\"#0040c0\">&lt;img src=\"data:[&lt;mime type=\"\"&gt;][;charset=&lt;charset&gt;][;base64],&lt;encoded data&gt;\" /&gt;</font></p><p>To encode an image on disc use the following;</p><blockquote style=\"margin-right: 0px;\" dir=\"ltr\"><p><font color=\"#00c040\" face=\"Courier New\">private string Base64fromImage(string ImagePath)<br>{<br>&nbsp; byte[] AllBytes = File.ReadAllBytes(ImagePath);<br>&nbsp; return Convert.ToBase64String(AllBytes);<br>}</font></p></blockquote><p>Please click \"Insert Car Image 1\" and \"Insert Car Image 2\" to insert an embedded image.</p><p>You may also drag and drop files from the local file system and embed them as Base64 data.</p>";

        }

        private void OB4_Click(object sender, EventArgs e)
        {

            string filePath;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|gif files (*.gif)|*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    if (new FileInfo(filePath).Length > 131072)
                    {
                        MessageBox.Show("This demo limits file sizes to those below 128Kb. It is not recommended to embed files larger than 32K. Please select another file.");
                        return;
                    }

                    htmlEditControl1.InsertHTMLElement("img").SetAttribute("src", "data:image/" + new FileInfo(filePath).Extension.Remove(0,1) + ";base64," + Base64fromImage(filePath));
                }
            }
        }

        private void OB3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(htmlEditControl1.Document.Images.Count.ToString() + " Images in the HTML");
        }

        private void CarImage1Click(object sender, EventArgs e)
        {
            htmlEditControl1.InsertHTMLElement("img").SetAttribute("src", "data:image/" + GetMediaType("images\\car1.jpg") + ";base64," + Base64fromImage("images\\car1.jpg"));
        }

        private void CarImage2Click(object sender, EventArgs e)
        {
            htmlEditControl1.InsertHTMLElement("img").SetAttribute("src", "data:image/" + GetMediaType("images\\car1.jpg") + ";base64," + Base64fromImage("images\\car2.jpg"));
        }

        private string Base64fromImage(string ImagePath)
        {
            byte[] AllBytes = File.ReadAllBytes(ImagePath);
            return Convert.ToBase64String(AllBytes);
        }

        private string GetMediaType(string ImagePath)
        {
            string retVal;

            switch (Path.GetExtension(ImagePath))
            {
                case "jpg": 
                case "jpeg":
                    retVal= "jpeg";
                    break;
                case "png":
                    retVal= "png";
                    break;
                case "gif":
                    retVal = "gif";
                    break;
                default:
                    retVal= "jpeg";
                    break;
            }

            return retVal;

        }

        private void htmlEditControl1_CancellableUserInteraction(object sender, Zoople.CancellableUserInteractionEventsArgs e)
        {

            if (e.InteractionType == "onexternaldrop")
            {
                if (e.OtherInfo.ToString() != "")
                {
                    try
                    {
                        Uri oURI = new Uri(e.OtherInfo.ToString());

                        if (oURI.IsFile)
                        {
                            FileInfo oFile = new FileInfo(oURI.LocalPath);

                            if (".jpg.gif.png.jpeg".Contains(oFile.Extension))
                            {
                                e.Cancel = true;
                                htmlEditControl1.InsertHTMLElement("img").SetAttribute("src", "data:image/jpeg;base64," + Base64fromImage(oURI.LocalPath));
                            }
                        }
                    }
                    catch
                    {
                        e.Cancel = false;
                    }
                }
            }
        }
    }
}
