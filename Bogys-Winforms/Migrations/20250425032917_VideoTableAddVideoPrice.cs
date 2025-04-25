using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogys_Winforms.Migrations
{
    /// <inheritdoc />
    public partial class VideoTableAddVideoPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "VideoPrice",
                table: "Video",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoPrice",
                table: "Video");
        }
    }
}
