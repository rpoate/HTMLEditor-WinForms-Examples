using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winforms_Example_09___Table_Properties_Dialog_CS
{
    public partial class frmTableProperties : Form
    {

        private bool m_Adding;
        public bool Cancelled = true;

        public frmTableProperties()
        {
            InitializeComponent();
        }

        public bool Adding
        {
            get
            {
                return m_Adding;
            }
            set
            {
                this.txtColumns.Enabled = value;
                this.txtRows.Enabled = value;
                m_Adding = value;
            }
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

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            Color oColor = GetColor();

            if (oColor != null/* TODO Change to default(_) if this is not a reference type */ )
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("#");
                sb.Append(BitConverter.ToString(new byte[] { oColor.R }));
                sb.Append(BitConverter.ToString(new byte[] { oColor.G }));
                sb.Append(BitConverter.ToString(new byte[] { oColor.B }));

                txtBorderColor.Text = sb.ToString();
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            Color oColor = GetColor();

            if (oColor != null/* TODO Change to default(_) if this is not a reference type */ )
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("#");
                sb.Append(BitConverter.ToString(new byte[] { oColor.R }));
                sb.Append(BitConverter.ToString(new byte[] { oColor.G }));
                sb.Append(BitConverter.ToString(new byte[] { oColor.B }));

                txtBackgroundColor.Text = sb.ToString();
            }
        }

        private Color GetColor()
        {
            ColorDialog oColorDialog = new ColorDialog();
            DialogResult oDialogResult;

            oDialogResult = oColorDialog.ShowDialog(this);

            if (oDialogResult == DialogResult.OK)
                return oColorDialog.Color;
            else
                return Color.Empty/* TODO Change to default(_) if this is not a reference type */;
        }

        private void chkApplyCellProperties_CheckedChanged(object sender, EventArgs e)
        {
            grpCellProperties.Enabled = this.chkApplyCellProperties.Checked;
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

        private void cboBorderWidth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
