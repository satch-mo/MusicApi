using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicApi.Migrations
{
    public partial class SeedSongsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, "2:12", "Punk", "May 16th" },
                    { 2, "3:12", "Punk", "Fall Back Down" },
                    { 3, "3:15", "Punk", "Sophomore Slump or Comeback of the Year" },
                    { 4, "1:56", "Punk", "Red Hot Moon" },
                    { 5, "2:17", "Metal", "Sabbath Bloody Sabbath" },
                    { 6, "2:46", "Blues", "Alabama Bound" },
                    { 7, "4:10", "Rocksteady", "Ain't No Joke Bein' Broke" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
