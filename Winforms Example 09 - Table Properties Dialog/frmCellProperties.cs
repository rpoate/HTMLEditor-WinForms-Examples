using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winforms_Example_09___Table_Properties_Dialog_CS
{
    public partial class frmCellProperties : Form
    {
        public bool Cancelled = true;

        public frmCellProperties()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cancelled = false;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            this.Hide();
        }

        private Color GetColor()
        {
            ColorDialog oColorDialog = new ColorDialog();
            DialogResult oDialogResult;

            oDialogResult = oColorDialog.ShowDialog(this);

            if (oDialogResult == DialogResult.OK)
                return oColorDialog.Color;
            else
                return Color.Empty;
        }

        private void btnCellBorderColor_Click(object sender, EventArgs e)
        {
            Color oColor = GetColor();

            if (oColor != null/* TODO Change to default(_) if this is not a reference type */ )
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("#");
                sb.Append(BitConverter.ToString(new byte[] { oColor.R }));
                sb.Append(BitConverter.ToString(new byte[] { oColor.G }));
                sb.Append(BitConverter.ToString(new byte[] { oColor.B }));

                txtCellBorderColor.Text = sb.ToString();
            }
        }

        private void btnCellBackgroundColor_Click(object sender, EventArgs e)
        {
            Color oColor = GetColor();

            if (oColor != null/* TODO Change to default(_) if this is not a reference type */ )
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("#");
                sb.Append(BitConverter.ToString(new byte[] { oColor.R }));
                sb.Append(BitConverter.ToString(new byte[] { oColor.G }));
                sb.Append(BitConverter.ToString(new byte[] { oColor.B }));

                txtCellBackgroundColor.Text = sb.ToString();
            }
        }
    }
}
