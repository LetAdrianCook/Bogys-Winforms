using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogys_Winforms.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationAddedStatusAttributeRent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Rent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rent");
        }
    }
}
