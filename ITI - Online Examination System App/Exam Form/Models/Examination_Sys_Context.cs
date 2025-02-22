﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Exam_Form.Models;

public partial class Examination_Sys_Context : DbContext
{
    public Examination_Sys_Context()
    {
    }

    public Examination_Sys_Context(DbContextOptions<Examination_Sys_Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionOption> QuestionOptions { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentAnswer> StudentAnswers { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-AN2B1CQ;Initial Catalog=Examination_Sys;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasOne(d => d.BranchNoNavigation).WithMany(p => p.Departments).HasConstraintName("FK_Department_Branch");

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Department_Instructor");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Exam_Course");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.Instructors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Instructor_Department");

            entity.HasOne(d => d.InstructorEmailNavigation).WithOne(p => p.Instructor)
                .HasPrincipalKey<User>(p => p.Email)
                .HasForeignKey<Instructor>(d => d.InstructorEmail)
                .HasConstraintName("FK_Instructor_Users1");

            entity.HasMany(d => d.Courses).WithMany(p => p.Instructors)
                .UsingEntity<Dictionary<string, object>>(
                    "InstructorCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Instructor_Course_Course"),
                    l => l.HasOne<Instructor>().WithMany()
                        .HasForeignKey("InstructorId")
                        .HasConstraintName("FK_Instructor_Course_Instructor"),
                    j =>
                    {
                        j.HasKey("InstructorId", "CourseId");
                        j.ToTable("Instructor_Course");
                        j.IndexerProperty<int>("InstructorId").HasColumnName("Instructor_Id");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_Id");
                    });
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasOne(d => d.Course).WithMany(p => p.Questions).HasConstraintName("FK_Question_Course");
        });

        modelBuilder.Entity<QuestionOption>(entity =>
        {
            entity.HasOne(d => d.Question).WithMany(p => p.QuestionOptions).HasConstraintName("FK_Question_Options_Question");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.StudentId).ValueGeneratedNever();

            entity.HasOne(d => d.StudentEmailNavigation).WithOne(p => p.Student)
                .HasPrincipalKey<User>(p => p.Email)
                .HasForeignKey<Student>(d => d.StudentEmail)
                .HasConstraintName("FK_Student_Users");

            entity.HasOne(d => d.Track).WithMany(p => p.Students).HasConstraintName("FK_Student_Track");
        });

        modelBuilder.Entity<StudentAnswer>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.ExamId, e.QuestionId }).HasName("PK_Sudent_Answer");

            entity.HasOne(d => d.Exam).WithMany(p => p.StudentAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sudent_Answer_Exam");

            entity.HasOne(d => d.Question).WithMany(p => p.StudentAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sudent_Answer_Question");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentAnswers).HasConstraintName("FK_Sudent_Answer_Student");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses).HasConstraintName("FK_Student_Course_Course");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCourses).HasConstraintName("FK_Student_Course_Student");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => new { e.CourseId, e.TopicName }).HasName("PK_Topic_1");

            entity.HasOne(d => d.Course).WithMany(p => p.Topics).HasConstraintName("FK_Topic_Course");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.Property(e => e.TrackId).ValueGeneratedNever();

            entity.HasOne(d => d.Dept).WithMany(p => p.Tracks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Track_Department");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}