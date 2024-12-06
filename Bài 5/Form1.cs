using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_5
{
    public partial class TreeView_Demo : Form
    {
        public TreeView_Demo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string key = txtFirstName.Text.Trim()[0].ToString();
            key = "Node" + key;

            // Kiểm tra key có tồn tại chưa
            if (!treeView1.Nodes.ContainsKey(key))
            {
                treeView1.Nodes.Add(key, key); // Thêm node với key nếu chưa tồn tại
            }
            // Thêm node con vào node cha có key vừa kiểm tra
            treeView1.Nodes[key].Nodes.Add(txtFirstName.Text + "," + txtLastName.Text);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
