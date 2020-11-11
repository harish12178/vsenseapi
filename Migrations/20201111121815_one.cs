using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace VSense.API.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Device_log",
                columns: table => new
                {
                    LogID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeviceID = table.Column<string>(nullable: true),
                    RefID = table.Column<string>(nullable: true),
                    dateTime = table.Column<DateTime>(nullable: false),
                    PramID = table.Column<string>(nullable: true),
                    value = table.Column<float>(nullable: false),
                    minValue = table.Column<float>(nullable: false),
                    maxValue = table.Column<float>(nullable: false),
                    avgValue = table.Column<float>(nullable: false),
                    Threshold = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device_log", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "m_device",
                columns: table => new
                {
                    DeviceID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    PuttoUse = table.Column<DateTime>(nullable: false),
                    Battery = table.Column<int>(nullable: false),
                    Healthy = table.Column<int>(nullable: false),
                    SoftwareVersion = table.Column<string>(nullable: true),
                    Vcc = table.Column<float>(nullable: false),
                    Lifespan = table.Column<int>(nullable: false),
                    isEnabled = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true),
                    modifiedOn = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_device", x => x.DeviceID);
                });

            migrationBuilder.CreateTable(
                name: "m_equipment",
                columns: table => new
                {
                    EquipmentID = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    GeoLoc = table.Column<string>(nullable: true),
                    Plant = table.Column<string>(nullable: true),
                    Workcenter = table.Column<string>(nullable: true),
                    isEnabled = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true),
                    modifiedOn = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_equipment", x => x.EquipmentID);
                });

            migrationBuilder.CreateTable(
                name: "m_Loc",
                columns: table => new
                {
                    LocationID = table.Column<string>(nullable: false),
                    LcoationText = table.Column<string>(nullable: true),
                    WorkCenter = table.Column<string>(nullable: true),
                    Plant = table.Column<string>(nullable: true),
                    Geo = table.Column<string>(nullable: true),
                    ParantLocationID = table.Column<string>(nullable: true),
                    isEnabled = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true),
                    modifiedOn = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_Loc", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "m_device_param",
                columns: table => new
                {
                    ParamID = table.Column<string>(nullable: false),
                    DeviceID = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    longText = table.Column<string>(nullable: true),
                    Max = table.Column<int>(nullable: false),
                    Min = table.Column<int>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    isPercentage = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    isEnabled = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true),
                    modifiedOn = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_device_param", x => x.ParamID);
                    table.ForeignKey(
                        name: "FK_m_device_param_m_device_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "m_device",
                        principalColumn: "DeviceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_device_assign",
                columns: table => new
                {
                    assignmentID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeviceID = table.Column<string>(nullable: true),
                    EquipmentID = table.Column<string>(nullable: true),
                    StDateTime = table.Column<DateTime>(nullable: false),
                    enDateTime = table.Column<DateTime>(nullable: false),
                    Frequency = table.Column<int>(nullable: false),
                    LocID = table.Column<string>(nullable: true),
                    isEnabled = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true),
                    modifiedOn = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_device_assign", x => x.assignmentID);
                    table.ForeignKey(
                        name: "FK_t_device_assign_m_device_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "m_device",
                        principalColumn: "DeviceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_device_assign_m_equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "m_equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_device_assign_m_Loc_LocID",
                        column: x => x.LocID,
                        principalTable: "m_Loc",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_device_assign_param",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    assignmentID = table.Column<int>(nullable: false),
                    PramID = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    longText = table.Column<string>(nullable: true),
                    Max = table.Column<float>(nullable: false),
                    Min = table.Column<float>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Soft_1_Exception_Threshold = table.Column<float>(nullable: false),
                    Soft_2_Exception_Threshold = table.Column<float>(nullable: false),
                    Hard_1_Exception_Threshold = table.Column<float>(nullable: false),
                    Hard_2_Exception_Threshold = table.Column<float>(nullable: false),
                    ActivityGraphTitle = table.Column<string>(nullable: true),
                    isEnabled = table.Column<bool>(nullable: false),
                    createdOn = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<string>(nullable: true),
                    modifiedOn = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_device_assign_param", x => x.ID);
                    table.ForeignKey(
                        name: "FK_t_device_assign_param_t_device_assign_assignmentID",
                        column: x => x.assignmentID,
                        principalTable: "t_device_assign",
                        principalColumn: "assignmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_m_device_param_DeviceID",
                table: "m_device_param",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_t_device_assign_DeviceID",
                table: "t_device_assign",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_t_device_assign_EquipmentID",
                table: "t_device_assign",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_t_device_assign_LocID",
                table: "t_device_assign",
                column: "LocID");

            migrationBuilder.CreateIndex(
                name: "IX_t_device_assign_param_assignmentID",
                table: "t_device_assign_param",
                column: "assignmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device_log");

            migrationBuilder.DropTable(
                name: "m_device_param");

            migrationBuilder.DropTable(
                name: "t_device_assign_param");

            migrationBuilder.DropTable(
                name: "t_device_assign");

            migrationBuilder.DropTable(
                name: "m_device");

            migrationBuilder.DropTable(
                name: "m_equipment");

            migrationBuilder.DropTable(
                name: "m_Loc");
        }
    }
}
