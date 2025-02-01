# ITI Online Examination System

## Project Overview

The ITI Online Examination System is a Windows Forms application designed to automate online exams and manage student assessments efficiently. The system includes a SQL Server database with essential functionalities such as exam generation, student responses, and automated grading. It provides reports for instructors and administrators to analyze exam performance and student progress.

## Features

- ![User Authentication Icon](https://img.icons8.com/ios-filled/50/000000/locked.png) **User Authentication**: Secure login for students and instructors.
- ![Exam Creation Icon](https://img.icons8.com/ios-filled/50/000000/test-tube.png) **Exam Creation**: Generate and manage exams dynamically.
- ![Question Bank Icon](https://img.icons8.com/ios-filled/50/000000/book.png) **Question Bank**: Store and manage exam questions.
- ![Exam Submission Icon](https://img.icons8.com/ios-filled/50/000000/checkmark.png) **Exam Submission**: Students can take exams and submit answers.
- ![Grading Icon](https://img.icons8.com/ios-filled/50/000000/edit.png) **Automated Grading**: The system evaluates responses and calculates grades.
- ![Reports Icon](https://img.icons8.com/ios-filled/50/000000/report.png) **Reporting System**: Multiple reports for student performance, instructor courses, and exam details.

## Technology Stack

- ![C# Icon](https://img.icons8.com/ios-filled/50/000000/c-sharp-logo.png) **Programming Language**: C#
- ![DotNet Icon](https://img.icons8.com/ios-filled/50/000000/.net.png) **Framework**: .NET (WinForms)
- ![SQL Server Icon](https://img.icons8.com/ios-filled/50/000000/microsoft-sql-server.png) **Database**: SQL Server
- ![Entity Framework Icon](https://img.icons8.com/ios-filled/50/000000/entity-framework.png) **ORM**: Entity Framework Core
- ![RDLC Icon](https://img.icons8.com/ios-filled/50/000000/pdf.png) **Reporting Tool**: RDLC (Report Definition Language Client-side)

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

    ![Database Icon](https://img.icons8.com/ios-filled/50

You said:
no links for icons  but icons laredy created with color
ChatGPT said:
ChatGPT

To add icons that are already created and have color without relying on external links, you can use the following approach:

    If you have local image files for the icons, upload them to the same repository (preferably in an /assets/icons/ folder).
    Reference these images in your README file by using relative paths.

Here’s how you can structure your README with your colored icons:

# ITI Online Examination System

## Project Overview

The ITI Online Examination System is a Windows Forms application designed to automate online exams and manage student assessments efficiently. The system includes a SQL Server database with essential functionalities such as exam generation, student responses, and automated grading. It provides reports for instructors and administrators to analyze exam performance and student progress.

## Features

- ![User Authentication Icon](assets/icons/user-authentication.png) **User Authentication**: Secure login for students and instructors.
- ![Exam Creation Icon](assets/icons/exam-creation.png) **Exam Creation**: Generate and manage exams dynamically.
- ![Question Bank Icon](assets/icons/question-bank.png) **Question Bank**: Store and manage exam questions.
- ![Exam Submission Icon](assets/icons/exam-submission.png) **Exam Submission**: Students can take exams and submit answers.
- ![Grading Icon](assets/icons/automated-grading.png) **Automated Grading**: The system evaluates responses and calculates grades.
- ![Reports Icon](assets/icons/reports.png) **Reporting System**: Multiple reports for student performance, instructor courses, and exam details.

## Technology Stack

- ![C# Icon](assets/icons/csharp.png) **Programming Language**: C#
- ![DotNet Icon](assets/icons/dotnet.png) **Framework**: .NET (WinForms)
- ![SQL Server Icon](assets/icons/sql-server.png) **Database**: SQL Server
- ![Entity Framework Icon](assets/icons/entity-framework.png) **ORM**: Entity Framework Core
- ![RDLC Icon](assets/icons/rdlc.png) **Reporting Tool**: RDLC (Report Definition Language Client-side)

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
- **Store icons in a folder** within your repository (e.g., `assets/icons/`).
- **Reference the icons** using relative paths like `assets/icons/icon-name.png`.

This will allow you to use custom, colored icons from your repository while keeping the README clean and visually appealing!

