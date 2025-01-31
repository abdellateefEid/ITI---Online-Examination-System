using Exam_Form.Models;
using System.ComponentModel;

namespace Exam_Form
{
    public partial class Frm_Instructor : Form
    {
        private Examination_Sys_Context _context;
        private Instructor? _instructor;
        private bool _instructor_is_managger;

        private List<CourseInfo> _courseList;
        private List<DeptInfo> _departments;
        private List<CourseInfo> _courseListOfQuestions;

        public Frm_Instructor(Instructor? instructor)
        {
            InitializeComponent();
            _context = new Examination_Sys_Context();

            //_instructor = instructor;
            _instructor = instructor; // _context.Instructors.FirstOrDefault(i => i.InstructorId == 1);

            _instructor_is_managger = _context.Departments
                    .Any(d => d.ManagerId == _instructor.InstructorId); // Check if any department has this instructor as a manager

            //LoadData();
        }

        private void Frm_Instructor_Load(object sender, EventArgs e)
        {
            pnl_question.Visible = false;
            pnl_reports.Visible = false;
            lab_instName.Text = _instructor.InstructorName;
        }

        private void LoadQuestionsData()
        {
            if (_instructor != null)
            {
                _courseListOfQuestions = GetCourseNamesByInstructorIdForQuestions(_instructor.InstructorId);
                foreach (var c in _courseListOfQuestions)
                {
                    comb_coursesName.Items.Add(c.CourseName);
                }
            }

            // Load data from database

        }
        public class CourseInfo
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
        }

        public List<CourseInfo> GetCourseNamesByInstructorIdForQuestions(int instructorId)
        {
            var _courseList = _context.Instructors
                .Where(i => i != null && i.InstructorId == instructorId)
                .SelectMany(i => i.Courses)
                .Select(c => new CourseInfo { CourseId = c.CourseId, CourseName = c.CourseName })
                .ToList();

            return _courseList;
        }

        private void CustomizeDataGridView()
        {
            // Set default font for all cells
            dg_questions.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            // Customize header row
            dg_questions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dg_questions.ColumnHeadersDefaultCellStyle.BackColor = Color.Azure;
            dg_questions.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;

            // Disable default styles to allow custom header styles to take effect
            dg_questions.EnableHeadersVisualStyles = false;

            // Set row style (optional)
            dg_questions.RowsDefaultCellStyle.BackColor = Color.White;
            dg_questions.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dg_questions.Columns["QuestionHead"]!.Width = 400; // Set width to 150 pixels
            dg_questions.Columns["QuestionType"]!.Width = 60; // Set width to 150 pixels
            dg_questions.Columns["QuestionAnswer"]!.Width = 400; // Set width to 150 pixels

            dg_questions.Columns["QuestionId"].Visible = false;  // This hides the column in the UI
            dg_questions.Columns["CourseId"].Visible = false;  // This hides the column in the UI
            dg_questions.Columns["Course"].Visible = false;  // This hides the column in the UI
            dg_questions.Columns["QuestionOptions"].Visible = false;  // This hides the column in the UI
            dg_questions.Columns["StudentAnswers"].Visible = false;  // This hides the column in the UI



            foreach (DataGridViewColumn column in dg_questions.Columns)
            {
                column.ReadOnly = true;
            }

            //*********************




        }


