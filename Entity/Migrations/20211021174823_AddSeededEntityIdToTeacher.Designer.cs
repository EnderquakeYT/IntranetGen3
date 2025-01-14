﻿// <auto-generated />
using System;
using MensaGymnazium.IntranetGen3.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MensaGymnazium.IntranetGen3.Entity.Migrations
{
    [DbContext(typeof(IntranetGen3DbContext))]
    [Migration("20211021174823_AddSeededEntityIdToTeacher")]
    partial class AddSeededEntityIdToTeacher
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Havit.Data.EntityFrameworkCore.Model.DataSeedVersion", b =>
                {
                    b.Property<string>("ProfileName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileName")
                        .HasName("PK_DataSeed");

                    b.ToTable("__DataSeed");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Common.ApplicationSettings", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ApplicationSettings");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Symbol")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SeededEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<Guid?>("Oid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Oid")
                        .IsUnique()
                        .HasFilter("[Oid] IS NOT NULL");

                    b.HasIndex("StudentId")
                        .IsUnique()
                        .HasFilter("[StudentId] IS NOT NULL");

                    b.HasIndex("TeacherId")
                        .IsUnique()
                        .HasFilter("[TeacherId] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("SubjectCategory");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("SubjectType");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectTypeRelation", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectTypeId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "SubjectTypeId");

                    b.HasIndex("SubjectTypeId");

                    b.ToTable("SubjectTypeRelation");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Student", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.User", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Security.Student", "Student")
                        .WithOne("User")
                        .HasForeignKey("MensaGymnazium.IntranetGen3.Model.Security.User", "StudentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Security.Teacher", "Teacher")
                        .WithOne("User")
                        .HasForeignKey("MensaGymnazium.IntranetGen3.Model.Security.User", "TeacherId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Subject", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.SubjectCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.SubjectTypeRelation", b =>
                {
                    b.HasOne("MensaGymnazium.IntranetGen3.Model.Subject", "Subject")
                        .WithMany("TypeRelations")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MensaGymnazium.IntranetGen3.Model.SubjectType", "SubjectType")
                        .WithMany()
                        .HasForeignKey("SubjectTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("SubjectType");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Grade", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Student", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Security.Teacher", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("MensaGymnazium.IntranetGen3.Model.Subject", b =>
                {
                    b.Navigation("TypeRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
