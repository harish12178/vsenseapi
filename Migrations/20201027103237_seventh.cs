using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VSense.API.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isEnabled",
                table: "t_device_assign_param",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "t_device_assign_param",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isEnabled",
                table: "t_device_assign",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "t_device_assign",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isEnabled",
                table: "m_Loc",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "m_Loc",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isEnabled",
                table: "m_equipment",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "m_equipment",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isEnabled",
                table: "m_device_param",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "m_device_param",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isEnabled",
                table: "m_device",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "m_device",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "isEnabled",
                table: "t_device_assign_param",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "t_device_assign_param",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "isEnabled",
                table: "t_device_assign",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "t_device_assign",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "isEnabled",
                table: "m_Loc",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "m_Loc",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "isEnabled",
                table: "m_equipment",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "m_equipment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "isEnabled",
                table: "m_device_param",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "m_device_param",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "isEnabled",
                table: "m_device",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "m_device",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
