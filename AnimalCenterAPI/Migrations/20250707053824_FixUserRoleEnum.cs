using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalCenterAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixUserRoleEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserRole",
                value: "Admin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserRole",
                value: "volnteer");
        }
    }
}
