using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lấy mã sinh viên từ TextBox
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Duyệt qua các dòng trong DataGridView
            bool found = false;
            foreach (DataGridViewRow row in dtgDanhSach.Rows)
            {
                // Kiểm tra nếu dòng không phải dòng trống
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maSV)
                {
                    // Chọn dòng tìm thấy
                    row.Selected = true;

                    // Cuộn đến dòng được chọn
                    dtgDanhSach.FirstDisplayedScrollingRowIndex = row.Index;

                    found = true;
                    break;
                }
            }

            // Hiển thị thông báo nếu không tìm thấy
            if (!found)
            {
                MessageBox.Show("Không tìm thấy mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDanhSach.Columns.Add("MaSV", "Mã SV"); // thêm cột mã sinh viên
            dtgDanhSach.Columns.Add("TenSV","Tên SV"); // thêm cột tên sinh vênn
            dtgDanhSach.Columns.Add("Quequan","Quê quán");


        }

        private void btnNhap_Click(object sender, EventArgs e)
        {           
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            string queQuan = txtQueQuan.Text;   
            dtgDanhSach.Rows.Add(maSV, hoTen, queQuan); 
            // Xóa nội dung các textbox sau khi nhập
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtQueQuan.Clear();
        }

        private void dtgDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgDanhSach_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgDanhSach.Rows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dtgDanhSach.SelectedRows[0];
                // Kiểm tra nếu dòng không phải dòng trống
                if (dataGridViewRow.Cells[0].Value != null)
                {
                    txtMaSV.Text = dataGridViewRow.Cells[0].Value.ToString();
                    txtHoTen.Text = dataGridViewRow.Cells[1].Value.ToString();
                    txtQueQuan.Text = dataGridViewRow.Cells[2].Value.ToString();
                    btnXoa.Enabled = true;
                }
                if (dtgDanhSach.SelectedRows.Count == 1)
                {
                    btnSua.Enabled = true; // Chỉ cho sửa nếu có đúng một dòng được chọn
                }
                else
                {
                    btnSua.Enabled = false; // Vô hiệu hóa nếu không có dòng hoặc nhiều hơn một dòng được chọn
                }
            }

        }
        private void dtgData(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgDanhSach.SelectedRows[0];

                // Kiểm tra nếu không phải dòng trống
                if (selectedRow.Cells[0].Value != null)
                {
                    // Cập nhật dữ liệu trong dòng đang chọn
                    selectedRow.Cells[0].Value = txtMaSV.Text;
                    selectedRow.Cells[1].Value = txtHoTen.Text;
                    selectedRow.Cells[2].Value = txtQueQuan.Text;
                }
                else
                {
                    MessageBox.Show("Dòng đã chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (dtgDanhSach.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Lặp qua danh sách các dòng đang chọn
                    for (int i = dtgDanhSach.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        // Lấy dòng hiện tại
                        DataGridViewRow row = dtgDanhSach.SelectedRows[i];

                        // Xóa dòng
                        dtgDanhSach.Rows.RemoveAt(row.Index);
                    }
                    txtHoTen.Clear();
                    txtQueQuan.Clear();
                    txtMaSV.Clear();
                    txtMaSV.Focus();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
