namespace Exam_Form
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            /*
            Examination_Sys_Context context = new Examination_Sys_Context();

            Student student = context.Students.Find(16);
            Application.Run(new Frm_Stu_Coures_Exam(student));
            */
            Application.Run(new Frm_Login());
            //Application.Run(new Frm_ImageTest());
            /*
                        Examination_Sys_Context context = new Examination_Sys_Context();
                        Instructor instructor = context.Instructors.FirstOrDefault(i => i.InstructorId == 1);
                        Application.Run(new Frm_Instructor(instructor));
            */
            //Application.Run(new Frm_GetStuByDept_SP());
            //Application.Run(new Frm_GetInstructorCourses());
            //Application.Run(new Frm_GetCourseTopics());
            //Application.Run(new Frm_GetExamQuestionsWithAnswers());
            //Application.Run(new Frm_GetExamQuestionsWithChoices());
            //Application.Run(new Frm_GetStudentGrades());
            /*
            Examination_Sys_Context context = new Examination_Sys_Context();
            Instructor instructor = context.Instructors.FirstOrDefault(i => i.InstructorId == 1);
            Application.Run(new Frm_Questions(instructor));
            */
            /*
            Examination_Sys_Context context = new Examination_Sys_Context();
            Instructor instructor = context.Instructors.FirstOrDefault(i => i.InstructorId == 1);
            Application.Run(new Frm_ExamDetails(instructor));
            */


            //Application.Run(new Frm_GetExamQuestionsWithChoices(1, 1));


        }
    }
}