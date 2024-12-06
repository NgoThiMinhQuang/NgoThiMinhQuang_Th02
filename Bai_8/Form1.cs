using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void TongTien()
        {
            int TongTien = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                TongTien += int.Parse(item.SubItems[4].Text);
            }
            txtTongTien.Text = TongTien.ToString();
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;
            string KhuVuc = cboKhuVuc.Text;
            string DinhMuc = txtDinhMuc.Text;
            string SoCuText = txtSoCu.Text;
            string SoMoiText = txtSoMoi.Text;
            int SoCu;
            int SoMoi;
            if (string.IsNullOrEmpty(HoTen) || string.IsNullOrEmpty(KhuVuc) || !int.TryParse(SoCuText, out SoCu) || !int.TryParse(SoMoiText, out SoMoi) || (SoCu - SoMoi) > 0)
            {
                MessageBox.Show("Dữ liệu ko hợp lệ!");
                return;
            }
            else
            {
                int SoDien = (SoMoi - SoCu);
                txtTieuThu.Text = SoDien.ToString();
                if (SoDien > int.Parse(DinhMuc))
                {
                    txtThanhTien.Text = (SoDien * 1000).ToString();
                }
                else
                    txtThanhTien.Text = (SoDien * 500).ToString();
                ListViewItem item = new ListViewItem(HoTen);
                item.SubItems.Add(KhuVuc);
                item.SubItems.Add(DinhMuc);
                item.SubItems.Add(txtTieuThu.Text);
                item.SubItems.Add(txtThanhTien.Text);
                listView1.Items.Add(item);
                TongTien();
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            cboKhuVuc.SelectedIndex = -1;
            txtDinhMuc.Clear();
            txtSoCu.Clear();
            txtSoMoi.Clear();
            txtTieuThu.Clear();
            txtThanhTien.Clear();
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
                TongTien();
            }
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboKhuVuc.Text)
            {
                case "Khu vực 1":
                    txtDinhMuc.Text = "50";
                    break;
                case "Khu vực 2":
                    txtDinhMuc.Text = "100";
                    break;
                case "Khu vực 3":
                    txtDinhMuc.Text = "150";
                    break;
                default:
                    txtDinhMuc.Text = "";
                    break;
            }
        }
    }
}
