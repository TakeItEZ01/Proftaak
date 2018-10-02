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

        }



        private void BtOrder_Click(object sender, EventArgs e) // shows order
        {
            CheckBox[] Extra = new CheckBox[10] {CbExtraHam, CbExtraSalami, CbExtraKip, CbExtraTomaat, CbExtraKaas, CbExtraKomKommer, CbExtraSla, CbExtraAugurk, CbExtraUi, CbExtraPeper };
            PictureBox[] Ingredients = new PictureBox[10] { PbHam, PbSalami, PbKip, PbTomaat, PbKaas, PbKomkommer, PbSla, PbAugurk, PbUi, PbPeper };
            for (int i = 0; i < 10; i++)   
            {
                if (Ingredients[i].Tag == "Clicked")
                {
                    MessageBox.Show(Ingredients[i].Name.ToString());
                }

               if (Extra[i].Checked == true && Ingredients[i].Tag == "Clicked")
               {
                    MessageBox.Show(Extra[i].Name.ToString());

               }

                if (Extra[i].Checked == true && Ingredients[i].Tag != "Clicked")
                {
                    Ingredients[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    MessageBox.Show(Ingredients[i].Name.ToString());
                    MessageBox.Show(Extra[i].Name.ToString());
                    Ingredients[i].Tag = "Clicked";
                }


            }
        }









        private void CbExtraKomkommer(object sender, EventArgs e) // ignore this
        {

        }
    }
}
