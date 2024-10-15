using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CInemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "ImageUrl", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("11963540-aa26-47d7-bb3d-b781bf56940b"), "/images/cinema-varna.png", "Varna", "CinemaMax" },
                    { new Guid("2d21ccde-dbfc-406d-a937-b72afae45fba"), "/images/cinema-ruse.jpg", "Ruse", "Cinema City" },
                    { new Guid("34a43dec-7ee3-49e6-9a78-777e05e8a709"), "/images/cinema-plovdiv.jpg", "Plovdiv", "Cinema City" },
                    { new Guid("c97563d4-39e5-47f3-8e02-3fa18b2b95dd"), "/images/cinema-sofia.jpeg", "Sofia", "Cinema" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("be880494-cdc1-4e17-9269-7e2dad6c844e"), "In his fourth year at Hogwarts, Harry must reluctantly compete in an ancient wizard tournament after someone mysteriously selects his name, while the Dark Lord secretly conspires something sinister.", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" },
                    { new Guid("d4980ca2-737f-4697-bea0-3c91e2bbff26"), "Twilight is a 2008 American romantic fantasy film directed by Catherine Hardwicke from a screenplay by Melissa Rosenberg, based on the 2005 novel of the same name by Stephenie Meyer. It is the first installment in The Twilight Saga film series.", "Catherine Hardwicke", 121, "Fantasy", new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twilight" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("11963540-aa26-47d7-bb3d-b781bf56940b"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("2d21ccde-dbfc-406d-a937-b72afae45fba"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("34a43dec-7ee3-49e6-9a78-777e05e8a709"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("c97563d4-39e5-47f3-8e02-3fa18b2b95dd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("be880494-cdc1-4e17-9269-7e2dad6c844e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d4980ca2-737f-4697-bea0-3c91e2bbff26"));

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
    }
}
