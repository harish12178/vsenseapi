using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VSense.API.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_trkdo_assign");

            migrationBuilder.DropTable(
                name: "t_TrkDoLog");

            migrationBuilder.DropTable(
                name: "m_TrkDo");

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "t_device_assign_param",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdOn",
                table: "t_device_assign_param",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isEnabled",
                table: "t_device_assign_param",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedBy",
                table: "t_device_assign_param",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedOn",
                table: "t_device_assign_param",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "t_device_assign",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdOn",
                table: "t_device_assign",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isEnabled",
                table: "t_device_assign",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedBy",
                table: "t_device_assign",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedOn",
                table: "t_device_assign",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "m_Loc",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdOn",
                table: "m_Loc",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isEnabled",
                table: "m_Loc",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedBy",
                table: "m_Loc",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedOn",
                table: "m_Loc",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "m_equipment",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdOn",
                table: "m_equipment",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isEnabled",
                table: "m_equipment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedBy",
                table: "m_equipment",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedOn",
                table: "m_equipment",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "m_device_param",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdOn",
                table: "m_device_param",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isEnabled",
                table: "m_device_param",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedBy",
                table: "m_device_param",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedOn",
                table: "m_device_param",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "m_device",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdOn",
                table: "m_device",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isEnabled",
                table: "m_device",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "modifiedBy",
                table: "m_device",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedOn",
                table: "m_device",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "t_device_assign_param");

            migrationBuilder.DropColumn(
                name: "createdOn",
                table: "t_device_assign_param");

            migrationBuilder.DropColumn(
                name: "isEnabled",
                table: "t_device_assign_param");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "t_device_assign_param");

            migrationBuilder.DropColumn(
                name: "modifiedOn",
                table: "t_device_assign_param");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "t_device_assign");

            migrationBuilder.DropColumn(
                name: "createdOn",
                table: "t_device_assign");

            migrationBuilder.DropColumn(
                name: "isEnabled",
                table: "t_device_assign");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "t_device_assign");

            migrationBuilder.DropColumn(
                name: "modifiedOn",
                table: "t_device_assign");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "m_Loc");

            migrationBuilder.DropColumn(
                name: "createdOn",
                table: "m_Loc");

            migrationBuilder.DropColumn(
                name: "isEnabled",
                table: "m_Loc");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "m_Loc");

            migrationBuilder.DropColumn(
                name: "modifiedOn",
                table: "m_Loc");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "m_equipment");

            migrationBuilder.DropColumn(
                name: "createdOn",
                table: "m_equipment");

            migrationBuilder.DropColumn(
                name: "isEnabled",
                table: "m_equipment");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "m_equipment");

            migrationBuilder.DropColumn(
                name: "modifiedOn",
                table: "m_equipment");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "m_device_param");

            migrationBuilder.DropColumn(
                name: "createdOn",
                table: "m_device_param");

            migrationBuilder.DropColumn(
                name: "isEnabled",
                table: "m_device_param");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "m_device_param");

            migrationBuilder.DropColumn(
                name: "modifiedOn",
                table: "m_device_param");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "m_device");

            migrationBuilder.DropColumn(
                name: "createdOn",
                table: "m_device");

            migrationBuilder.DropColumn(
                name: "isEnabled",
                table: "m_device");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "m_device");

            migrationBuilder.DropColumn(
                name: "modifiedOn",
                table: "m_device");

            migrationBuilder.CreateTable(
                name: "m_TrkDo",
                columns: table => new
                {
                    TrkDoID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LifeStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniqueID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isAssinged = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_TrkDo", x => x.TrkDoID);
                });

            migrationBuilder.CreateTable(
                name: "t_trkdo_assign",
                columns: table => new
                {
                    TransID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssingedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Object = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjectNumber = table.Column<int>(type: "int", nullable: false),
                    RemovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrkDoID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    isOpen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_trkdo_assign", x => x.TransID);
                    table.ForeignKey(
                        name: "FK_t_trkdo_assign_m_TrkDo_TrkDoID",
                        column: x => x.TrkDoID,
                        principalTable: "m_TrkDo",
                        principalColumn: "TrkDoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_TrkDoLog",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrkDoID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_TrkDoLog", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_t_TrkDoLog_m_device_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "m_device",
                        principalColumn: "DeviceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_TrkDoLog_m_TrkDo_TrkDoID",
                        column: x => x.TrkDoID,
                        principalTable: "m_TrkDo",
                        principalColumn: "TrkDoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_trkdo_assign_TrkDoID",
                table: "t_trkdo_assign",
                column: "TrkDoID");

            migrationBuilder.CreateIndex(
                name: "IX_t_TrkDoLog_DeviceID",
                table: "t_TrkDoLog",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_t_TrkDoLog_TrkDoID",
                table: "t_TrkDoLog",
                column: "TrkDoID");
        }
    }
}
