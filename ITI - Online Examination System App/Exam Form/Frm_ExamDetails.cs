using Exam_Form.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam_Form
{
    public partial class Frm_ExamDetails : Form
    {
        private class CourseInfo
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
        }

        Instructor _instructor;
        Examination_Sys_Context _context;
        List<CourseInfo> _courseListOfInstructor;
        Exam _courseExam;
        public Frm_ExamDetails(Instructor instructor)
        {
            InitializeComponent();

            _instructor = instructor;
            _context = new Examination_Sys_Context();

        }

        private void Frm_ExamDetails_Load(object sender, EventArgs e)
        {
            if (_instructor != null)
            {
                _courseListOfInstructor = _context.Instructors
                .Where(i => i.InstructorId == _instructor.InstructorId)
                .SelectMany(i => i.Courses)
                .Select(c => new CourseInfo { CourseId = c.CourseId, CourseName = c.CourseName })
                .ToList();

                foreach (var c in _courseListOfInstructor)
                {
                    comb_CoursesList.Items.Add(c.CourseName);
                }

                dateTimePicker_Date.Enabled = false;
                dateTimePicker_Date.Format = DateTimePickerFormat.Long;
                dateTimePicker_Date.ShowUpDown = false; // Use calendar-style picker

                // Set the DateTimePicker to show time(no date)
                dateTimePicker_Time.Enabled = false;
                dateTimePicker_Time.Format = DateTimePickerFormat.Time;
                dateTimePicker_Time.ShowUpDown = true; // Use up/down arrows for time selection
                dateTimePicker_Time.CustomFormat = "HH:mm:ss"; // 24-hour format (e.g., 14:30:00)

                txt_ExamDuration.Enabled = false;

                txt_ExamTotalPoints.Enabled = false;

                btn_AddExam.Enabled = false;
                btn_UpdateExam.Enabled = false;
                btn_DeleteExam.Enabled = false;
            }
        }

        private void comb_CoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_CoursesList.SelectedIndex >= 0)
            {
                var courseId = _courseListOfInstructor[comb_CoursesList.SelectedIndex].CourseId;
                _courseExam = _context.Exams.FirstOrDefault(e => e.CourseId == courseId);

                // Enable/disable controls based on exam existence
                if (_courseExam == null)
                {
                    // No existing exam - enable Add button
                    btn_AddExam.Enabled = true;
                    btn_UpdateExam.Enabled = false;
                    btn_DeleteExam.Enabled = false;

                    // Reset fields for new exam
                    dateTimePicker_Date.Value = DateTime.Today;
                    dateTimePicker_Time.Value = DateTime.Today; // Will show 00:00 time
                    txt_ExamDuration.Text = string.Empty;
                    txt_ExamTotalPoints.Text = string.Empty;
                }
                else
                {
                    // Existing exam found - enable Update/Delete buttons
                    btn_AddExam.Enabled = false;
                    btn_UpdateExam.Enabled = true;
                    btn_DeleteExam.Enabled = true;

                    // Populate fields with existing exam data
                    dateTimePicker_Date.Value = _courseExam.ExamStartDate.ToDateTime(_courseExam.ExamStartTime);

                    // Convert TimeOnly to DateTime for display
                    DateTime combinedDateTime = DateTime.Today.Add(_courseExam.ExamStartTime.ToTimeSpan());
                    dateTimePicker_Time.Value = combinedDateTime;

                    txt_ExamDuration.Text = _courseExam.ExamDuration.ToString();
                    txt_ExamTotalPoints.Text = _courseExam.ExamTotalPoints.ToString();
                }

                // Always enable these controls when a course is selected
                dateTimePicker_Date.Enabled = true;
                dateTimePicker_Time.Enabled = true;
                txt_ExamDuration.Enabled = true;
            }

        }

        private bool ValidateExamInput()
        {
            // Add validation logic
            if (string.IsNullOrWhiteSpace(txt_ExamDuration.Text) ||
                !int.TryParse(txt_ExamDuration.Text, out _))
            {
                MessageBox.Show("Please enter a valid duration");
                return false;
            }


            return true;
        }

        private void RefreshUIAfterChange()
        {
            // Clear current selection
            _courseExam = null;

            // Reset UI
            comb_CoursesList.SelectedIndex = -1;
            dateTimePicker_Date.Value = DateTime.Today;
            dateTimePicker_Date.Enabled = false;

            dateTimePicker_Time.Value = DateTime.Today;
            dateTimePicker_Time.Enabled = false;

            txt_ExamDuration.Clear();
            txt_ExamDuration.Enabled = false;
            txt_ExamTotalPoints.Clear();

            // Disable buttons
            btn_AddExam.Enabled = false;
            btn_UpdateExam.Enabled = false;
            btn_DeleteExam.Enabled = false;

            // Optional: Refresh course list
            //LoadCourses(); // If you have a method to reload courses
        }
        private async void btn_AddExam_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Validate input
                if (!ValidateExamInput()) return;

                var newExam = new Exam
                {
                    CourseId = _courseListOfInstructor[comb_CoursesList.SelectedIndex].CourseId,
                    ExamStartDate = DateOnly.FromDateTime(dateTimePicker_Date.Value),
                    ExamStartTime = TimeOnly.FromDateTime(dateTimePicker_Time.Value),
                    ExamDuration = double.Parse(txt_ExamDuration.Text),
                    ExamTotalPoints = 15 //default
                };

                await _context.Exams.AddAsync(newExam);
                await _context.SaveChangesAsync();

                RefreshUIAfterChange();
                MessageBox.Show("Exam added successfully!");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Database error: {ex.InnerException?.Message ?? ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btn_UpdateExam_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_courseExam == null) return;
                if (!ValidateExamInput()) return;

                // Update existing exam
                _courseExam.ExamStartDate = DateOnly.FromDateTime(dateTimePicker_Date.Value);
                _courseExam.ExamStartTime = TimeOnly.FromDateTime(dateTimePicker_Time.Value);
                _courseExam.ExamDuration = int.Parse(txt_ExamDuration.Text);
                _courseExam.ExamTotalPoints = 15;

                _context.Entry(_courseExam).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                RefreshUIAfterChange();
                MessageBox.Show("Exam updated successfully!");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Database error: {ex.InnerException?.Message ?? ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btn_DeleteExam_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_courseExam == null) return;

                var confirm = MessageBox.Show("Are you sure you want to delete this exam?",
                                            "Confirm Delete",
                                            MessageBoxButtons.YesNo);

                if (confirm != DialogResult.Yes) return;

                _context.Exams.Remove(_courseExam);
                await _context.SaveChangesAsync();

                RefreshUIAfterChange();
                MessageBox.Show("Exam deleted successfully!");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Database error: {ex.InnerException?.Message ?? ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
