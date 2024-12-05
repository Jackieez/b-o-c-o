using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace HomeworkRP
{
    public partial class Form1 : Form
    {
        private List<string> danhSachSinhVien = new List<string> { "Nguyen Van A", "Tran Thi B", "Le Van C" };
        private List<string> danhSachBaiTap = new List<string> { "Bài tập 1: Lập trình C# cơ bản", "Bài tập 2: Làm việc với WinForms", "Bài tập 3: Kết nối cơ sở dữ liệu" };


        public Form1()
        {
            InitializeComponent();
            LoadBaitap();
            Loadlistsinhvien();
            giaobtramdom.Click += Giaobtramdom_Click;
            button2.Click += XungPhong_Click;
        }

        private void Giaobtramdom_Click(object? sender, EventArgs e)
        {
            if (baitap.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bài tập.");
                return;
            }

            if (danhSachSinhVien.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên rỗng.");
                return;
            }

            Random rnd = new Random();
            int randomIndex = rnd.Next(danhSachSinhVien.Count);
            string baiTap = baitap.SelectedItem.ToString();
            string sinhVien = danhSachSinhVien[randomIndex];

            MessageBox.Show($"Giao '{baiTap}' cho sinh viên '{sinhVien}' (ngẫu nhiên).");
        }

        private void XungPhong_Click(object? sender, EventArgs e)
        {
            if (baitap.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bài tập.");
                return;
            }

            if (listsinhvien.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên từ danh sách.");
                return;
            }

            string baiTap = baitap.SelectedItem.ToString();
            string sinhVien = listsinhvien.SelectedItem.ToString();

            MessageBox.Show($"Giao '{baiTap}' cho sinh viên '{sinhVien}' (xung phong).");
        }

        private void LoadBaitap()
        {
            baitap.Items.AddRange(danhSachBaiTap.ToArray());
            baitap.SelectedIndex = 0;
        }

        private void Loadlistsinhvien()
        {
            listsinhvien.Items.AddRange(danhSachSinhVien.ToArray());
        }

        private void btnGiaoNgauNhien_Click(object sender, EventArgs e)
        {
            if (BaiTap.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bài tập.");
                return;
            }
            Random rnd = new Random();
            int index = rnd.Next(danhSachSinhVien.Count);
            string sinhVienNgauNhien = danhSachSinhVien[index];
            string baiTap = BaiTap.SelectedItem.ToString();

            MessageBox.Show($"Giao '{baiTap}' cho sinh viên '{sinhVienNgauNhien}'.");
        }
        private void btnGiaoXungPhong_Click(object sender, EventArgs e)
        {
            if (BaiTap.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bài tập.");
                return;
            }

            if (listsinhvien.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên.");
                return;
            }

            string sinhVien = listsinhvien.SelectedItem.ToString();
            string baiTap = BaiTap.SelectedItem.ToString();

            MessageBox.Show($"Giao '{baiTap}' cho sinh viên '{sinhVien}'.");
        }
    }
}
