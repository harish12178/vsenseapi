using Microsoft.EntityFrameworkCore.Migrations;

namespace VSense.API.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param");

            migrationBuilder.AlterColumn<string>(
                name: "ParamID",
                table: "m_device_param",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param",
                column: "DeviceID");

            migrationBuilder.AddForeignKey(
                name: "FK_t_device_assign_param_m_device_param_PramID",
                table: "t_device_assign_param",
                column: "PramID",
                principalTable: "m_device_param",
                principalColumn: "DeviceID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_device_assign_param_m_device_param_PramID",
                table: "t_device_assign_param");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param");

            migrationBuilder.AlterColumn<string>(
                name: "ParamID",
                table: "m_device_param",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_device_param",
                table: "m_device_param",
                columns: new[] { "DeviceID", "ParamID" });
        }
    }
}
