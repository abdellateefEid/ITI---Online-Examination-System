namespace Exam_Form
{
    partial class Frm_ExamDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comb_CoursesList = new ComboBox();
            btn_AddExam = new Button();
            btn_DeleteExam = new Button();
            btn_UpdateExam = new Button();
            txt_ExamDuration = new TextBox();
            label2 = new Label();
            dateTimePicker_Date = new DateTimePicker();
            label3 = new Label();
            dateTimePicker_Time = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txt_ExamTotalPoints = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 5;
            label1.Text = "Course name";
            // 
            // comb_CoursesList
            // 
            comb_CoursesList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_CoursesList.FormattingEnabled = true;
            comb_CoursesList.Location = new Point(33, 57);
            comb_CoursesList.Name = "comb_CoursesList";
            comb_CoursesList.Size = new Size(445, 33);
            comb_CoursesList.TabIndex = 4;
            comb_CoursesList.SelectedIndexChanged += comb_CoursesList_SelectedIndexChanged;
            // 
            // btn_AddExam
            // 
            btn_AddExam.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AddExam.Location = new Point(33, 422);
            btn_AddExam.Name = "btn_AddExam";
            btn_AddExam.Size = new Size(136, 34);
            btn_AddExam.TabIndex = 6;
            btn_AddExam.Text = "Add Exam";
            btn_AddExam.UseVisualStyleBackColor = true;
            btn_AddExam.Click += btn_AddExam_Click_1;
            // 
            // btn_DeleteExam
            // 
            btn_DeleteExam.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DeleteExam.Location = new Point(341, 422);
            btn_DeleteExam.Name = "btn_DeleteExam";
            btn_DeleteExam.Size = new Size(136, 34);
            btn_DeleteExam.TabIndex = 7;
            btn_DeleteExam.Text = "Delete Exam";
            btn_DeleteExam.UseVisualStyleBackColor = true;
            btn_DeleteExam.Click += btn_DeleteExam_Click_1;
            // 
            // btn_UpdateExam
            // 
            btn_UpdateExam.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_UpdateExam.Location = new Point(189, 422);
            btn_UpdateExam.Name = "btn_UpdateExam";
            btn_UpdateExam.Size = new Size(136, 34);
            btn_UpdateExam.TabIndex = 8;
            btn_UpdateExam.Text = "Update Exam";
            btn_UpdateExam.UseVisualStyleBackColor = true;
            btn_UpdateExam.Click += btn_UpdateExam_Click_1;
            // 
            // txt_ExamDuration
            // 
            txt_ExamDuration.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ExamDuration.Location = new Point(131, 274);
            txt_ExamDuration.Name = "txt_ExamDuration";
            txt_ExamDuration.Size = new Size(92, 33);
            txt_ExamDuration.TabIndex = 9;
            txt_ExamDuration.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 275);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 10;
            label2.Text = "Duration";
            // 
            // dateTimePicker_Date
            // 
            dateTimePicker_Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_Date.Location = new Point(128, 175);
            dateTimePicker_Date.Name = "dateTimePicker_Date";
            dateTimePicker_Date.Size = new Size(276, 29);
            dateTimePicker_Date.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 175);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 12;
            label3.Text = "Start Date";
            // 
            // dateTimePicker_Time
            // 
            dateTimePicker_Time.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_Time.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_Time.Location = new Point(130, 224);
            dateTimePicker_Time.Name = "dateTimePicker_Time";
            dateTimePicker_Time.Size = new Size(166, 29);
            dateTimePicker_Time.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 224);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 14;
            label4.Text = "Start Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 331);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 16;
            label5.Text = "Total Points";
            // 
            // txt_ExamTotalPoints
            // 
            txt_ExamTotalPoints.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ExamTotalPoints.Location = new Point(131, 329);
            txt_ExamTotalPoints.Name = "txt_ExamTotalPoints";
            txt_ExamTotalPoints.Size = new Size(64, 33);
            txt_ExamTotalPoints.TabIndex = 15;
            txt_ExamTotalPoints.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(29, 134);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 17;
            label6.Text = "Exam Info:";
            // 
            // Frm_ExamDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(513, 495);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_ExamTotalPoints);
            Controls.Add(label4);
            Controls.Add(dateTimePicker_Time);
            Controls.Add(label3);
            Controls.Add(dateTimePicker_Date);
            Controls.Add(label2);
            Controls.Add(txt_ExamDuration);
            Controls.Add(btn_UpdateExam);
            Controls.Add(btn_DeleteExam);
            Controls.Add(btn_AddExam);
            Controls.Add(label1);
            Controls.Add(comb_CoursesList);
            Name = "Frm_ExamDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_ExamDetails";
            Load += Frm_ExamDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comb_CoursesList;
        private Button btn_AddExam;
        private Button btn_DeleteExam;
        private Button btn_UpdateExam;
        private TextBox txt_ExamDuration;
        private Label label2;
        private DateTimePicker dateTimePicker_Date;
        private Label label3;
        private DateTimePicker dateTimePicker_Time;
        private Label label4;
        private Label label5;
        private TextBox txt_ExamTotalPoints;
        private Label label6;
    }
}