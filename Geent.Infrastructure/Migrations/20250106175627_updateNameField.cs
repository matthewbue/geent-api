using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Geent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateNameField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubTitle",
                table: "Post",
                newName: "Category");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImagesPost",
                table: "Post",
                type: "bytea",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagesPost",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Post",
                newName: "SubTitle");
        }
    }
}
