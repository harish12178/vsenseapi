using Microsoft.EntityFrameworkCore.Migrations;

namespace VSense.API.Migrations
{
    public partial class nine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param");

            migrationBuilder.AlterColumn<float>(
                name: "Soft_2_Exception_Threshold",
                table: "t_device_assign_param",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "Soft_1_Exception_Threshold",
                table: "t_device_assign_param",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "Min",
                table: "t_device_assign_param",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "Max",
                table: "t_device_assign_param",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "Hard_2_Exception_Threshold",
                table: "t_device_assign_param",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "Hard_1_Exception_Threshold",
                table: "t_device_assign_param",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_device_param_m_device_DeviceID",
                table: "m_device_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param");

            migrationBuilder.DropIndex(
                name: "IX_m_device_param_DeviceID",
                table: "m_device_param");

            migrationBuilder.AlterColumn<float>(
                name: "Soft_2_Exception_Threshold",
                table: "t_device_assign_param",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Soft_1_Exception_Threshold",
                table: "t_device_assign_param",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Min",
                table: "t_device_assign_param",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Max",
                table: "t_device_assign_param",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Hard_2_Exception_Threshold",
                table: "t_device_assign_param",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Hard_1_Exception_Threshold",
                table: "t_device_assign_param",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeviceID",
                table: "m_device_param",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
