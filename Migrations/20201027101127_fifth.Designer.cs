﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VSense.API.Context;

namespace VSense.API.Migrations
{
    [DbContext(typeof(DeviceContext))]
    [Migration("20201027101127_fifth")]
    partial class fifth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VSense.API.Models.Device_log", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PramID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RefID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Threshold")
                        .HasColumnType("real");

                    b.Property<float>("avgValue")
                        .HasColumnType("real");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<float>("maxValue")
                        .HasColumnType("real");

                    b.Property<float>("minValue")
                        .HasColumnType("real");

                    b.Property<float>("value")
                        .HasColumnType("real");

                    b.HasKey("LogID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("PramID");

                    b.ToTable("Device_log");
                });

            modelBuilder.Entity("VSense.API.Models.m_Loc", b =>
                {
                    b.Property<string>("LocationID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Geo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LcoationText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParantLocationID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("isEnabled")
                        .HasColumnType("int");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("modifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("LocationID");

                    b.ToTable("m_Loc");
                });

            modelBuilder.Entity("VSense.API.Models.m_device", b =>
                {
                    b.Property<string>("DeviceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Battery")
                        .HasColumnType("int");

                    b.Property<int>("Healthy")
                        .HasColumnType("int");

                    b.Property<int>("Lifespan")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PuttoUse")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoftwareVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Vcc")
                        .HasColumnType("real");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("isEnabled")
                        .HasColumnType("int");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("modifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("DeviceID");

                    b.ToTable("m_device");
                });

            modelBuilder.Entity("VSense.API.Models.m_device_param", b =>
                {
                    b.Property<string>("DeviceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParamID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("isEnabled")
                        .HasColumnType("int");

                    b.Property<string>("isPercentage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("longText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("modifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("DeviceID", "ParamID");

                    b.ToTable("m_device_param");
                });

            modelBuilder.Entity("VSense.API.Models.m_equipment", b =>
                {
                    b.Property<string>("EquipmentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GeoLoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Workcenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("isEnabled")
                        .HasColumnType("int");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("modifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("EquipmentID");

                    b.ToTable("m_equipment");
                });

            modelBuilder.Entity("VSense.API.Models.t_device_assign", b =>
                {
                    b.Property<int>("assignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EquipmentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<string>("LocID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("enDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("isEnabled")
                        .HasColumnType("int");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("modifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("assignmentID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("LocID");

                    b.ToTable("t_device_assign");
                });

            modelBuilder.Entity("VSense.API.Models.t_device_assign_param", b =>
                {
                    b.Property<string>("PramID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityGraphTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Hard_1_Exception_Threshold")
                        .HasColumnType("real");

                    b.Property<float>("Hard_2_Exception_Threshold")
                        .HasColumnType("real");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Max")
                        .HasColumnType("real");

                    b.Property<float>("Min")
                        .HasColumnType("real");

                    b.Property<float>("Soft_1_Exception_Threshold")
                        .HasColumnType("real");

                    b.Property<float>("Soft_2_Exception_Threshold")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assignmentID")
                        .HasColumnType("int");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("isEnabled")
                        .HasColumnType("int");

                    b.Property<string>("longText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("modifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("PramID");

                    b.HasIndex("assignmentID");

                    b.ToTable("t_device_assign_param");
                });

            modelBuilder.Entity("VSense.API.Models.Device_log", b =>
                {
                    b.HasOne("VSense.API.Models.m_device", "device")
                        .WithMany()
                        .HasForeignKey("DeviceID");

                    b.HasOne("VSense.API.Models.t_device_assign_param", "device_Assign_Param")
                        .WithMany()
                        .HasForeignKey("PramID");
                });

            modelBuilder.Entity("VSense.API.Models.m_device_param", b =>
                {
                    b.HasOne("VSense.API.Models.m_device", "device")
                        .WithMany()
                        .HasForeignKey("DeviceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VSense.API.Models.t_device_assign", b =>
                {
                    b.HasOne("VSense.API.Models.m_device", "device")
                        .WithMany()
                        .HasForeignKey("DeviceID");

                    b.HasOne("VSense.API.Models.m_equipment", "equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentID");

                    b.HasOne("VSense.API.Models.m_Loc", "location")
                        .WithMany()
                        .HasForeignKey("LocID");
                });

            modelBuilder.Entity("VSense.API.Models.t_device_assign_param", b =>
                {
                    b.HasOne("VSense.API.Models.t_device_assign", "device_assign")
                        .WithMany()
                        .HasForeignKey("assignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}