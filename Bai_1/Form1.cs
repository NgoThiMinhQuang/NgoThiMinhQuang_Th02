﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class FrmBai2_1 : Form
    {
        public FrmBai2_1()
        {
            InitializeComponent();
        }
        int i = 20;

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = i.ToString();
            i--;
            if ( i < 0)
            {
                timer1.Enabled = false;
                lblDongHo.Text = "Hết giờ!";
            }    
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
