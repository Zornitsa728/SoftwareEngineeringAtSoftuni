using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CInemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToCinema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CinemasMovies",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "ImageUrl", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("2ead316a-7060-448a-9922-8625b29846b5"), "/images/cinema-burgas.jpg", "Plovdiv", "Cinema City" },
                    { new Guid("4da550db-cb50-4809-9933-101bd374a771"), "/images/cinema-ruse.jpg", "Rousse", "Cinema City" },
                    { new Guid("57fa488e-20d4-4417-bf86-6a77c0ac101c"), "/images/cinema-varna.png", "Varna", "CinemaMax" },
                    { new Guid("b92ccdda-af19-4c4b-bae1-935ee78ec07d"), "/images/cinema-sofia.jpeg", "Sofia", "Cinema" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("4968c574-222f-4f1c-b0da-72a25fb20496"), "Twilight is a 2008 American romantic fantasy film directed by Catherine Hardwicke from a screenplay by Melissa Rosenberg, based on the 2005 novel of the same name by Stephenie Meyer. It is the first installment in The Twilight Saga film series.", "Catherine Hardwicke", 121, "Fantasy", new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twilight" },
                    { new Guid("76927553-2388-4312-bbca-5384e6a4b7aa"), "In his fourth year at Hogwarts, Harry must reluctantly compete in an ancient wizard tournament after someone mysteriously selects his name, while the Dark Lord secretly conspires something sinister.", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("2ead316a-7060-448a-9922-8625b29846b5"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("4da550db-cb50-4809-9933-101bd374a771"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("57fa488e-20d4-4417-bf86-6a77c0ac101c"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("b92ccdda-af19-4c4b-bae1-935ee78ec07d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4968c574-222f-4f1c-b0da-72a25fb20496"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("76927553-2388-4312-bbca-5384e6a4b7aa"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cinemas");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CinemasMovies",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

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
    }
}
