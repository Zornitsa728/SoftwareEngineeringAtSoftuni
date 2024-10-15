using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CInemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SoftDeleteCinemasMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("0b9a3704-7bee-4f92-9342-d20aed012958"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("3dc8d241-8aed-45fa-b377-5feb2a473b66"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("50d3e522-1ea5-4acd-afc1-54d4a5ddbcbe"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4df06f2d-ba77-4c97-92b0-472935ffde9c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6e79eb68-fb44-4946-93d2-5fa03d2a6f24"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CinemasMovies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("0688056c-3f9e-42ee-9a57-ca8456194409"), "Rousse", "Cinema City" },
                    { new Guid("38f60f2c-dbaf-40b4-b9d8-03374ee411bc"), "Varna", "CinemaMax" },
                    { new Guid("e174ae03-cdd9-480f-86cb-d3ba4de83878"), "Plovdiv", "Cinema City" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("5c7f1464-0141-48b9-92a9-f90f4f7c34c7"), "In his fourth year at Hogwarts, Harry must reluctantly compete in an ancient wizard tournament after someone mysteriously selects his name, while the Dark Lord secretly conspires something sinister.", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" },
                    { new Guid("99af3b0c-2601-4624-808f-c7bb546c50a8"), "Twilight is a 2008 American romantic fantasy film directed by Catherine Hardwicke from a screenplay by Melissa Rosenberg, based on the 2005 novel of the same name by Stephenie Meyer. It is the first installment in The Twilight Saga film series.", "Catherine Hardwicke", 121, "Fantasy", new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twilight" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("0688056c-3f9e-42ee-9a57-ca8456194409"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("38f60f2c-dbaf-40b4-b9d8-03374ee411bc"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("e174ae03-cdd9-480f-86cb-d3ba4de83878"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5c7f1464-0141-48b9-92a9-f90f4f7c34c7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("99af3b0c-2601-4624-808f-c7bb546c50a8"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CinemasMovies");

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
        }
    }
}
