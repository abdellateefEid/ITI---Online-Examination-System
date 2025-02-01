# ITI Online Examination System

## Project Overview

The **ITI Online Examination System** is a Windows Forms application designed to automate online exams and manage student assessments efficiently. The system includes a SQL Server database with essential functionalities such as exam generation, student responses, and automated grading. It provides reports for instructors and administrators to analyze exam performance and student progress.

## Features

- 🚀 **User Authentication**: Secure login for students and instructors.
- ✅ **Exam Creation**: Generate and manage exams dynamically.
- 📚 **Question Bank**: Store and manage exam questions.
- 📝 **Exam Submission**: Students can take exams and submit answers.
- 🎓 **Automated Grading**: The system evaluates responses and calculates grades.
- 📊 **Reporting System**: Multiple reports for student performance, instructor courses, and exam details.

## Technology Stack

- 💻 **Programming Language**: C#
- ⚙️ **Framework**: .NET (WinForms)
- 🗄️ **Database**: SQL Server
- 🛠️ **ORM**: Entity Framework Core
- 📑 **Reporting Tool**: RDLC (Report Definition Language Client-side)

## Installation & Setup

### 1. Clone the Repository

```sh
git clone https://github.com/abdellateefEid/ITI---Online-Examination-System.git

2. Install Dependencies

    💾 Install .NET Framework (if not already installed)
    🖥️ Install SQL Server and SQL Server Management Studio (SSMS)
    🖨️ Install RDLC Report Viewer (if needed)

3. Configure the Database

    Restore the database backup (.bak file) in SQL Server.
    Update the connection string in app.config:

    <connectionStrings>
        <add name="ExamDB" connectionString="Data Source=YOUR_SERVER;Initial Catalog=ExamDB;Integrated Security=True" providerName="System.Data.SqlClient"/>
    </connectionStrings>

Usage Instructions

    ▶️ Run the application using Visual Studio.
    🔑 Login with student or instructor credentials.
    🏠 Navigate through the dashboard to create exams, take tests, and view reports.
    📈 Generate Reports using RDLC to analyze student performance.

Database Structure

    🗃️ Tables: Students, Instructors, Courses, Exams, Questions, Answers, Results.
    🛠️ Stored Procedures:
        sp_Select_Insert_Update_Delete for CRUD operations.
        sp_Exam_Generation for creating exams.
        sp_Exam_Answers for storing responses.
        sp_Exam_Correction for grading exams.
    📑 Reports:
        Students by Department.
        Student grades by Student ID.
        Instructor's courses and student count.
        Course topics by Course ID.
        Exam questions by Exam ID.
        Student answers for a specific exam.

Screenshots

UI Screenshot
Contributing

If you would like to contribute, please fork the repository and submit a pull request.
License

This project is licensed under the MIT License.


### Explanation of Icons Used:

- 🚀 **Rocket**: Represents **User Authentication** or starting something.
- ✅ **Checkmark**: Indicates successful or correct features like **Exam Creation**.
- 📚 **Books**: Represents **Question Bank**.
- 📝 **Memo**: Represents **Exam Submission**.
- 🎓 **Graduation Cap**: Represents **Automated Grading**.
- 📊 **Bar Chart**: Represents **Reporting System**.
- 💻 **Laptop**: For **Programming Language**.
- ⚙️ **Gear**: For **Framework**.
- 🗄️ **File Cabinet**: For **Database**.
- 🛠️ **Hammer and Wrench**: For **ORM** and **Stored Procedures**.
- 📑 **Document**: For **Reports**.
- ▶️ **Play Button**: For **Running the Application**.
- 🔑 **Key**: For **Login**.
- 🏠 **House**: For **Navigating the Dashboard**.
- 📈 **Chart**: For **Generating Reports**.
- 🗃️ **File Box**: For **Tables** in the database.

These are **Unicode emojis** that can be used directly in markdown and are widely supported on platforms like GitHub, GitLab, etc. 

### Advantages:
1. No need to store or link files.
2. Easy to copy-paste and customize.
3. **Colored** icons are supported across most markdown renderers.

Let me know if this works for you!



