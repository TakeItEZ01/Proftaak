using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2_Tessa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PbHam_Click(object sender, EventArgs e)
        {

            

            PictureBox picture = (PictureBox)sender; // checks dice clicked
            if (picture.Tag != "Clicked")
            {
                picture.Tag = "Clicked";
                picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                picture.Tag = null;
                picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            }
        }

        private void BtOrder_Click(object sender, EventArgs e)
        {
        }
    }
}
