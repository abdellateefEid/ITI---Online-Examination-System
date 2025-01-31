namespace Exam_Form
{
    partial class Frm_Questions
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
            comb_CoursesList = new ComboBox();
            label1 = new Label();
            comb_QuestionHead = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lab_QType = new Label();
            lab_QPoints = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_Answer = new TextBox();
            label6 = new Label();
            txt_QHead = new TextBox();
            txt_Op1 = new TextBox();
            txt_Op2 = new TextBox();
            txt_Op3 = new TextBox();
            txt_Op4 = new TextBox();
            label7 = new Label();
            btn_Update = new Button();
            btn_Dele = new Button();
            btn_Add = new Button();
            com_QType = new ComboBox();
            btn_Save = new Button();
            btn_Cancel = new Button();
            comb_AnsTF = new ComboBox();
            SuspendLayout();
            // 
            // comb_CoursesList
            // 
            comb_CoursesList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_CoursesList.FormattingEnabled = true;
            comb_CoursesList.Location = new Point(49, 59);
            comb_CoursesList.Name = "comb_CoursesList";
            comb_CoursesList.Size = new Size(326, 33);
            comb_CoursesList.TabIndex = 0;
            comb_CoursesList.SelectedIndexChanged += comb_CoursesList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 30);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 1;
            label1.Text = "Course name";
            // 
            // comb_QuestionHead
            // 
            comb_QuestionHead.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_QuestionHead.FormattingEnabled = true;
            comb_QuestionHead.Location = new Point(49, 132);
            comb_QuestionHead.Name = "comb_QuestionHead";
            comb_QuestionHead.Size = new Size(661, 33);
            comb_QuestionHead.TabIndex = 3;
            comb_QuestionHead.SelectedIndexChanged += comb_QuestionHead_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 109);
            label2.Name = "label2";
            label2.Size = new Size(186, 21);
            label2.TabIndex = 4;
            label2.Text = "Course Questions Head";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 192);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 5;
            label3.Text = "Q_Type:";
            // 
            // lab_QType
            // 
            lab_QType.AutoSize = true;
            lab_QType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab_QType.Location = new Point(120, 195);
            lab_QType.Name = "lab_QType";
            lab_QType.Size = new Size(81, 21);
            lab_QType.TabIndex = 6;
            lab_QType.Text = "lab_QType";
            // 
            // lab_QPoints
            // 
            lab_QPoints.AutoSize = true;
            lab_QPoints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab_QPoints.Location = new Point(335, 194);
            lab_QPoints.Name = "lab_QPoints";
            lab_QPoints.Size = new Size(92, 21);
            lab_QPoints.TabIndex = 8;
            lab_QPoints.Text = "lab_QPoints";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(264, 192);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 7;
            label5.Text = "Q_Poins:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 314);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 11;
            label4.Text = "Q_Answer:";
            // 
            // txt_Answer
            // 
            txt_Answer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Answer.Location = new Point(50, 339);
            txt_Answer.Name = "txt_Answer";
            txt_Answer.Size = new Size(661, 33);
            txt_Answer.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 233);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 13;
            label6.Text = "Q_Head:";
            // 
            // txt_QHead
            // 
            txt_QHead.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_QHead.Location = new Point(49, 258);
            txt_QHead.Name = "txt_QHead";
            txt_QHead.Size = new Size(661, 33);
            txt_QHead.TabIndex = 12;
            txt_QHead.TextChanged += txt_QHead_TextChanged;
            // 
            // txt_Op1
            // 
            txt_Op1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Op1.Location = new Point(49, 421);
            txt_Op1.Name = "txt_Op1";
            txt_Op1.Size = new Size(662, 33);
            txt_Op1.TabIndex = 14;
            // 
            // txt_Op2
            // 
            txt_Op2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Op2.Location = new Point(50, 460);
            txt_Op2.Name = "txt_Op2";
            txt_Op2.Size = new Size(661, 33);
            txt_Op2.TabIndex = 15;
            // 
            // txt_Op3
            // 
            txt_Op3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Op3.Location = new Point(49, 499);
            txt_Op3.Name = "txt_Op3";
            txt_Op3.Size = new Size(662, 33);
            txt_Op3.TabIndex = 16;
            // 
            // txt_Op4
            // 
            txt_Op4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Op4.Location = new Point(50, 538);
            txt_Op4.Name = "txt_Op4";
            txt_Op4.Size = new Size(661, 33);
            txt_Op4.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(49, 394);
            label7.Name = "label7";
            label7.Size = new Size(92, 21);
            label7.TabIndex = 18;
            label7.Text = "Q_Choices:";
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Update.Location = new Point(50, 601);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(147, 41);
            btn_Update.TabIndex = 19;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Dele
            // 
            btn_Dele.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Dele.Location = new Point(229, 601);
            btn_Dele.Name = "btn_Dele";
            btn_Dele.Size = new Size(147, 41);
            btn_Dele.TabIndex = 21;
            btn_Dele.Text = "Delete";
            btn_Dele.UseVisualStyleBackColor = true;
            btn_Dele.Click += btn_Dele_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(405, 61);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(184, 37);
            btn_Add.TabIndex = 22;
            btn_Add.Text = "Add New Question";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // com_QType
            // 
            com_QType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            com_QType.FormattingEnabled = true;
            com_QType.Location = new Point(120, 210);
            com_QType.Name = "com_QType";
            com_QType.Size = new Size(121, 29);
            com_QType.TabIndex = 23;
            com_QType.SelectedIndexChanged += com_QType_SelectedIndexChanged;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Save.Location = new Point(405, 61);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(184, 36);
            btn_Save.TabIndex = 24;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click_1;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancel.Location = new Point(600, 62);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(111, 37);
            btn_Cancel.TabIndex = 25;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // comb_AnsTF
            // 
            comb_AnsTF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comb_AnsTF.FormattingEnabled = true;
            comb_AnsTF.Location = new Point(49, 362);
            comb_AnsTF.Name = "comb_AnsTF";
            comb_AnsTF.Size = new Size(192, 29);
            comb_AnsTF.TabIndex = 26;
            comb_AnsTF.SelectedIndexChanged += comb_AnsTF_SelectedIndexChanged;
            // 
            // Frm_Questions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(770, 672);
            Controls.Add(comb_AnsTF);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(com_QType);
            Controls.Add(btn_Add);
            Controls.Add(btn_Dele);
            Controls.Add(btn_Update);
            Controls.Add(label7);
            Controls.Add(txt_Op4);
            Controls.Add(txt_Op3);
            Controls.Add(txt_Op2);
            Controls.Add(txt_Op1);
            Controls.Add(label6);
            Controls.Add(txt_QHead);
            Controls.Add(label4);
            Controls.Add(txt_Answer);
            Controls.Add(lab_QPoints);
            Controls.Add(label5);
            Controls.Add(lab_QType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comb_QuestionHead);
            Controls.Add(label1);
            Controls.Add(comb_CoursesList);
            ForeColor = SystemColors.ControlText;
            Name = "Frm_Questions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Questions";
            Load += Frm_Questions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comb_CoursesList;
        private Label label1;
        private ComboBox comb_QuestionHead;
        private Label label2;
        private Label label3;
        private Label lab_QType;
        private Label lab_QPoints;
        private Label label5;
        private Label label4;
        private TextBox txt_Answer;
        private Label label6;
        private TextBox txt_QHead;
        private TextBox txt_Op1;
        private TextBox txt_Op2;
        private TextBox txt_Op3;
        private TextBox txt_Op4;
        private Label label7;
        private Button btn_Update;
        private Button btn_Dele;
        private Button btn_Add;
        private ComboBox com_QType;
        private Button btn_Save;
        private Button btn_Cancel;
        private ComboBox comb_AnsTF;
    }
}