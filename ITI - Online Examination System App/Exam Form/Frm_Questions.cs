using Exam_Form.Models;

namespace Exam_Form
{
    public partial class Frm_Questions : Form
    {
        Instructor _instructor;
        Examination_Sys_Context _context;
        List<CourseInfo> _courseListOfQuestions;
        public Frm_Questions(Instructor instructor)
        {
            InitializeComponent();

            _instructor = instructor;
            _context = new Examination_Sys_Context();

        }

        private void Frm_Questions_Load(object sender, EventArgs e)
        {
            LoadQuestionsData();

            // Load data from database
            // Call this method for the entire form
            btn_Update.Enabled = false;
            btn_Dele.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Add.Enabled = false;
            btn_Save.Enabled = false;
            btn_Save.Visible = false;
            com_QType.Visible = false;
            comb_AnsTF.Visible = false;
            SetAllTextBoxesReadOnly(this);
        }

        private void LoadQuestionsData()
        {
            if (_instructor != null)
            {
                _courseListOfQuestions = GetCourseNamesByInstructorIdForQuestions(_instructor.InstructorId);
                foreach (var c in _courseListOfQuestions)
                {
                    comb_CoursesList.Items.Add(c.CourseName);
                }
            }



        }
        private void SetAllTextBoxesReadOnly(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                }
                else
                {
                    // Recursively check nested controls
                    SetAllTextBoxesReadOnly(control);
                }
            }

