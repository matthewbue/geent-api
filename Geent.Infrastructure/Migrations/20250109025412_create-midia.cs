using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Geent.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class createmidia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "ImagesPost",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Post",
                newName: "TipoMidia");

            migrationBuilder.RenameColumn(
                name: "LikeTotal",
                table: "Post",
                newName: "Nota");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Post",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Post",
                newName: "Descricao");

            migrationBuilder.AddColumn<int>(
                name: "MidiaId",
                table: "Post",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Midia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Summary = table.Column<string>(type: "text", nullable: true),
                    UrlImage = table.Column<string>(type: "text", nullable: true),
                    FirstReleaseDate = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midia", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_MidiaId",
                table: "Post",
                column: "MidiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Midia_MidiaId",
                table: "Post",
                column: "MidiaId",
                principalTable: "Midia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Midia_MidiaId",
                table: "Post");

            migrationBuilder.DropTable(
                name: "Midia");

            migrationBuilder.DropIndex(
                name: "IX_Post_MidiaId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "MidiaId",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "TipoMidia",
                table: "Post",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Nota",
                table: "Post",
                newName: "LikeTotal");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Post",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Post",
                newName: "Category");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Post",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "ImagesPost",
                table: "Post",
                type: "bytea",
                nullable: true);
        }
    }
}
