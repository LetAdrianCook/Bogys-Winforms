using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogys_Winforms.Migrations
{
    /// <inheritdoc />
    public partial class revisedtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentDays",
                table: "Rent");

            migrationBuilder.AddColumn<int>(
                name: "RentDays",
                table: "Video",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phonenumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentDays",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phonenumber",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "RentDays",
                table: "Rent",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
