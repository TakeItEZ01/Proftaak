using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    } 
}
