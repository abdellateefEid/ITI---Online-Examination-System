namespace Exam_Form
{
    partial class Frm_Instructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Instructor));
            lab_instName = new Label();
            pictureBox1 = new PictureBox();
            btn_Ques = new Button();
            btn_reports = new Button();
            label2 = new Label();
            comb_coursesName = new ComboBox();
            dg_questions = new DataGridView();
            dg_qOptions = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            pnl_reports = new Panel();
            btn_StuByDeptReport = new Button();
            comb_DeptsName = new ComboBox();
            label1 = new Label();
            lab_StuEmail = new Label();
            comb_courseExamReport = new ComboBox();
            label6 = new Label();
            comb_studentsName = new ComboBox();
            label11 = new Label();
            button5 = new Button();
            comb_studentsNameGrades = new ComboBox();
            label9 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            cmb_courseNmaeStuExam = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            cmb_courseNmae = new ComboBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pnl_question = new Panel();
            btn_EditExamForm = new Button();
            btn_EditQuetionForm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_questions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_qOptions).BeginInit();
            pnl_reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnl_question.SuspendLayout();
            SuspendLayout();
            // 
            // lab_instName
            // 
            lab_instName.AutoSize = true;
            lab_instName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_instName.Location = new Point(49, 151);
            lab_instName.Name = "lab_instName";
            lab_instName.Size = new Size(134, 21);
            lab_instName.TabIndex = 0;
            lab_instName.Text = "Instructor Name";
            lab_instName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_Ques
            // 
            btn_Ques.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ques.Location = new Point(12, 365);
            btn_Ques.Name = "btn_Ques";
            btn_Ques.Size = new Size(210, 34);
            btn_Ques.TabIndex = 2;
            btn_Ques.Text = "Show Course Questions";
            btn_Ques.UseVisualStyleBackColor = true;
            btn_Ques.Click += btn_Ques_Click;
            // 
            // btn_reports
            // 
            btn_reports.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reports.Location = new Point(12, 423);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(210, 31);
            btn_reports.TabIndex = 4;
            btn_reports.Text = "Reports";
            btn_reports.UseVisualStyleBackColor = true;
            btn_reports.Click += btn_reports_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 21);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 0;
            label2.Text = "Course name";
            // 
            // comb_coursesName
            // 
            comb_coursesName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_coursesName.FormattingEnabled = true;
            comb_coursesName.Location = new Point(51, 50);
            comb_coursesName.Name = "comb_coursesName";
            comb_coursesName.Size = new Size(290, 29);
            comb_coursesName.TabIndex = 1;
            comb_coursesName.SelectedIndexChanged += comb_coursesName_SelectedIndexChanged;
            // 
            // dg_questions
            // 
            dg_questions.AllowUserToResizeRows = false;
            dg_questions.BackgroundColor = Color.White;
            dg_questions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_questions.Location = new Point(51, 120);
            dg_questions.Name = "dg_questions";
            dg_questions.Size = new Size(747, 242);
            dg_questions.TabIndex = 2;
            dg_questions.CellClick += dg_questions_CellClick;
            dg_questions.SelectionChanged += dg_questions_SelectionChanged;
            // 
            // dg_qOptions
            // 
            dg_qOptions.BackgroundColor = Color.White;
            dg_qOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_qOptions.Location = new Point(51, 394);
            dg_qOptions.Name = "dg_qOptions";
            dg_qOptions.Size = new Size(599, 138);
            dg_qOptions.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 98);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 5;
            label3.Text = "Quetions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 372);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 6;
            label4.Text = "Quetion Choices";
            // 
            // pnl_reports
            // 
            pnl_reports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_reports.BackColor = Color.White;
            pnl_reports.Controls.Add(btn_StuByDeptReport);
            pnl_reports.Controls.Add(comb_DeptsName);
            pnl_reports.Controls.Add(label1);
            pnl_reports.Controls.Add(lab_StuEmail);
            pnl_reports.Controls.Add(comb_courseExamReport);
            pnl_reports.Controls.Add(label6);
            pnl_reports.Controls.Add(comb_studentsName);
            pnl_reports.Controls.Add(label11);
            pnl_reports.Controls.Add(button5);
            pnl_reports.Controls.Add(comb_studentsNameGrades);
            pnl_reports.Controls.Add(label9);
            pnl_reports.Controls.Add(button4);
            pnl_reports.Controls.Add(button3);
            pnl_reports.Controls.Add(button2);
            pnl_reports.Controls.Add(cmb_courseNmaeStuExam);
            pnl_reports.Controls.Add(label5);
            pnl_reports.Controls.Add(button1);
            pnl_reports.Controls.Add(cmb_courseNmae);
            pnl_reports.Controls.Add(label7);
            pnl_reports.Location = new Point(234, 0);
            pnl_reports.Name = "pnl_reports";
            pnl_reports.Size = new Size(847, 603);
            pnl_reports.TabIndex = 7;
            // 
            // btn_StuByDeptReport
            // 
            btn_StuByDeptReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_StuByDeptReport.Location = new Point(367, 546);
            btn_StuByDeptReport.Name = "btn_StuByDeptReport";
            btn_StuByDeptReport.Size = new Size(230, 34);
            btn_StuByDeptReport.TabIndex = 26;
            btn_StuByDeptReport.Text = "View Students Report";
            btn_StuByDeptReport.UseVisualStyleBackColor = true;
            btn_StuByDeptReport.Click += btn_StuByDeptReport_Click;
            // 
            // comb_DeptsName
            // 
            comb_DeptsName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_DeptsName.FormattingEnabled = true;
            comb_DeptsName.Location = new Point(43, 546);
            comb_DeptsName.Name = "comb_DeptsName";
            comb_DeptsName.Size = new Size(290, 29);
            comb_DeptsName.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 520);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 24;
            label1.Text = "Department name";
            // 
            // lab_StuEmail
            // 
            lab_StuEmail.AutoSize = true;
            lab_StuEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab_StuEmail.Location = new Point(360, 270);
            lab_StuEmail.Name = "lab_StuEmail";
            lab_StuEmail.Size = new Size(127, 25);
            lab_StuEmail.TabIndex = 23;
            lab_StuEmail.Text = "Student Email";
            // 
            // comb_courseExamReport
            // 
            comb_courseExamReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_courseExamReport.FormattingEnabled = true;
            comb_courseExamReport.Location = new Point(43, 369);
            comb_courseExamReport.Name = "comb_courseExamReport";
            comb_courseExamReport.Size = new Size(290, 29);
            comb_courseExamReport.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 340);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 21;
            label6.Text = "Course name";
            // 
            // comb_studentsName
            // 
            comb_studentsName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_studentsName.FormattingEnabled = true;
            comb_studentsName.Location = new Point(367, 224);
            comb_studentsName.Name = "comb_studentsName";
            comb_studentsName.Size = new Size(236, 29);
            comb_studentsName.TabIndex = 20;
            comb_studentsName.SelectedIndexChanged += comb_studentsName_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(360, 195);
            label11.Name = "label11";
            label11.Size = new Size(128, 25);
            label11.TabIndex = 19;
            label11.Text = "Student name";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(367, 463);
            button5.Name = "button5";
            button5.Size = new Size(228, 34);
            button5.TabIndex = 15;
            button5.Text = "View Grades Report";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comb_studentsNameGrades
            // 
            comb_studentsNameGrades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_studentsNameGrades.FormattingEnabled = true;
            comb_studentsNameGrades.Location = new Point(43, 463);
            comb_studentsNameGrades.Name = "comb_studentsNameGrades";
            comb_studentsNameGrades.Size = new Size(290, 29);
            comb_studentsNameGrades.TabIndex = 14;
            comb_studentsNameGrades.SelectedIndexChanged += comb_studentsNameGrades_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 434);
            label9.Name = "label9";
            label9.Size = new Size(128, 25);
            label9.TabIndex = 13;
            label9.Text = "Student name";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(43, 42);
            button4.Name = "button4";
            button4.Size = new Size(553, 34);
            button4.TabIndex = 12;
            button4.Text = "View My Courses Report";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(367, 369);
            button3.Name = "button3";
            button3.Size = new Size(230, 34);
            button3.TabIndex = 9;
            button3.Text = "View Exam Report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(43, 270);
            button2.Name = "button2";
            button2.Size = new Size(290, 34);
            button2.TabIndex = 6;
            button2.Text = "View Student Exam Report";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmb_courseNmaeStuExam
            // 
            cmb_courseNmaeStuExam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_courseNmaeStuExam.FormattingEnabled = true;
            cmb_courseNmaeStuExam.Location = new Point(43, 224);
            cmb_courseNmaeStuExam.Name = "cmb_courseNmaeStuExam";
            cmb_courseNmaeStuExam.Size = new Size(290, 29);
            cmb_courseNmaeStuExam.TabIndex = 5;
            cmb_courseNmaeStuExam.SelectedIndexChanged += cmb_courseNmaeStuExam_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 195);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 4;
            label5.Text = "Course name";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(367, 130);
            button1.Name = "button1";
            button1.Size = new Size(230, 34);
            button1.TabIndex = 3;
            button1.Text = "View Topic Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmb_courseNmae
            // 
            cmb_courseNmae.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_courseNmae.FormattingEnabled = true;
            cmb_courseNmae.Location = new Point(43, 130);
            cmb_courseNmae.Name = "cmb_courseNmae";
            cmb_courseNmae.Size = new Size(290, 29);
            cmb_courseNmae.TabIndex = 1;
            cmb_courseNmae.SelectedIndexChanged += cmb_courseNmae_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 101);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 0;
            label7.Text = "Course name";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(239, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(841, 603);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pnl_question
            // 
            pnl_question.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_question.BackColor = Color.White;
            pnl_question.Controls.Add(label4);
            pnl_question.Controls.Add(label3);
            pnl_question.Controls.Add(dg_qOptions);
            pnl_question.Controls.Add(dg_questions);
            pnl_question.Controls.Add(comb_coursesName);
            pnl_question.Controls.Add(label2);
            pnl_question.Location = new Point(234, 0);
            pnl_question.Name = "pnl_question";
            pnl_question.Size = new Size(850, 603);
            pnl_question.TabIndex = 3;
            // 
            // btn_EditExamForm
            // 
            btn_EditExamForm.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EditExamForm.Location = new Point(12, 241);
            btn_EditExamForm.Name = "btn_EditExamForm";
            btn_EditExamForm.Size = new Size(210, 31);
            btn_EditExamForm.TabIndex = 9;
            btn_EditExamForm.Text = "Exams";
            btn_EditExamForm.UseVisualStyleBackColor = true;
            btn_EditExamForm.Click += btn_EditExamForm_Click;
            // 
            // btn_EditQuetionForm
            // 
            btn_EditQuetionForm.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EditQuetionForm.Location = new Point(12, 306);
            btn_EditQuetionForm.Name = "btn_EditQuetionForm";
            btn_EditQuetionForm.Size = new Size(210, 31);
            btn_EditQuetionForm.TabIndex = 10;
            btn_EditQuetionForm.Text = "Questions";
            btn_EditQuetionForm.UseVisualStyleBackColor = true;
            btn_EditQuetionForm.Click += btn_EditQuetionForm_Click;
            // 
            // Frm_Instructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1083, 604);
            Controls.Add(pictureBox2);
            Controls.Add(btn_EditQuetionForm);
            Controls.Add(btn_EditExamForm);
            Controls.Add(pnl_reports);
            Controls.Add(btn_reports);
            Controls.Add(pnl_question);
            Controls.Add(btn_Ques);
            Controls.Add(pictureBox1);
            Controls.Add(lab_instName);
            Name = "Frm_Instructor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Instructor";
            Load += Frm_Instructor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_questions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_qOptions).EndInit();
            pnl_reports.ResumeLayout(false);
            pnl_reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnl_question.ResumeLayout(false);
            pnl_question.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_instName;
        private PictureBox pictureBox1;
        private Button btn_Ques;
        private Button btn_reports;
        private Label label2;
        private ComboBox comb_coursesName;
        private DataGridView dg_questions;
        private DataGridView dg_qOptions;
        private Label label3;
        private Label label4;
        private Panel pnl_reports;
        private ComboBox comb_studentsName;
        private Label label11;
        private Button button5;
        private ComboBox comb_studentsNameGrades;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private ComboBox cmb_courseNmaeStuExam;
        private Label label5;
        private Button button1;
        private ComboBox cmb_courseNmae;
        private Label label7;
        private Panel pnl_question;
        private ComboBox comb_courseExamReport;
        private Label label6;
        private Button btn_EditExamForm;
        private Button btn_EditQuetionForm;
        private Label lab_StuEmail;
        private Button btn_StuByDeptReport;
        private ComboBox comb_DeptsName;
        private Label label1;
        private PictureBox pictureBox2;
    }
}