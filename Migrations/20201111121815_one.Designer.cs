﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VSense.API.Context;

namespace VSense.API.Migrations
{
    [DbContext(typeof(DeviceContext))]
    [Migration("20201111121815_one")]
    partial class one
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("VSense.API.Models.Device_log", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DeviceID")
                        .HasColumnType("text");

                    b.Property<string>("PramID")
                        .HasColumnType("text");

                    b.Property<string>("RefID")
                        .HasColumnType("text");

                    b.Property<float>("Threshold")
                        .HasColumnType("real");

                    b.Property<float>("avgValue")
                        .HasColumnType("real");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float>("maxValue")
                        .HasColumnType("real");

                    b.Property<float>("minValue")
                        .HasColumnType("real");

                    b.Property<float>("value")
                        .HasColumnType("real");

                    b.HasKey("LogID");

                    b.ToTable("Device_log");
                });

            modelBuilder.Entity("VSense.API.Models.m_Loc", b =>
                {
                    b.Property<string>("LocationID")
                        .HasColumnType("text");

                    b.Property<string>("Geo")
                        .HasColumnType("text");

                    b.Property<string>("LcoationText")
                        .HasColumnType("text");

                    b.Property<string>("ParantLocationID")
                        .HasColumnType("text");

                    b.Property<string>("Plant")
                        .HasColumnType("text");

                    b.Property<string>("WorkCenter")
                        .HasColumnType("text");

                    b.Property<string>("createdBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("modifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("LocationID");

                    b.ToTable("m_Loc");
                });

            modelBuilder.Entity("VSense.API.Models.m_device", b =>
                {
                    b.Property<string>("DeviceID")
                        .HasColumnType("text");

                    b.Property<int>("Battery")
                        .HasColumnType("integer");

                    b.Property<int>("Healthy")
                        .HasColumnType("integer");

                    b.Property<int>("Lifespan")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Purpose")
                        .HasColumnType("text");

                    b.Property<DateTime>("PuttoUse")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SoftwareVersion")
                        .HasColumnType("text");

                    b.Property<float>("Vcc")
                        .HasColumnType("real");

                    b.Property<string>("createdBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("modifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("DeviceID");

                    b.ToTable("m_device");
                });

            modelBuilder.Entity("VSense.API.Models.m_device_param", b =>
                {
                    b.Property<string>("ParamID")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("DeviceID")
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<int>("Max")
                        .HasColumnType("integer");

                    b.Property<int>("Min")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<string>("createdBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("isPercentage")
                        .HasColumnType("text");

                    b.Property<string>("longText")
                        .HasColumnType("text");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("modifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ParamID");

                    b.HasIndex("DeviceID");

                    b.ToTable("m_device_param");
                });

            modelBuilder.Entity("VSense.API.Models.m_equipment", b =>
                {
                    b.Property<string>("EquipmentID")
                        .HasColumnType("text");

                    b.Property<string>("GeoLoc")
                        .HasColumnType("text");

                    b.Property<string>("Plant")
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<string>("Workcenter")
                        .HasColumnType("text");

                    b.Property<string>("createdBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("modifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("EquipmentID");

                    b.ToTable("m_equipment");
                });

            modelBuilder.Entity("VSense.API.Models.t_device_assign", b =>
                {
                    b.Property<int>("assignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DeviceID")
                        .HasColumnType("text");

                    b.Property<string>("EquipmentID")
                        .HasColumnType("text");

                    b.Property<int>("Frequency")
                        .HasColumnType("integer");

                    b.Property<string>("LocID")
                        .HasColumnType("text");

                    b.Property<DateTime>("StDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("enDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("modifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("assignmentID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("LocID");

                    b.ToTable("t_device_assign");
                });

            modelBuilder.Entity("VSense.API.Models.t_device_assign_param", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ActivityGraphTitle")
                        .HasColumnType("text");

                    b.Property<float>("Hard_1_Exception_Threshold")
                        .HasColumnType("real");

                    b.Property<float>("Hard_2_Exception_Threshold")
                        .HasColumnType("real");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<float>("Max")
                        .HasColumnType("real");

                    b.Property<float>("Min")
                        .HasColumnType("real");

                    b.Property<string>("PramID")
                        .HasColumnType("text");

                    b.Property<float>("Soft_1_Exception_Threshold")
                        .HasColumnType("real");

                    b.Property<float>("Soft_2_Exception_Threshold")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<int>("assignmentID")
                        .HasColumnType("integer");

                    b.Property<string>("createdBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("longText")
                        .HasColumnType("text");

                    b.Property<string>("modifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("modifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ID");

                    b.HasIndex("assignmentID");

                    b.ToTable("t_device_assign_param");
                });

            modelBuilder.Entity("VSense.API.Models.m_device_param", b =>
                {
                    b.HasOne("VSense.API.Models.m_device", "device")
                        .WithMany("deviceParams")
                        .HasForeignKey("DeviceID");
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