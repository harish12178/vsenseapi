﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace VSense.API.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param");

            migrationBuilder.DropForeignKey(
                name: "FK_t_device_assign_param_m_device_param_PramID",
                table: "t_device_assign_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param");

            migrationBuilder.AlterColumn<string>(
                name: "ParamID",
                table: "m_device_param",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeviceID",
                table: "m_device_param",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param",
                column: "ParamID");

            migrationBuilder.CreateIndex(
                name: "IX_m_device_param_DeviceID",
                table: "m_device_param",
                column: "DeviceID");

            migrationBuilder.AddForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param",
                column: "DeviceID",
                principalTable: "m_device",
                principalColumn: "DeviceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_t_device_assign_param_m_device_param_PramID",
                table: "t_device_assign_param",
                column: "PramID",
                principalTable: "m_device_param",
                principalColumn: "ParamID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param");

            migrationBuilder.DropForeignKey(
                name: "FK_t_device_assign_param_m_device_param_PramID",
                table: "t_device_assign_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param");

            migrationBuilder.DropIndex(
                name: "IX_m_device_param_DeviceID",
                table: "m_device_param");

            migrationBuilder.AlterColumn<string>(
                name: "DeviceID",
                table: "m_device_param",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParamID",
                table: "m_device_param",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param",
                column: "DeviceID");

            migrationBuilder.AddForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param",
                column: "DeviceID",
                principalTable: "m_device",
                principalColumn: "DeviceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_device_assign_param_m_device_param_PramID",
                table: "t_device_assign_param",
                column: "PramID",
                principalTable: "m_device_param",
                principalColumn: "DeviceID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
