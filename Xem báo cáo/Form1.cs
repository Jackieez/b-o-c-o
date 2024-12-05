using System;
using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Xem_báo_cáo
{
    public partial class Form1 : Form
    {
        private string studentID;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoaiBaoCao.SelectedIndex == 0)  // Báo cáo điểm danh
            {
                // Xử lý theo các tiêu chí lọc cho điểm danh
                if (Ngay.Checked)
                {
                    // Lọc theo ngày và lấy dữ liệu
                    DataTable attendanceData = GetAttendanceReportByDate(dateTimePicker1.Value);
                    dataGridView1.DataSource = attendanceData;
                }
                else if (Thang.Checked)
                {
                    // Lọc theo tháng và lấy dữ liệu
                    int selectedMonth = dateTimePicker1.Value.Month;
                    int selectedYear = dateTimePicker1.Value.Year;

                    DataTable attendanceData = GetAttendanceReportByMonth(dateTimePicker1.Value);

                    // Hiển thị dữ liệu trên DataGridView
                    dataGridView1.DataSource = attendanceData;
                }
                else if (Sinhvien.Checked)
                {
                    // Lọc theo sinh viên và lấy dữ liệu
                    string selectedStudent = DanhSach.SelectedItem as string;

                    if (selectedStudent != null)
                    {
                        // Lọc báo cáo điểm danh theo Sinh viên đã chọn
                        string studentID = selectedStudent.Split('-')[0].Trim();  // Lấy mã sinh viên từ danh sách
                        DataTable attendanceReport = GetAttendanceReportByStudent(studentID);

                        // Hiển thị dữ liệu lên DataGridView
                        dataGridView1.DataSource = attendanceReport;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sinh viên.");
                    }
                }
            }
            else if (LoaiBaoCao.SelectedIndex == 1)  // Báo cáo bài tập
            {
                // Xử lý theo các tiêu chí lọc cho bài tập
                if (BaiTap.Checked)
                {
                    // Lọc theo bài tập và lấy dữ liệu
                    string taskId = DanhSach.SelectedItem.ToString();  // Giả sử chọn bài tập từ DanhSach
                    DataTable assignmentData = GetAssignmentReportByTask(taskId);
                    dataGridView1.DataSource = assignmentData;
                }
                else if (Lop.Checked)
                {
                    // Lọc theo lớp và lấy dữ liệu
                    string classId = DanhSach.SelectedItem.ToString();  // Giả sử chọn lớp từ DanhSach
                    DataTable assignmentData = GetAssignmentReportByClass(classId);
                    dataGridView1.DataSource = assignmentData;
                }
                else if (Sinhvien.Checked)
                {
                    // Lọc theo sinh viên và lấy dữ liệu
                    string studentId = DanhSach.SelectedItem.ToString();  // Giả sử chọn sinh viên từ DanhSach
                    DataTable assignmentData = GetAssignmentReportByStudent(studentId);
                    dataGridView1.DataSource = assignmentData;
                }
            }
        }


        private DataTable GetAssignmentReportByStudent(string? studentId)
        {
            throw new NotImplementedException();
        }

        private DataTable GetAssignmentReportByClass(string? classId)
        {
            throw new NotImplementedException();
        }

        private DataTable GetAssignmentReportByTask(string? taskId)
        {
            throw new NotImplementedException();
        }

        private void LoaiBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoaiBaoCao.SelectedIndex == 0)  // Báo cáo điểm danh
            {
                // Hiển thị các bộ lọc cho báo cáo điểm danh
                Thang.Visible = true;
                Ngay.Visible = true;
                Sinhvien.Visible = true;
                BaiTap.Visible = false;
                Lop.Visible = false;
            }
            else if (LoaiBaoCao.SelectedIndex == 1)  // Báo cáo bài tập
            {
                // Hiển thị các bộ lọc cho báo cáo bài tập
                Thang.Visible = false;
                Ngay.Visible = false;
                Sinhvien.Visible = false;
                BaiTap.Visible = true;
                Lop.Visible = true;
            }
        }

        private void TieuChi_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Sinhvien.CheckedChanged += new System.EventHandler(this.Sinhvien_CheckedChanged);

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }


        private DataTable GetAttendanceReportByDate(DateTime date)
        {
            // Giả sử đây là mã truy vấn dữ liệu theo ngày
            DataTable data = new DataTable();
            data.Columns.Add("StudentID");
            data.Columns.Add("Name");
            data.Columns.Add("AttendanceStatus");
            data.Columns.Add("Ngay");  // Thêm cột Ngày
            data.Columns.Add("Thang"); // Thêm cột Tháng

            // Dữ liệu mẫu
            data.Rows.Add("SV001", "Nguyen A", "Có mặt", date.ToString("dd"), date.ToString("MM/yyyy"));
            data.Rows.Add("SV002", "Tran B", "Vắng", date.ToString("dd"), date.ToString("MM/yyyy"));
            return data;
        }

        private DataTable GetAttendanceReportByMonth(DateTime date)
        {
            // Giả sử đây là mã truy vấn dữ liệu theo tháng
            DataTable data = new DataTable();
            data.Columns.Add("StudentID");
            data.Columns.Add("Name");
            data.Columns.Add("AttendanceStatus");
            data.Columns.Add("Ngày");
            data.Columns.Add("Thang");

            // Dữ liệu mẫu cho tất cả sinh viên trong tháng
            data.Rows.Add("SV001", "Nguyen A", "Có mặt", date.ToString("dd"), date.ToString("MM/yyyy"));
            data.Rows.Add("SV002", "Tran B", "Vắng", date.ToString("dd"), date.ToString("MM/yyyy"));
            data.Rows.Add("SV003", "Le C", "Có mặt", date.ToString("dd"), date.ToString("MM/yyyy"));
            data.Rows.Add("SV004", "Pham D", "Có mặt", date.ToString("dd"), date.ToString("MM/yyyy"));
            return data;
        }

        private DataTable GetAttendanceReportByStudent(string studentId)
        {
            DataTable data = new DataTable();
            data.Columns.Add("StudentID");
            data.Columns.Add("Name");
            data.Columns.Add("AttendanceStatus");
            data.Columns.Add("Ngay");  // Thêm cột Ngày

            // Dữ liệu mẫu
            if (studentId == "SV001")
            {
                data.Rows.Add("SV001", "Nguyen A", "Có mặt", "01/12/2024");
                data.Rows.Add("SV001", "Nguyen A", "Vắng", "02/12/2024");
            }
            else if (studentId == "SV002")
            {
                data.Rows.Add("SV002", "Tran B", "Có mặt", "01/12/2024");
                data.Rows.Add("SV002", "Tran B", "Vắng", "03/12/2024");
            }
            else if (studentId == "SV003")
            {
                data.Rows.Add("SV003", "Le C", "Có mặt", "04/12/2024");
                data.Rows.Add("SV003", "Le C", "Vắng", "05/12/2024");
            }
            else if (studentId == "SV004")
            {
                data.Rows.Add("SV004", "Pham D", "Có mặt", "06/12/2024");
                data.Rows.Add("SV004", "Pham D", "Vắng", "07/12/2024");
            }
            return data;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}




    

