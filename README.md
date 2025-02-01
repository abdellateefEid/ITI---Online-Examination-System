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
- Tables: Students, Instructors, Courses, Exams, Questions, Answers, Results.
- Stored Procedures:
  - sp_Select_Insert_Update_Delete for CRUD operations.
  - sp_Exam_Generation for creating exams.
  - sp_Exam_Answers for storing responses.
  - sp_Exam_Correction for grading exams.
- Reports:
  - Students by Department.
  - Student grades by Student ID.
  - Instructor's courses and student count.
  - Course topics by Course ID.
  - Exam questions by Exam ID.
  - Student answers for a specific exam.

## Screenshots

![UI Screenshot](photo_2025-02-01_18-02-06.jpg)

## Contributing

If you would like to contribute, please fork the repository and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
