using Exam_Form.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Exam_Form
{
    public partial class Frm_Stu_Exam : Form
    {
        private readonly Examination_Sys_Context _context;
        private List<GenerateExamThenInsertItResult> _questions;
        private int[] _questionOptionRadioIndex;
        private string[] _questionsAnswer;
        private int _currentIndex;
        private int? _courseId;
        private int _examId;
        private int _studentId;
        private int remainingTime; // in seconds
        private bool _isSubmitted;

        public Frm_Stu_Exam(int studentId, int? courseId, int examId)
        {
            _studentId = studentId;
            _courseId = courseId;
            _examId = examId;
            _isSubmitted = false;

            InitializeComponent();
            _context = new Examination_Sys_Context();
        }

        private async void Frm_Stu_Exam_Load(object sender, EventArgs e)
        {
            try
            {
                lab_submit.Visible = false;
                btn_colse.Visible = false;

                await LoadQuestions(_courseId, _studentId, _examId);

                var exam = await _context.Exams.FirstOrDefaultAsync(ex => ex.ExamId == _examId);

                if (exam != null && exam.ExamDuration > 0)
                {
                    btn_submit.Enabled = true;

                    //**********************************************
                    TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
                    double timeWaisted = (double)(currentTime - exam.ExamStartTime).TotalSeconds;
                    remainingTime = (int)((exam.ExamDuration * 3600) - timeWaisted);
                    //**********************************************

                    timer_exam.Interval = 1000;
                    timer_exam.Tick += timer_exam_Tick;
                    timer_exam.Start();
                    UpdateTimerDisplay();
                }
                else
                {
                    MessageBox.Show("Invalid exam configuration.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async Task LoadQuestions(int? courseId, int studentId, int examId)
        {
            try
            {
                _questions = await _context.Procedures.GenerateExamThenInsertItAsync(courseId, studentId, examId);

                if (_questions?.Count > 0)
                {
                    _questionOptionRadioIndex = new int[_questions.Count];
                    _questionsAnswer = new string[_questions.Count];
                    Array.Fill(_questionOptionRadioIndex, -1);
                    _currentIndex = 0;
                    DisplayQuestion(_currentIndex);
                }
                else
                {
                    MessageBox.Show("No questions available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayQuestion(int index)
        {
            if (index < 0 || index >= _questions.Count) return;

            btn_pre.Visible = index > 0;
            btn_nxt.Visible = index < _questions.Count - 1;
            ClearRadioButtons();

            var question = _questions[index];
            lab_heahOfQuesion.Text = $"Q{index + 1}: {question.Question_Head}";

            var questionOptions = _context.QuestionOptions
                .Where(qo => qo.QuestionId == question.Question_Id)
                .ToList();

            if (question.Question_Type == "mcq")
            {
                radioButton1.Text = questionOptions.Count > 0 ? questionOptions[0].QuestionOption1 : "";
                radioButton2.Text = questionOptions.Count > 1 ? questionOptions[1].QuestionOption1 : "";
                radioButton3.Visible = questionOptions.Count > 2;
                radioButton4.Visible = questionOptions.Count > 3;

                if (radioButton3.Visible) radioButton3.Text = questionOptions[2].QuestionOption1;
                if (radioButton4.Visible) radioButton4.Text = questionOptions[3].QuestionOption1;
            }
            else
            {
                radioButton1.Text = "True";
                radioButton2.Text = "False";
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }

            if (_questionOptionRadioIndex[index] > -1)
            {
                groupBox1.Controls.OfType<RadioButton>().ToList()[_questionOptionRadioIndex[index]].Checked = true;
            }
        }

        private void btn_nxt_Click(object sender, EventArgs e) => Navigate(1);
        private void btn_pre_Click(object sender, EventArgs e) => Navigate(-1);

        private void Navigate(int direction)
        {
            SaveCurrentAnswer();
            _currentIndex = Math.Clamp(_currentIndex + direction, 0, _questions.Count - 1);
            DisplayQuestion(_currentIndex);
        }

        private void ClearRadioButtons()
        {
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
                rb.Visible = true;
            }
        }
        private void UpdateTimerDisplay()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
            lab_timer.Text = $"{timeSpan.Hours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}";
        }

        private async void timer_exam_Tick(object sender, EventArgs e)
        {
            if (_isSubmitted) return;

            remainingTime--;
            UpdateTimerDisplay();

            if (remainingTime <= 0)
            {
                timer_exam.Stop();
                await SubmitExam();
                ShowFinalScreen();
            }
        }

        private void btn_colse_Click(object sender, EventArgs e) => this.Close();

        private async Task SubmitExam()
        {
            if (_isSubmitted) return;
            _isSubmitted = true;

            SaveCurrentAnswer();
            DataTable answerTable = CreateAnswerDataTable();

            try
            {
                var totalGrade = await _context.Procedures.CorrectExamAsync(_studentId, _examId, answerTable);
                var entity = await _context.StudentCourses
                    .FirstOrDefaultAsync(sc => sc.StudentId == _studentId && sc.CourseId == _courseId);

                if (entity != null)
                {
                    entity.StudentCourseGrade = totalGrade[0].TotalGrade;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowFinalScreen()
        {
            // Disable all controls
            panel1.Enabled = false;
            btn_submit.Enabled = false;
            btn_pre.Enabled = false;
            btn_nxt.Enabled = false;

            // Show final message and close button
            lab_submit.Visible = true;
            btn_colse.Visible = true;
            panel1.Visible = false;
            if (remainingTime <= 0)
            {
                lab_submit.ForeColor = Color.Red;
                lab_submit.Text = "Time's up! Your answers have been submitted.";
            }
            else
            {
                lab_submit.ForeColor = Color.Green;
                lab_submit.Text = "Exam submitted successfully!";
            }
        }

        private void SaveCurrentAnswer()
        {
            var radioButtons = groupBox1.Controls.OfType<RadioButton>().ToList();
            for (int i = 0; i < radioButtons.Count; i++)
            {
                if (radioButtons[i].Checked && radioButtons[i].Visible)
                {
                    _questionOptionRadioIndex[_currentIndex] = i;
                    _questionsAnswer[_currentIndex] = radioButtons[i].Text;
                    break;
                }
            }
        }

        private DataTable CreateAnswerDataTable()
        {
            var answerTable = new DataTable();
            answerTable.Columns.Add("Question_Id", typeof(int));
            answerTable.Columns.Add("Student_Ans", typeof(string));

            for (int i = 0; i < _questions.Count; i++)
            {
                answerTable.Rows.Add(_questions[i].Question_Id, _questionsAnswer[i]);
            }
            return answerTable;
        }

        private async void btn_submit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to submit the exam?", "Confirm Submission",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer_exam.Stop();
                //_isSubmitted = true;
                await SubmitExam();
                ShowFinalScreen();
            }
        }
    }
}