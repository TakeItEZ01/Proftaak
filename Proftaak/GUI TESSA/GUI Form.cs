using System;
using System.Windows.Forms;

namespace GUI_TESSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool HamSelect = false;
        private void PbHam_Click(object sender, EventArgs e)
        {
            if (HamSelect == true)
            {
                HamSelect = false;
            }
            else
            {
                HamSelect = true;
            }
        }
        bool KomkommerSelect = false;
        private void PbKomkommer_Click(object sender, EventArgs e)
        {
            if (KomkommerSelect == true)
            {
                KomkommerSelect = false;
            }
            else
            {
                KomkommerSelect = true;
            }
        }
    }
}
