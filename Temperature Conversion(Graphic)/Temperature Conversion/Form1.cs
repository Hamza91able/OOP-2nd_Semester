using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Conversion
{
    public partial class MainWind : Form
    {
        float fer = 0, cen = 0;
        public MainWind()
        {
            InitializeComponent();
        }

        private void MainWind_Load(object sender, EventArgs e)
        {
            CtoF.Checked = true;
        }

        private void CtoF_CheckedChanged(object sender, EventArgs e)
        {
            if (CtoF.Checked == true)
            {
                CtextBox.Enabled = true;
                FtextBox.Enabled = false;
            }
        }

        private void FtoC_CheckedChanged(object sender, EventArgs e)
        {
            if (FtoC.Checked == true)
            {
                CtextBox.Enabled = false;
                FtextBox.Enabled = true;
            }
        }

        private void CtextBox_TextChanged(object sender, EventArgs e)
        {
            if (CtextBox.Text != "" && CtoF.Checked == true)
            {
                cen = float.Parse(CtextBox.Text);
                fer = (cen * 9) / 5 + 32;
                FtextBox.Text = fer.ToString();
            }
            if (CtextBox.Text=="")
            {
                FtextBox.Text = "";
            }
        }

        private void FtextBox_TextChanged(object sender, EventArgs e)
        {
            if (FtextBox.Text !="" && FtoC.Checked==true)
            {
                fer = float.Parse(FtextBox.Text);
                cen = (fer - 32) * 5 / 9;
                CtextBox.Text = cen.ToString();
            }
            if (FtextBox.Text=="")
            {
                CtextBox.Text = "";
            }
        }
    }
}
