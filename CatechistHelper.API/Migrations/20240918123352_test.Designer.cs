﻿// <auto-generated />
using System;
using CatechistHelper.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatechistHelper.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240918123352_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("address");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("birth_place");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("email");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("father_name");

                    b.Property<string>("FatherPhone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("father_phone");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("fullname");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("gender");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("hashed_password");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_url");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("mother_name");

                    b.Property<string>("MotherPhone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("mother_phone");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("phone");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("role_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("account");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("candidate_id");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("application");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Candidate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("account_id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("city");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsTeachingBefore")
                        .HasColumnType("bit")
                        .HasColumnName("is_teaching_before");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("last_name");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("note");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("phone");

                    b.Property<int>("YearOfTeaching")
                        .HasColumnType("int")
                        .HasColumnName("year_of_teaching");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("candidate");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Interview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("application_id");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bit")
                        .HasColumnName("is_passed");

                    b.Property<DateTime>("MeetingTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("meeting_time");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("note");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("interview");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.InterviewProcess", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("application_id");

                    b.Property<int>("InterviewProcessStatus")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("interview_process");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("account_id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit")
                        .HasColumnName("is_public");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("post");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Recruiter", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("application_id");

                    b.HasKey("AccountId", "ApplicationId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("recruiter");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Account", b =>
                {
                    b.HasOne("CatechistHelper.Domain.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Application", b =>
                {
                    b.HasOne("CatechistHelper.Domain.Entities.Candidate", "Candidate")
                        .WithMany("Applications")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Candidate", b =>
                {
                    b.HasOne("CatechistHelper.Domain.Entities.Account", "Account")
                        .WithOne("Candidate")
                        .HasForeignKey("CatechistHelper.Domain.Entities.Candidate", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Interview", b =>
                {
                    b.HasOne("CatechistHelper.Domain.Entities.Application", "Application")
                        .WithMany("Interviews")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.InterviewProcess", b =>
                {
                    b.HasOne("CatechistHelper.Domain.Entities.Application", "Application")
                        .WithMany("InterviewProcesses")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Post", b =>
                {
                    b.HasOne("CatechistHelper.Domain.Entities.Account", "Account")
                        .WithMany("Posts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Recruiter", b =>
                {
                    b.HasOne("CatechistHelper.Domain.Entities.Account", "Account")
                        .WithMany("Recruiters")
                        .HasForeignKey("AccountId")
                        .IsRequired();

                    b.HasOne("CatechistHelper.Domain.Entities.Application", "Application")
                        .WithMany("Recruiters")
                        .HasForeignKey("ApplicationId")
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Application");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Account", b =>
                {
                    b.Navigation("Candidate");

                    b.Navigation("Posts");

                    b.Navigation("Recruiters");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Application", b =>
                {
                    b.Navigation("InterviewProcesses");

                    b.Navigation("Interviews");

                    b.Navigation("Recruiters");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Candidate", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("CatechistHelper.Domain.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
