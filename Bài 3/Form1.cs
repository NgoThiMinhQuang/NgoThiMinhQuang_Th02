using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;   
            string phone = txtPhone.Text;   
            // Kiểm tra người dùng đã nhập đủ thông tin hay chưa
            if(lastName == "" || firstName == ""|| phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Tạo mục mới cho listView
            ListViewItem item = new ListViewItem(lastName);
            item.SubItems.Add(firstName);   
            item.SubItems.Add(phone);   

            // thêm biểu tượng (icon) cho mỗi dòng
            item.ImageKey = "user.png";

            // thêm mục vào list view
            listView1 .Items.Add(item);

            // Reset dữ liệu ở các text box
            txtFirstName.Clear();
            txtPhone.Clear();   
            txtLastName.Clear();    

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lsv = listView1.View.ToString();
            listView1.View = View.Details;
            txtHien.Text = lsv; 
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lsv = listView1.View.ToString();
            listView1.View = View.LargeIcon;
            txtHien.Text = lsv;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lsv = listView1.View.ToString();
            listView1.View = View.SmallIcon;
            txtHien.Text = lsv;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lsv = listView1.View.ToString();
            listView1.View = View.List;
            txtHien.Text = lsv;
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lsv = listView1.View.ToString();
            listView1.View = View.Tile;
            txtHien.Text = lsv;
        }
    }
}
