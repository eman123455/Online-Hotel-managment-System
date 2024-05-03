﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Hotel_Managment_System;

#nullable disable

namespace Online_Hotel_Managment_System.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Customer", b =>
                {
                    b.Property<int>("Cust_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cust_Id"));

                    b.Property<DateTime>("BD")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Room_ID")
                        .HasColumnType("int");

                    b.HasKey("Cust_Id");

                    b.HasIndex("Room_ID");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.CustomerMobile", b =>
                {
                    b.Property<int>("customerID")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerMob")
                        .HasColumnType("int");

                    b.HasKey("customerID", "CustomerMob");

                    b.ToTable("customersMobile");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.EmpMobile", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("Mobile_No")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID", "Mobile_No");

                    b.ToTable("empMobiles");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Employee", b =>
                {
                    b.Property<int>("Emp_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Emp_ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("job_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_ID");

                    b.HasIndex("HotelId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"));

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelId");

                    b.ToTable("hotels");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Room", b =>
                {
                    b.Property<int>("Room_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Room_ID"));

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("Room_State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Room_ID");

                    b.HasIndex("HotelId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Customer", b =>
                {
                    b.HasOne("Online_Hotel_Managment_System.Models.Room", "Room")
                        .WithMany("Customer")
                        .HasForeignKey("Room_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Employee", b =>
                {
                    b.HasOne("Online_Hotel_Managment_System.Models.Hotel", "hotel")
                        .WithMany("Employees")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hotel");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Room", b =>
                {
                    b.HasOne("Online_Hotel_Managment_System.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Hotel", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Online_Hotel_Managment_System.Models.Room", b =>
                {
                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}