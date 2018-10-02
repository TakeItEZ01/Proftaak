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

   


        bool Ham = false;
        bool Kaas = false;
        bool Sla = false;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (Ham == true)
            {
                Ham = false;
            }

            else
            {
                Ham = true;
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
        if (Sla == true)
            {
            Sla = false;
            }
        else
           {
            Sla = true;
           }

        }

     private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

   private void buttonTest_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

     