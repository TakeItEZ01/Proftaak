using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programma_TESSA
{
    public partial class TESSA : Form
    {
        public TESSA()
        {
            InitializeComponent();
        }
        bool HamSelect = false;
        private void Ham_Click(object sender, EventArgs e)
        {
            bool HamSelect = true;
        }
    }
}
