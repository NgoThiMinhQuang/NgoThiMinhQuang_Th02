using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class FrmBai2_2 : Form
    {
        public FrmBai2_2()
        {
            InitializeComponent();
        }

        private void radVietNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radVietNam.Checked)
            {
                pictureBox1.Image = Properties.Resources.VN;
            }
        }

        private void radUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (radUSA.Checked)
            {
                pictureBox1.Image = Properties.Resources.USA;
            }
        }

        private void radItalian_CheckedChanged(object sender, EventArgs e)
        {
            if (radItalian.Checked)
            {
                pictureBox1.Image = Properties.Resources.Italian;
            }
        }

        private void radPhilippin_CheckedChanged(object sender, EventArgs e)
        {
            if (radPhilippin.Checked)
            {
                pictureBox1.Image = Properties.Resources.Philippine;
            }
        }

        private void FrmBai2_2_Load(object sender, EventArgs e)
        {
            radVietNam.Checked = true;
        }
    }
}
