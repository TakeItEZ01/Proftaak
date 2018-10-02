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

            

            PictureBox picture = (PictureBox)sender; // change border and tag if picture is clicked
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





        private void CbExtraSalami_CheckedChanged(object sender, EventArgs e) // checks if extra is checked
        {
            CheckBox CBextra = (CheckBox)sender;

            if (CBextra.Tag != "Checked")
            {
                CBextra.Tag = "Checked";
            }

            else
            {
                CBextra.Tag = null;
            }
        }


        
        private void BtOrder_Click(object sender, EventArgs e) // shows order
        {

            PictureBox[] ingredients = new PictureBox[10] { PbHam, PbSalami, PbKip, PbTomaat, PbKaas, PbKomkommer, PbSla, PbAugurk, PbUi, PbPeper };
            for (int i = 0; i < 10; i++)
            {
                if (ingredients[i].Tag == "Clicked")
                {
                    MessageBox.Show(ingredients[i].Name.ToString());
                }
            }
        }

    }
}