        private List<Question> questionsOfCourseSelected;
        private void comb_coursesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_coursesName.SelectedIndex >= 0)
            {
                dg_qOptions.Rows.Clear();
                // Fetch questions for the selected course
                questionsOfCourseSelected = _context.Questions
                    .Where(q => q.Course.CourseId == _courseListOfQuestions[comb_coursesName.SelectedIndex].CourseId)
                    .ToList();

                // Bind to DataGridView with editable binding list
                dg_questions.DataSource = new BindingList<Question>(questionsOfCourseSelected);

                // Enable editing and configure DataGridView properties
                dg_questions.AllowUserToAddRows = false;
                dg_questions.AllowUserToDeleteRows = false;
                dg_questions.EditMode = DataGridViewEditMode.EditOnEnter;

                CustomizeDataGridView();

            }
        }

        private void dg_questions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row in dg_questions
                DataGridViewRow selectedRow = dg_questions.Rows[e.RowIndex];
                int questionId = (int)selectedRow.Cells["QuestionId"].Value;

                // Fetch options for the selected question
                var questionOptions = _context.QuestionOptions
                    .Where(qo => qo.QuestionId == questionId)
                    .ToList();

                // Bind options data to dg_qOptions
                dg_qOptions.DataSource = new BindingList<QuestionOption>(questionOptions);

                //Enable editing mode and set grid properties
                dg_qOptions.AllowUserToAddRows = false;
                dg_qOptions.AllowUserToDeleteRows = false;
                //dg_qOptions.EditMode = DataGridViewEditMode.EditOnEnter;

            }
            CustomizeOptionsDataGridView();  // Ensure customization is applied

        }

        private void btn_EditExamForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ExamDetails frm_ExamDetails = new Frm_ExamDetails(_instructor);
            frm_ExamDetails.ShowDialog();

            this.Show();
        }

        private void btn_EditQuetionForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Questions frm_Questions = new Frm_Questions(_instructor);
            frm_Questions.ShowDialog();
            this.Show();
        }


        private void btn_Ques_Click(object sender, EventArgs e)
        {
            LoadQuestionsData();

            pnl_question.Visible = true;
            pnl_reports.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            LoadReportsData();

            pnl_question.Visible = false;
            pnl_reports.Visible = true;
            pictureBox2.Visible = false;

        }

        class DeptInfo
        {
            public int DeptId { get; set; }
            public string DeptName { get; set; }
        }
        private int courseId_ofStudent_forExamReport;
        private List<StudentInfo> _students_;
        private void LoadReportsData()
        {
            //if (_instructor != null)
            //{
            // Populate Course Names
            comb_DeptsName.Items.Clear();
            comb_coursesName.Items.Clear();
            cmb_courseNmae.Items.Clear();
            cmb_courseNmaeStuExam.Items.Clear();
            comb_courseExamReport.Items.Clear();

            if (_instructor_is_managger)
            {
                _departments = _context.Departments.Select(
                d => new DeptInfo
                {
                    DeptId = d.DepartmentId,
                    DeptName = d.DepartmentName
                }).ToList();

                foreach (var dept in _departments)
                {
                    comb_DeptsName.Items.Add(dept.DeptName);
                }
            }
            else
            {
                comb_DeptsName.Visible = false;
                btn_StuByDeptReport.Visible = false;
                label1.Visible = false;
            }


            _courseList = GetCoursesByInstructorId(_instructor.InstructorId);
            foreach (var c in _courseList)
            {
                cmb_courseNmae.Items.Add(c.CourseName);
                cmb_courseNmaeStuExam.Items.Add(c.CourseName);
                comb_courseExamReport.Items.Add(c.CourseName);

            }
            //}

            // Populate Student Names
            //comb_studentsName.Items.Clear();
            comb_studentsNameGrades.Items.Clear();

            _students_ = GetStudentsByInstructorId(_instructor.InstructorId);
            foreach (var s in _students_)
            {
                comb_studentsNameGrades.Items.Add(s.StudentName);

            }


        }
        public class StudentInfo
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
        }
        public List<StudentInfo> GetStudentsByInstructorId(int instructorId)
        {
            return _context.Students
                .Where(s => s.StudentCourses
                    .Any(sc => sc.Course.Instructors
                        .Any(ci => ci.InstructorId == instructorId))) // Navigate through join tables
                .Select(s => new StudentInfo
                {
                    StudentId = s.StudentId,
                    StudentName = s.StudentName
                })
                .Distinct() // Ensure unique students
                .ToList();
        }

        // Fetch Course Names by Instructor ID
        private List<CourseInfo> GetCoursesByInstructorId(int instructorId)
        {
            return _context.Instructors
                .Where(i => _instructor != null && i.InstructorId == instructorId)
                .SelectMany(i => i.Courses)
                .Select(c => new CourseInfo
                {
                    CourseId = c.CourseId,
                    CourseName = c.CourseName
                })
                .ToList();
        }

        // Fetch Student Names
        public List<StudentInfo> GetStudentNames(int courseId)
        {

            return _context.Students
                .Where(s => s.StudentCourses.Any(c => c.CourseId == courseId)) // Filter students by courseId
                .Select(s => new StudentInfo
                {
                    StudentId = s.StudentId,
                    StudentName = s.StudentName
                })
                .ToList();
        }

        // Fetch Exam IDs
        public List<string> GetExamIds()
        {
            return _context.Exams
                .Select(e => e.ExamId.ToString())
                .ToList();
        }

        // Fetch Instructor Names
        public List<string> GetInstructorNames()
        {
            return _context.Instructors
                .Select(i => i.InstructorName)
                .ToList();
        }

        // Fetch Department Names
        public List<string> GetDepartmentNames()
        {
            return _context.Departments
                .Select(d => d.DepartmentName)
                .ToList();
        }

        private int courseIndex_of_cmb_courseNmae = -1;
        //private string courseName_of_cmb_courseNmae = "";
        private void cmb_courseNmae_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseIndex_of_cmb_courseNmae = cmb_courseNmae.SelectedIndex;
            //courseName_of_cmb_courseNmae = cmb_courseNmae.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (courseIndex_of_cmb_courseNmae > -1)
            {
                this.Hide();
                int course_id = _context.Courses.FirstOrDefault(c => c.CourseId == _courseList[cmb_courseNmae.SelectedIndex].CourseId).CourseId;
                Frm_GetCourseTopics frm_GetCourseTopics = new Frm_GetCourseTopics(course_id);
                frm_GetCourseTopics.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Please choise the course name first", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //private int courseIndex_of_cmb_courseNmaeStuExam = -1;
        //private string courseName_of_cmb_courseNmaeStuExam = "";
        private List<StudentInfo> __studentList;
        private void cmb_courseNmaeStuExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //courseIndex_of_cmb_courseNmaeStuExam = cmb_courseNmaeStuExam.SelectedIndex;
            //courseName_of_cmb_courseNmaeStuExam = cmb_courseNmaeStuExam.Text;
            courseId_ofStudent_forExamReport = _courseList[cmb_courseNmaeStuExam.SelectedIndex].CourseId;
            __studentList = GetStudentNames(courseId_ofStudent_forExamReport);
            comb_studentsName.Items.Clear();
            comb_studentsName.Text = "";
            foreach (var student in __studentList)
            {
                comb_studentsName.Items.Add(student.StudentName);
                //comb_studentsNameGrades.Items.Add(student.StudentName);
            }
        }

        private int courseIndex_of_cmb_courseNmaeStuExam = -1;

        private void comb_studentsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmb_courseNmaeStuExam.SelectedIndex > -1))
            {

                MessageBox.Show("Please choise the course name first", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Student st = _context.Students.Find(__studentList[comb_studentsName.SelectedIndex].StudentId);
            lab_StuEmail.Text = st.StudentEmail;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cmb_courseNmaeStuExam.SelectedIndex > -1 && comb_studentsName.SelectedIndex > -1)
            {
                this.Hide();
                //int course_id = _context.Courses.FirstOrDefault(c => c.CourseName == courseName_of_cmb_courseNmaeStuExam).CourseId;
                int exam_id = _context.Exams.FirstOrDefault(e => e.CourseId == _courseList[cmb_courseNmaeStuExam.SelectedIndex].CourseId).ExamId;
                int stu_id = __studentList[comb_studentsName.SelectedIndex].StudentId;
                Frm_GetExamQuestionsWithAnswers frm_GetStudentExam = new Frm_GetExamQuestionsWithAnswers(exam_id, stu_id);
                frm_GetStudentExam.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Please choise both course name and student name", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comb_studentsNameGrades.SelectedIndex > -1)
            {
                Frm_GetStudentGrades frm_GetStudentGrades = new Frm_GetStudentGrades(____stuId);
                this.Hide();
                frm_GetStudentGrades.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please choise student name", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comb_courseExamReport.SelectedIndex > -1)
            {
                int course_id = _courseList[comb_courseExamReport.SelectedIndex].CourseId;
                int exam_id = _context.Exams.FirstOrDefault(e => e.CourseId == course_id).ExamId;
                Frm_GetExamQuestionsWithChoices frm_GetExamQuestionsWithChoices = new Frm_GetExamQuestionsWithChoices(exam_id, course_id);

                this.Hide();
                frm_GetExamQuestionsWithChoices.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please choise course name", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int instId = _instructor.InstructorId;

            Frm_GetInstructorCourses frm_GetInstructorCourses = new Frm_GetInstructorCourses(instId);

            this.Hide();
            frm_GetInstructorCourses.ShowDialog();
            this.Show();
        }

        private int ____stuId;
        private void comb_studentsNameGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ____stuId = _students_[comb_studentsNameGrades.SelectedIndex].StudentId;
        }




        private void dg_questions_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_questions.SelectedRows.Count > 0)
            {
                // Get the selected question's ID
                int selectedQuestionId = (int)dg_questions.SelectedRows[0].Cells["QuestionId"].Value;

                // Fetch options for the selected question
                var optionsOfSelectedQuestion = _context.QuestionOptions
                    .Where(o => o.QuestionId == selectedQuestionId)
                    .ToList();

                // Bind to DataGridView with editable binding list
                dg_qOptions.DataSource = new BindingList<QuestionOption>(optionsOfSelectedQuestion);


                CustomizeOptionsDataGridView();
            }
        }
        private void CustomizeOptionsDataGridView()
        {
            // Set general properties for DataGridView
            dg_qOptions.AutoGenerateColumns = false;  // Disable auto-generating columns
            dg_qOptions.AllowUserToAddRows = false;
            dg_qOptions.AllowUserToDeleteRows = false;
            dg_qOptions.EditMode = DataGridViewEditMode.EditOnEnter;

            // Set the default font for all cells
            dg_qOptions.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            // Set the row height
            //dg_qOptions.RowTemplate.Height = 35;  // Set a comfortable row height

            // Set the background color for rows
            dg_qOptions.RowsDefaultCellStyle.BackColor = Color.White;
            dg_qOptions.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            // Customize column headers

            dg_qOptions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dg_qOptions.ColumnHeadersDefaultCellStyle.BackColor = Color.Azure;
            dg_qOptions.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;

            dg_qOptions.EnableHeadersVisualStyles = false;

            // Adjust column widths for better readability
            dg_qOptions.Columns["QuestionOption1"].Width = 550;  // Set width of the first column
            dg_qOptions.Columns["QuestionOption1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // You can adjust the width of other columns similarly
            // For example:
            //dg_qOptions.Columns["QuestionId"].Width = 50;  // If you have more columns
            dg_qOptions.Columns["QuestionId"].Visible = false;  // This hides the column in the UI
            dg_qOptions.Columns["Question"].Visible = false;  // This hides the column in the UI


            //// Make sure columns are not read-only
            foreach (DataGridViewColumn column in dg_qOptions.Columns)
            {
                column.ReadOnly = true;
            }

        }

        private void btn_StuByDeptReport_Click(object sender, EventArgs e)
        {
            if (comb_DeptsName.SelectedIndex > -1)
            {
                int deptId = _departments[comb_DeptsName.SelectedIndex].DeptId;
                //_context.Students.Select(s => s.Track.Departments.Select(d=> d.DepartmentId) == deptId)

                this.Hide();
                Frm_GetStuByDept_SP frm_GetStuByDept_SP = new Frm_GetStuByDept_SP(deptId);
                frm_GetStuByDept_SP.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please choise department name", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
