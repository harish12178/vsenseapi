using Microsoft.EntityFrameworkCore.Migrations;

namespace VSense.API.Migrations
{
    public partial class ten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Device_log_m_device_DeviceID",
                table: "Device_log");

            migrationBuilder.DropForeignKey(
                name: "FK_Device_log_t_device_assign_param_PramID",
                table: "Device_log");

            migrationBuilder.DropForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_device_assign_param",
                table: "t_device_assign_param");

            migrationBuilder.DropIndex(
                name: "IX_t_device_assign_param_assignmentID",
                table: "t_device_assign_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param");

            migrationBuilder.DropIndex(
                name: "IX_m_device_param_DeviceID",
                table: "m_device_param");

            migrationBuilder.DropIndex(
                name: "IX_Device_log_DeviceID",
                table: "Device_log");

            migrationBuilder.DropIndex(
                name: "IX_Device_log_PramID",
                table: "Device_log");

            migrationBuilder.AlterColumn<string>(
                name: "DeviceID",
                table: "m_device_param",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PramID",
                table: "Device_log",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeviceID",
                table: "Device_log",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_device_assign_param",
                table: "t_device_assign_param",
                columns: new[] { "assignmentID", "PramID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param",
                columns: new[] { "DeviceID", "ParamID" });

            migrationBuilder.AddForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param",
                column: "DeviceID",
                principalTable: "m_device",
                principalColumn: "DeviceID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_device_assign_param",
                table: "t_device_assign_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param");

            migrationBuilder.AlterColumn<string>(
                name: "DeviceID",
                table: "m_device_param",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PramID",
                table: "Device_log",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeviceID",
                table: "Device_log",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_device_assign_param",
                table: "t_device_assign_param",
                column: "PramID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param",
                column: "ParamID");

            migrationBuilder.CreateIndex(
                name: "IX_t_device_assign_param_assignmentID",
                table: "t_device_assign_param",
                column: "assignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_m_device_param_DeviceID",
                table: "m_device_param",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_Device_log_DeviceID",
                table: "Device_log",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_Device_log_PramID",
                table: "Device_log",
                column: "PramID");

            migrationBuilder.AddForeignKey(
                name: "FK_Device_log_m_device_DeviceID",
                table: "Device_log",
                column: "DeviceID",
                principalTable: "m_device",
                principalColumn: "DeviceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Device_log_t_device_assign_param_PramID",
                table: "Device_log",
                column: "PramID",
                principalTable: "t_device_assign_param",
                principalColumn: "PramID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param",
                column: "DeviceID",
                principalTable: "m_device",
                principalColumn: "DeviceID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
