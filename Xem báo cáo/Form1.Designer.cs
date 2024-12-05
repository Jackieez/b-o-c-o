using System.Data;

namespace Xem_báo_cáo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoaiBaoCao = new ComboBox();
            TieuChi = new GroupBox();
            Lop = new RadioButton();
            BaiTap = new RadioButton();
            Sinhvien = new RadioButton();
            Thang = new RadioButton();
            Ngay = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            DanhSach = new ListBox();
            ViewReport = new Button();
            dataGridView1 = new DataGridView();
            TieuChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LoaiBaoCao
            // 
            LoaiBaoCao.FormattingEnabled = true;
            LoaiBaoCao.Items.AddRange(new object[] { "Báo cáo điểm danh", "Báo cáo bài tập" });
            LoaiBaoCao.Location = new Point(12, 20);
            LoaiBaoCao.Name = "LoaiBaoCao";
            LoaiBaoCao.Size = new Size(144, 28);
            LoaiBaoCao.TabIndex = 0;
            LoaiBaoCao.Text = "LoaiBaoCao";
            LoaiBaoCao.SelectedIndexChanged += LoaiBaoCao_SelectedIndexChanged;
            // 
            // TieuChi
            // 
            TieuChi.Controls.Add(Lop);
            TieuChi.Controls.Add(BaiTap);
            TieuChi.Controls.Add(Sinhvien);
            TieuChi.Controls.Add(Thang);
            TieuChi.Controls.Add(Ngay);
            TieuChi.Location = new Point(308, 20);
            TieuChi.Name = "TieuChi";
            TieuChi.Size = new Size(263, 187);
            TieuChi.TabIndex = 1;
            TieuChi.TabStop = false;
            TieuChi.Text = " Lựa chọn tieu chi";
            TieuChi.Enter += TieuChi_Enter;
            // 
            // Lop
            // 
            Lop.AutoSize = true;
            Lop.Location = new Point(18, 151);
            Lop.Name = "Lop";
            Lop.Size = new Size(55, 24);
            Lop.TabIndex = 4;
            Lop.TabStop = true;
            Lop.Text = "Lớp";
            Lop.UseVisualStyleBackColor = true;
            Lop.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // BaiTap
            // 
            BaiTap.AutoSize = true;
            BaiTap.Location = new Point(18, 121);
            BaiTap.Name = "BaiTap";
            BaiTap.Size = new Size(74, 24);
            BaiTap.TabIndex = 3;
            BaiTap.TabStop = true;
            BaiTap.Text = "BaiTap";
            BaiTap.UseVisualStyleBackColor = true;
            // 
            // Sinhvien
            // 
            Sinhvien.AutoSize = true;
            Sinhvien.Location = new Point(18, 91);
            Sinhvien.Name = "Sinhvien";
            Sinhvien.Size = new Size(87, 24);
            Sinhvien.TabIndex = 2;
            Sinhvien.TabStop = true;
            Sinhvien.Text = "SinhVien";
            Sinhvien.UseVisualStyleBackColor = true;
            Sinhvien.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Thang
            // 
            Thang.AutoSize = true;
            Thang.Location = new Point(18, 61);
            Thang.Name = "Thang";
            Thang.Size = new Size(71, 24);
            Thang.TabIndex = 1;
            Thang.TabStop = true;
            Thang.Text = "Tháng";
            Thang.UseVisualStyleBackColor = true;
            // 
            // Ngay
            // 
            Ngay.AutoSize = true;
            Ngay.Location = new Point(18, 31);
            Ngay.Name = "Ngay";
            Ngay.Size = new Size(65, 24);
            Ngay.TabIndex = 0;
            Ngay.TabStop = true;
            Ngay.Text = "Ngày";
            Ngay.UseVisualStyleBackColor = true;
            Ngay.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // DanhSach
            // 
            DanhSach.FormattingEnabled = true;
            DanhSach.Location = new Point(577, 20);
            DanhSach.Name = "DanhSach";
            DanhSach.Size = new Size(211, 304);
            DanhSach.TabIndex = 3;
            // 
            // ViewReport
            // 
            ViewReport.Location = new Point(349, 315);
            ViewReport.Name = "ViewReport";
            ViewReport.Size = new Size(94, 29);
            ViewReport.TabIndex = 4;
            ViewReport.Text = "Xem báo cáo";
            ViewReport.UseVisualStyleBackColor = true;
            ViewReport.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(ViewReport);
            Controls.Add(DanhSach);
            Controls.Add(dateTimePicker1);
            Controls.Add(TieuChi);
            Controls.Add(LoaiBaoCao);
            Name = "Form1";
            Text = "Xem báo cáo";
            Load += Form1_Load_1;
            TieuChi.ResumeLayout(false);
            TieuChi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox LoaiBaoCao;
        private GroupBox TieuChi;
        private DateTimePicker dateTimePicker1;
        private ListBox DanhSach;
        private Button ViewReport;
        private DataGridView dataGridView1;
        private RadioButton Sinhvien;
        private RadioButton Thang;
        private RadioButton Ngay;
        private RadioButton Lop;
        private RadioButton BaiTap;

        private void ViewReport_Click(object sender, EventArgs e)
        {
            if (LoaiBaoCao.SelectedIndex == 0)  // Báo cáo điểm danh
            {
                // Xử lý theo các tiêu chí lọc cho điểm danh
                if (Ngay.Checked)
                {
                    // Lọc theo ngày và lấy dữ liệu, chỉ hiển thị cột ngày
                    DataTable attendanceData = GetAttendanceReportByDate(dateTimePicker1.Value);
                    dataGridView1.DataSource = attendanceData;
                }
                else if (Thang.Checked)
                {
                    // Lọc theo tháng và lấy dữ liệu, sẽ có ngày và tháng
                    DataTable attendanceData = GetAttendanceReportByMonth(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
                    dataGridView1.DataSource = attendanceData;
                }
                else if (Sinhvien.Checked)
                {
                    // Lọc theo sinh viên và lấy dữ liệu
                    if (DanhSach.SelectedItem != null)
                    {
                        string selectedStudent = DanhSach.SelectedItem.ToString();
                        string studentID = selectedStudent.Split('-')[0].Trim();  // Lấy mã sinh viên

                        // Lấy dữ liệu báo cáo điểm danh theo sinh viên
                        DataTable attendanceData = GetAttendanceReportByStudent(studentID);

                        // Cập nhật DataGridView để hiển thị thông tin sinh viên
                        dataGridView1.DataSource = attendanceData;

                        // Thêm thông tin sinh viên vào cột mới
                        dataGridView1.Columns.Add("StudentName", "Tên Sinh Viên");
                        dataGridView1.Columns.Add("StudentID", "Mã Sinh Viên");

                        // Duyệt qua các hàng và thêm thông tin sinh viên vào cột mới
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Cells["StudentName"].Value = selectedStudent.Split('-')[1].Trim(); // Tên sinh viên
                            row.Cells["StudentID"].Value = studentID;  // Mã sinh viên
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (LoaiBaoCao.SelectedIndex == 0) // Báo cáo điểm danh
            {
                if (Sinhvien.Checked)
                {
                    // Lọc theo sinh viên và lấy dữ liệu
                    if (DanhSach.SelectedItem != null)
                    {
                        string selectedStudent = DanhSach.SelectedItem.ToString();
                        string studentID = selectedStudent.Split('-')[0].Trim(); // Lấy mã sinh viên

                        // Lấy dữ liệu báo cáo điểm danh theo sinh viên
                        DataTable attendanceReport = GetAttendanceReportByStudent(studentID);

                        // Hiển thị dữ liệu lên DataGridView
                        dataGridView1.DataSource = attendanceReport;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (LoaiBaoCao.SelectedIndex == 1) // Báo cáo bài tập
            {
                // Tương tự, xử lý trường hợp lọc báo cáo bài tập
            }
        }

        private DataTable GetAttendanceReportByMonth(int month, int year)
        {
            throw new NotImplementedException();
        }

        // Sự kiện khi RadioButton Sinhvien được chọn hoặc bỏ chọn
        private void Sinhvien_CheckedChanged(object sender, EventArgs e)
        {
            if (Sinhvien.Checked)
            {
                // Hiển thị danh sách sinh viên
                ShowStudentsList();
            }
            else
            {
                // Xóa danh sách sinh viên
                DanhSach.Items.Clear();
            }
        }

        // Hàm hiển thị danh sách sinh viên lên ListBox
        private void ShowStudentsList()
        {
            List<string> students = new List<string>

            {
        "SV001 - Nguyen A",
        "SV002 - Tran B",
        "SV003 - Le C",
        "SV004 - Pham D"

        };
            if (students.Count > 0)
            {
                DanhSach.Items.Clear(); // Xóa danh sách cũ
                DanhSach.Items.AddRange(students.ToArray()); // Thêm danh sách vào ListBox
            }
            else
            {
                MessageBox.Show("Danh sách sinh viên trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            DanhSach.Items.Clear(); // Xóa danh sách cũ
            DanhSach.Items.AddRange(students.ToArray()); // Thêm danh sách mới
        }

        // Gán sự kiện CheckedChanged trong Form1.Designer.cs hoặc Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            Sinhvien.CheckedChanged += new EventHandler(Sinhvien_CheckedChanged);
        }
        }
    }


    

