using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogys_Winforms.Migrations
{
    /// <inheritdoc />
    public partial class revisedtable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentDays",
                table: "Rent",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentDays",
                table: "Rent");
        }
    }
}