            //lab_TF.Visible = false;
        }


        private void SetAllTextBoxesNotReadOnly(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = false;
                }
                else
                {
                    // Fixed recursive call to use NotReadOnly version
                    SetAllTextBoxesNotReadOnly(control);
                }
            }
            //lab_TF.Visible = true;
        }

        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else
                {
                    // Recursively check nested controls
                    SetAllTextBoxesReadOnly(control);
                }
            }

            //lab_TF.Visible = false;
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

        private List<Question> questionsOfCourseSelected;
        // Modified ComboBox refresh after adding
        private void comb_CoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            lab_QPoints.Text = "";
            lab_QType.Text = "";

            if (comb_CoursesList.SelectedIndex >= 0)
            {
                LoadQuestionsOfCourseSelected();
            }
        }
        private void LoadQuestionsOfCourseSelected()
        {
            comb_QuestionHead.Items.Clear();
            comb_QuestionHead.Enabled = true;
            var courseId = _courseListOfQuestions[comb_CoursesList.SelectedIndex].CourseId;
            questionsOfCourseSelected = _context.Questions
                .Where(q => q.CourseId == courseId)
                .ToList();

            comb_QuestionHead.Items.AddRange(questionsOfCourseSelected
                .Select(q => q.QuestionHead)
                .ToArray());
        }


        Question questionSelected;
        List<QuestionOption> questionOption;
        private void comb_QuestionHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            comb_AnsTF.Enabled = true;
            txt_Op1.Enabled = true;
            txt_Op2.Enabled = true;
            txt_Op3.Enabled = true;
            txt_Op4.Enabled = true;
            txt_QHead.Enabled = true;
            txt_Answer.Enabled = true;
            SetAllTextBoxesNotReadOnly(this);
            btn_Update.Enabled = true;
            btn_Dele.Enabled = true;
            questionSelected = questionsOfCourseSelected[comb_QuestionHead.SelectedIndex];

            txt_QHead.Text = questionSelected.QuestionHead;
            lab_QType.Text = questionSelected.QuestionType;
            lab_QPoints.Text = questionSelected.QuestionPoints.ToString();

            if (lab_QType.Text == "mcq")
            {
                comb_AnsTF.Visible = false;
                txt_Answer.Visible = true;
                txt_Answer.Text = questionSelected.QuestionAnswer;
            }
            else
            {
                txt_Answer.Visible = false;
                comb_AnsTF.Visible = true;
                comb_AnsTF.Items.Add("True");
                comb_AnsTF.Items.Add("False");

                if (questionSelected.QuestionAnswer == "True")
                {
                    comb_AnsTF.SelectedItem = "True";

                }
                else
                {
                    comb_AnsTF.SelectedItem = "False";

                }

            }


            questionOption = _context.QuestionOptions
                    .Where(qo => qo.QuestionId == questionSelected.QuestionId)
                    .ToList();

            if (questionSelected.QuestionType == "mcq")
            {
                //lab_TF.Visible = false;

                txt_Op1.Visible = true;
                txt_Op2.Visible = true;
                txt_Op3.Visible = true;
                txt_Op4.Visible = true;

                txt_Op1.Text = questionOption[0].QuestionOption1;
                txt_Op2.Text = questionOption[1].QuestionOption1;
                txt_Op3.Text = questionOption[2].QuestionOption1;
                txt_Op4.Text = questionOption[3].QuestionOption1;
            }
            else
            {
                //lab_TF.Visible = true;

                txt_Op1.Visible = false;
                txt_Op2.Visible = false;
                txt_Op3.Visible = false;
                txt_Op4.Visible = false;

            }
        }

        //bool editUpdate = false;

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (questionSelected != null)
            {
                // Update question properties
                questionSelected.QuestionHead = txt_QHead.Text;
                questionSelected.QuestionType = lab_QType.Text;
                questionSelected.QuestionPoints = int.Parse(lab_QPoints.Text);
                //questionSelected.QuestionAnswer = txt_Answer.Text;

                // Handle MCQ options
                if (questionSelected.QuestionType == "mcq" && questionOption != null && questionOption.Count == 4)
                {
                    questionSelected.QuestionAnswer = txt_Answer.Text;

                    // Delete old options
                    foreach (var option in questionOption)
                    {
                        _context.QuestionOptions.Remove(option);
                    }
                    _context.SaveChanges();
                    // Add updated options
                    _context.QuestionOptions.Add(new QuestionOption
                    {
                        QuestionId = questionSelected.QuestionId,
                        QuestionOption1 = txt_Op1.Text
                    });
                    _context.QuestionOptions.Add(new QuestionOption
                    {
                        QuestionId = questionSelected.QuestionId,
                        QuestionOption1 = txt_Op2.Text
                    });
                    _context.QuestionOptions.Add(new QuestionOption
                    {
                        QuestionId = questionSelected.QuestionId,
                        QuestionOption1 = txt_Op3.Text
                    });
                    _context.QuestionOptions.Add(new QuestionOption
                    {
                        QuestionId = questionSelected.QuestionId,
                        QuestionOption1 = txt_Op4.Text
                    });
                }
                else
                {
                    if (comb_AnsTF.SelectedIndex > -1)
                    {
                        questionSelected.QuestionAnswer = comb_AnsTF.SelectedItem.ToString();

                    }
                }

                // Save changes to the database
                _context.SaveChanges();
                MessageBox.Show("Question and its options updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: not updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Disable editing
            SetAllTextBoxesReadOnly(this);
            //btn_Update.Text = "Edit";
            //editUpdate = false;

            LoadQuestionsOfCourseSelected();

        }

        private void btn_Dele_Click(object sender, EventArgs e)
        {
            if (questionSelected != null)
            {
                // First, delete all associated QuestionOptions

                //var optionsToDelete = _context.QuestionOptions
                //    .Where(qo => qo.QuestionId == questionSelected.QuestionId)
                //    .ToList();

                foreach (var option in questionOption)
                {
                    _context.QuestionOptions.Remove(option);
                }

                // Then, delete the Question itself
                _context.Questions.Remove(questionSelected);

                // Save changes to the database
                _context.SaveChanges();

                // Refresh the form after deletion
                comb_AnsTF.SelectedIndex = -1;
                comb_AnsTF.Enabled = false;
                comb_QuestionHead.Text = string.Empty;
                txt_QHead.Clear();
                txt_QHead.Enabled = false;
                lab_QType.Text = "";
                lab_QPoints.Text = "";
                txt_Answer.Clear();
                txt_Answer.Enabled = false;
                txt_Op1.Clear();
                txt_Op1.Enabled = false;
                txt_Op2.Clear();
                txt_Op2.Enabled = false;
                txt_Op3.Clear();
                txt_Op3.Enabled = false;
                txt_Op4.Clear();
                txt_Op4.Enabled = false;


                // Reload the remaining questions in the combobox
                if (comb_CoursesList.SelectedIndex >= 0)
                {
                    comb_QuestionHead.Items.Clear();

                    LoadQuestionsOfCourseSelected();
                }
                //if (comb_CoursesList.SelectedIndex >= 0)
                //{
                //    //comb_CoursesList_SelectedIndexChanged(null, null);
                //    //comb_CoursesList.Items.Clear();
                //    LoadQuestionsData();
                //}

                MessageBox.Show("Question and its options deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No question selected to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        bool editAdd = false;

        // Modified Add button click handler
        private void btn_Add_Click(object sender, EventArgs e)
        {
            comb_QuestionHead.Text = "";
            EnableAddMode();

            //btn_Add.Text = "Add Question";
            //editAdd = false;
        }



        private void EnableAddMode()
        {
            // Disable dropdown and enable textboxes
            comb_QuestionHead.Enabled = false;

            //SetAllTextBoxesNotReadOnly(this);

            //txt_Answer


            // Clear the textboxes for adding a new question
            txt_QHead.Clear();
            //txt_QHead.Enabled = true;
            txt_QHead.ReadOnly = false;

            lab_QType.Visible = false;

            com_QType.Items.Clear();
            com_QType.Items.Add("mcq");
            com_QType.Items.Add("true / false");
            com_QType.Visible = true;
            txt_Answer.Enabled = false;
            comb_AnsTF.Visible = false;
            comb_AnsTF.Items.Clear();
            comb_AnsTF.Items.Add("True");
            comb_AnsTF.Items.Add("False");

            lab_QPoints.Text = ""; // Clear points
            txt_Answer.Clear();
            txt_Op1.Clear();
            txt_Op2.Clear();
            txt_Op3.Clear();
            txt_Op4.Clear();

            btn_Cancel.Enabled = true;
            btn_Save.Enabled = true;
            btn_Save.Visible = true;
            btn_Add.Enabled = false;
            btn_Add.Visible = false;
            // Update button text and state
            //btn_Add.Text = "Save";
            //editAdd = true;
        }

        private void com_QType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_QHead.Enabled = true;
            if (com_QType.SelectedIndex == 1) // true/false question
            {

                //txt_Answer.Enabled = false;
                txt_Answer.Visible = false;
                comb_AnsTF.Visible = true;
                comb_AnsTF.Enabled = true;
                txt_Op1.Visible = false;
                txt_Op2.Visible = false;
                txt_Op3.Visible = false;
                txt_Op4.Visible = false;
                //lab_TF.Visible = true;
                lab_QPoints.Text = "1"; // Default points for true/false
            }
            else // mcq question
            {
                txt_Answer.Visible = true;
                txt_Answer.Enabled = true;
                comb_AnsTF.Visible = false;
                txt_Op1.Visible = true;
                txt_Op2.Visible = true;
                txt_Op3.Visible = true;
                txt_Op4.Visible = true;
                txt_Answer.ReadOnly = false;
                txt_Op1.ReadOnly = false;
                txt_Op2.ReadOnly = false;
                txt_Op3.ReadOnly = false;
                txt_Op4.ReadOnly = false;
                //lab_TF.Visible = false;
                lab_QPoints.Text = "2"; // Default points for mcq
            }

        }

        private void comb_AnsTF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_QType.SelectedIndex == 0)
            {

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            comb_QuestionHead.Enabled = true;
            com_QType.Visible = false;
            lab_QType.Visible = true;
            lab_QType.Text = "";
            lab_QPoints.Text = "";
            ClearAllTextBoxes(this);
            txt_Op1.Visible = true;
            txt_Op2.Visible = true;
            txt_Op3.Visible = true;
            txt_Op4.Visible = true;
            //btn_Update.Enabled = false;
            //btn_Dele.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Add.Enabled = true;
            btn_Save.Enabled = false;
            btn_Save.Visible = false;
            btn_Add.Enabled = true;
            btn_Add.Visible = true;


            comb_AnsTF.Visible = false;
            txt_Answer.Visible = true;
            SetAllTextBoxesReadOnly(this);
        }

        private void txt_QHead_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            com_QType.Text = "";
            //comb_AnsTF.SelectedIndex = -1;
            //comb_AnsTF.Text = "";
            try
            {
                bool allTxtBoxesFilled = this.Controls.OfType<TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));

                if ((com_QType.SelectedIndex == 0 && allTxtBoxesFilled) || (com_QType.SelectedIndex == 1 && txt_QHead.Text != "" && comb_AnsTF.SelectedIndex > -1))
                {
                    var selectedCourse = _courseListOfQuestions[comb_CoursesList.SelectedIndex];

                    if (com_QType.SelectedIndex == 0) // MCQ type
                    {
                        var options = new HashSet<string>
                        {
                            txt_Op1.Text.Trim(),
                            txt_Op2.Text.Trim(),
                            txt_Op3.Text.Trim(),
                            txt_Op4.Text.Trim()
                        };

                        if (options.Count < 4)
                        {
                            MessageBox.Show("Options must be unique!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!options.Contains(txt_Answer.Text.Trim()))
                        {
                            MessageBox.Show("The answer must be one of the provided options!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    var newQuestion = new Question
                    {
                        QuestionHead = txt_QHead.Text,
                        QuestionType = com_QType.SelectedItem.ToString(),
                        QuestionPoints = int.Parse(lab_QPoints.Text),
                        QuestionAnswer = com_QType.SelectedIndex == 0 ? txt_Answer.Text : comb_AnsTF.SelectedItem.ToString(),
                        CourseId = selectedCourse.CourseId
                    };

                    _context.Questions.Add(newQuestion);
                    _context.SaveChanges(); // Save question first to generate ID

                    if (newQuestion.QuestionType == "mcq")
                    {
                        var newOptions = new List<QuestionOption>
                        {
                            new QuestionOption { QuestionId = newQuestion.QuestionId, QuestionOption1 = txt_Op1.Text },
                            new QuestionOption { QuestionId = newQuestion.QuestionId, QuestionOption1 = txt_Op2.Text },
                            new QuestionOption { QuestionId = newQuestion.QuestionId, QuestionOption1 = txt_Op3.Text },
                            new QuestionOption { QuestionId = newQuestion.QuestionId, QuestionOption1 = txt_Op4.Text }
                        };

                        _context.QuestionOptions.AddRange(newOptions);
                        _context.SaveChanges();
                    }

                    // Refresh UI components
                    var currentCourse = comb_CoursesList.SelectedItem?.ToString();
                    comb_CoursesList.Items.Clear();
                    _courseListOfQuestions = GetCourseNamesByInstructorIdForQuestions(_instructor.InstructorId);
                    comb_CoursesList.Items.AddRange(_courseListOfQuestions.Select(c => c.CourseName).ToArray());

                    if (currentCourse != null)
                    {
                        comb_CoursesList.SelectedIndex = comb_CoursesList.FindStringExact(currentCourse);
                        comb_CoursesList_SelectedIndexChanged(null, null);
                    }

                    ClearAllTextBoxes(this);
                    MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Please fill all question data...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    com_QType.SelectedIndex = -1;
                    comb_AnsTF.SelectedIndex = -1;
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please select the question type...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


    }
}
