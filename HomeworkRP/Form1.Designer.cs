
namespace HomeworkRP
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
            baitap = new ComboBox();
            listsinhvien = new ListBox();
            giaobtramdom = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // baitap
            // 
            baitap.FormattingEnabled = true;
            baitap.Location = new Point(100, 40);
            baitap.Name = "baitap";
            baitap.Size = new Size(151, 28);
            baitap.TabIndex = 0;
            baitap.Text = "Baitap";
            baitap.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listsinhvien
            // 
            listsinhvien.FormattingEnabled = true;
            listsinhvien.Location = new Point(360, 40);
            listsinhvien.Name = "listsinhvien";
            listsinhvien.Size = new Size(150, 104);
            listsinhvien.TabIndex = 1;
            listsinhvien.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // giaobtramdom
            // 
            giaobtramdom.Location = new Point(100, 277);
            giaobtramdom.Name = "giaobtramdom";
            giaobtramdom.Size = new Size(138, 29);
            giaobtramdom.TabIndex = 2;
            giaobtramdom.Text = "giaobtramdom";
            giaobtramdom.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(360, 277);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 3;
            button2.Text = "Xung Phong";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 401);
            Controls.Add(button2);
            Controls.Add(giaobtramdom);
            Controls.Add(listsinhvien);
            Controls.Add(baitap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listsinhvien.SelectedItem != null)
            {
                string selectedStudent = listsinhvien.SelectedItem.ToString();
                MessageBox.Show($"Sinh viên được chọn: {selectedStudent}", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách.", "Thông báo");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baitap.SelectedItem != null)
            {
                string selectedTask = baitap.SelectedItem.ToString();
                MessageBox.Show($"Bài tập được chọn: {selectedTask}", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài tập.", "Thông báo");
            }
        }

        #endregion

        private ComboBox baitap;
        private ListBox listsinhvien;
        private Button giaobtramdom;
        private Button button2;
    }
}
