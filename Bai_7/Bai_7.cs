using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7
{
    public partial class Bai_7 : Form
    {
        public Bai_7()
        {
            InitializeComponent();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                btnCapNhat.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = false;
            }
            if (e.Node.Level == 2)
            {
                btnXoa.Enabled = true;
            }
            else { btnXoa.Enabled = false; }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string hoten = txtHoTen.Text;
            string diachi = txtDiaChi.Text;
            if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Chưa điền đủ thông tin!");
            }
            else
            {
                TreeNode newchild = treeView1.SelectedNode.Nodes.Add(masv + "-" + hoten);
                newchild.Nodes.Add(diachi);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void Bai_7_Load(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
