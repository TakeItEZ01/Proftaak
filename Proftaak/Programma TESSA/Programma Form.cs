﻿using System;
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
