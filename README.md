# 📝ITI Online Examination System

## 📌Project Overview

The **ITI Online Examination System** is a Windows Forms application designed to automate online exams and manage student assessments efficiently. The system includes a SQL Server database with essential functionalities such as exam generation, student responses, and automated grading. It provides reports for instructors and administrators to analyze exam performance and student progress.

## 🚀Features

- 🎯 **User Authentication**: Secure login for students and instructors.
- ✅ **Exam Creation**: Generate and manage exams dynamically.
- 📚 **Question Bank**: Store and manage exam questions.
- 📝 **Exam Submission**: Students can take exams and submit answers.
- 🎓 **Automated Grading**: The system evaluates responses and calculates grades.
- 📊 **Reporting System**: Multiple reports for student performance, instructor courses, and exam details.

## 🏗️Technology Stack

- 💻 **Programming Language**: C#
- ⚙️ **Framework**: .NET (WinForms)
- 🗄️ **Database**: SQL Server
- 🛠️ **ORM**: Entity Framework Core
- 📑 **Reporting Tool**: RDLC (Report Definition Language Client-side)

## 🛠️Installation & Setup

### 1️⃣Clone the Repository

```sh
git clone https://github.com/abdellateefEid/ITI---Online-Examination-System.git

### 2️⃣Install Dependencies

    💾 Install .NET Framework (if not already installed)
    🖥️ Install SQL Server and SQL Server Management Studio (SSMS)
    🖨️ Install RDLC Report Viewer (if needed)

### 3️⃣Configure the Database

    Restore the database backup (.bak file) in SQL Server.
    Update the connection string in Examination_Sys_Context.cs 
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Data Source=DESKTOP-AN2B1CQ;Initial Catalog=Examination_Sys;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


## 📦Usage Instructions

    ▶️ Run the application using Visual Studio.
    🔑 Login with student or instructor credentials.
    🏠 Navigate through the dashboard to create exams, take tests, and view reports.
    📈 Generate Reports using RDLC to analyze student performance.

## 📂Database Structure

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

## 📷Screenshots

UI Screenshot
Contributing

If you would like to contribute, please fork the repository and submit a pull request.
## 📜License

This project is licensed under the MIT License.




