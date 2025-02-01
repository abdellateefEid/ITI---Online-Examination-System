# ITI Online Examination System

## Project Overview

The **ITI Online Examination System** is a Windows Forms application designed to automate online exams and manage student assessments efficiently. The system includes a SQL Server database with essential functionalities such as exam generation, student responses, and automated grading. It provides detailed reports for instructors and administrators to analyze exam performance and student progress.

## Features

- ![Rocket Icon](assets/icons/rocket.svg) **User Authentication**: Secure login for students and instructors.
- ![Checkmark Icon](assets/icons/checkmark.svg) **Exam Creation**: Generate and manage exams dynamically.
- ![Question Bank Icon](assets/icons/question-bank.svg) **Question Bank**: Store and manage exam questions.
- ![Exam Submission Icon](assets/icons/exam-submission.svg) **Exam Submission**: Students can take exams and submit answers.
- ![Grading Icon](assets/icons/automated-grading.svg) **Automated Grading**: The system evaluates responses and calculates grades.
- ![Reports Icon](assets/icons/reports.svg) **Reporting System**: Multiple reports for student performance, instructor courses, and exam details.

## Technology Stack

- ![C# Icon](assets/icons/csharp.svg) **Programming Language**: C#
- ![DotNet Icon](assets/icons/dotnet.svg) **Framework**: .NET (WinForms)
- ![SQL Server Icon](assets/icons/sql-server.svg) **Database**: SQL Server
- ![Entity Framework Icon](assets/icons/entity-framework.svg) **ORM**: Entity Framework Core
- ![RDLC Icon](assets/icons/rdlc.svg) **Reporting Tool**: RDLC (Report Definition Language Client-side)

## Installation & Setup

### 1. Clone the Repository

```sh
git clone https://github.com/abdellateefEid/ITI---Online-Examination-System.git
2. Install Dependencies

    Install .NET Framework (if not already installed)
    Install SQL Server and SQL Server Management Studio (SSMS)
    Install RDLC Report Viewer (if needed)

3. Configure the Database

    Restore the database backup (.bak file) in SQL Server.
    Update the connection string in app.config:

    <connectionStrings>
        <add name="ExamDB" connectionString="Data Source=YOUR_SERVER;Initial Catalog=ExamDB;Integrated Security=True" providerName="System.Data.SqlClient"/>
    </connectionStrings>

Usage Instructions

    Run the application using Visual Studio.
    Login with student or instructor credentials.
    Navigate through the dashboard to create exams, take tests, and view reports.
    Generate Reports using RDLC to analyze student performance.

Database Structure

    Tables: Students, Instructors, Courses, Exams, Questions, Answers, Results.
    Stored Procedures:
        sp_Select_Insert_Update_Delete for CRUD operations.
        sp_Exam_Generation for creating exams.
        sp_Exam_Answers for storing responses.
        sp_Exam_Correction for grading exams.
    Reports:
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


### Key Points:

1. **Icons for Key Features:** Each feature section includes icons to make it more visually appealing.
2. **Technology Stack:** Icons are used to represent key technologies like C#, .NET, SQL Server, etc.
3. **Installation & Setup:** The instructions are easy to follow, with icons next to each installation step.
4. **Usage & Database Structure:** Icons for actions and database procedures are used to guide users visually through the setup and use.
5. **Professional Layout:** The overall design gives the README a polished and professional appearance.

### How to Set Up Icons:

- You can download icons in SVG format or create them yourself.
- Place these icons in a folder inside your repository (e.g., `assets/icons/`).
- Link to them directly within the README using the relative paths, as shown above.

Would you like assistance in creating or obtaining the specific icons mentioned (e.g., rocket, checkmark)?




