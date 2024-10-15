using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CInemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCinemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5848c2c9-bfeb-4cea-8ae1-4c3a206ee921"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9c18a99d-4be2-4566-b13e-692b8a6c13d8"));

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CinemasMovies",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CinemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemasMovies", x => new { x.MovieId, x.CinemaId });
                    table.ForeignKey(
                        name: "FK_CinemasMovies_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CinemasMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("0b9a3704-7bee-4f92-9342-d20aed012958"), "Plovdiv", "Cinema City" },
                    { new Guid("3dc8d241-8aed-45fa-b377-5feb2a473b66"), "Varna", "CinemaMax" },
                    { new Guid("50d3e522-1ea5-4acd-afc1-54d4a5ddbcbe"), "Rousse", "Cinema City" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("4df06f2d-ba77-4c97-92b0-472935ffde9c"), "Twilight is a 2008 American romantic fantasy film directed by Catherine Hardwicke from a screenplay by Melissa Rosenberg, based on the 2005 novel of the same name by Stephenie Meyer. It is the first installment in The Twilight Saga film series.", "Catherine Hardwicke", 121, "Fantasy", new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twilight" },
                    { new Guid("6e79eb68-fb44-4946-93d2-5fa03d2a6f24"), "In his fourth year at Hogwarts, Harry must reluctantly compete in an ancient wizard tournament after someone mysteriously selects his name, while the Dark Lord secretly conspires something sinister.", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CinemasMovies_CinemaId",
                table: "CinemasMovies",
                column: "CinemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CinemasMovies");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4df06f2d-ba77-4c97-92b0-472935ffde9c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6e79eb68-fb44-4946-93d2-5fa03d2a6f24"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("5848c2c9-bfeb-4cea-8ae1-4c3a206ee921"), "In his fourth year at Hogwarts, Harry must reluctantly compete in an ancient wizard tournament after someone mysteriously selects his name, while the Dark Lord secretly conspires something sinister.", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" },
                    { new Guid("9c18a99d-4be2-4566-b13e-692b8a6c13d8"), "Twilight is a 2008 American romantic fantasy film directed by Catherine Hardwicke from a screenplay by Melissa Rosenberg, based on the 2005 novel of the same name by Stephenie Meyer. It is the first installment in The Twilight Saga film series.", "Catherine Hardwicke", 121, "Fantasy", new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twilight" }
                });
        }
    }
}
