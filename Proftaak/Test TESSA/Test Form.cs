using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_TESSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


        bool ham = false;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (ham == true)
            {
                ham = false;
                MessageBox.Show("ham is niet meer geselcteerd");
            }

            else
            {
                ham = true;
                MessageBox.Show("ham is geselcteerd");
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {


        }
    }
}
