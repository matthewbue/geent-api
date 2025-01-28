using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Geent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class insertcolumntype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Midia",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Midia");
        }
    }
}
