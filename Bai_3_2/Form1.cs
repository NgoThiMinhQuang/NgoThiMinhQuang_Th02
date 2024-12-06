using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Masv = txtMaSV.Text;
            string Hoten = txtHoTen.Text;
            string Diachi = txtDiaChi.Text;
            string Ngaysinh = dtpNgaySinh.Value.ToShortDateString();
            string Lop = cboLop.Text;
            ListViewItem items = new ListViewItem();
            items.Text = Masv;
            items.SubItems.Add(Hoten);
            items.SubItems.Add(Diachi);
            items.SubItems.Add(Ngaysinh);
            items.SubItems.Add(Lop);
            items.ImageKey = "user.png";
            lvData.Items.Add(items);
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cboLop.Text = "";
        }

        private void lvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count == 1)
            {
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                txtMaSV.Text = lvData.SelectedItems[0].Text;
                txtHoTen.Text = lvData.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = lvData.SelectedItems[0].SubItems[2].Text;
                dtpNgaySinh.Text = lvData.SelectedItems[0].SubItems[3].Text;
                cboLop.Text = lvData.SelectedItems[0].SubItems[4].Text;
            }
            else if (lvData.SelectedItems.Count > 1)
            {
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvData.SelectedItems)
            {
                lvData.Items.Remove(item);
            }
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cboLop.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var selectItem = lvData.SelectedItems[0];
            selectItem.Text = txtMaSV.Text;
            selectItem.SubItems[1].Text = txtHoTen.Text;
            selectItem.SubItems[2].Text = txtDiaChi.Text;
            selectItem.SubItems[3].Text = dtpNgaySinh.Value.ToShortDateString();
            selectItem.SubItems[4].Text = cboLop.Text;

            MessageBox.Show("Cập nhật thành công", "Thông báo");
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cboLop.Text = "";
            lvData.SelectedItems.Clear();
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lartgeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvData.View = View.LargeIcon;
            ViewFomat();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        public void ViewFomat()
        {
            
        }
        private void Bai3_Load(object sender, EventArgs e)
        {
           

        }
    }
}
