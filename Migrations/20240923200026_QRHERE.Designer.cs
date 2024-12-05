﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test_Data.Models;

#nullable disable

namespace test_Data.Migrations
{
    [DbContext(typeof(DemoContext))]
    [Migration("20240923200026_QRHERE")]
    partial class QRHERE
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("test_Data.Models.AccountModel", b =>
                {
                    b.Property<int>("acID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("aID")
                        .HasColumnType("TEXT");

                    b.Property<string>("acPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("acPosition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("acUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("pID")
                        .HasColumnType("TEXT");

                    b.Property<string>("tID")
                        .HasColumnType("TEXT");

                    b.HasKey("acID");

                    b.HasIndex("acUsername")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("test_Data.Models.AdminModel", b =>
                {
                    b.Property<int>("aID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("aName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("aSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("acID")
                        .HasColumnType("TEXT");

                    b.HasKey("aID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("test_Data.Models.AttendanceModel", b =>
                {
                    b.Property<int>("atID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("atDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("atPresent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("atTimeIn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("atTimeOut")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sID")
                        .HasColumnType("TEXT");

                    b.HasKey("atID");

                    b.ToTable("Attendance");
                });

            modelBuilder.Entity("test_Data.Models.ChildModel", b =>
                {
                    b.Property<int>("sID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("atID")
                        .HasColumnType("TEXT");

                    b.Property<string>("pID")
                        .HasColumnType("TEXT");

                    b.Property<string>("sFormClass")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sQrcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("sSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("sID");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("test_Data.Models.ParentModel", b =>
                {
                    b.Property<int>("pID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("acID")
                        .HasColumnType("TEXT");

                    b.Property<string>("pEmergencyContactName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("pEmergencyPhoneNumber")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("pName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("pPhoneNumber")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("pSpouseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("pSpousePhoneNumber")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("pSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sID")
                        .HasColumnType("TEXT");

                    b.HasKey("pID");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("test_Data.Models.QRCodes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ScannedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("QRCodes");
                });

            modelBuilder.Entity("test_Data.Models.TeacherModel", b =>
                {
                    b.Property<int>("tID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("acID")
                        .HasColumnType("TEXT");

                    b.Property<string>("tFormClass")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("tName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("tSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("tID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("test_Data.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}