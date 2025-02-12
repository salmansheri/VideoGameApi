using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Developer", "Platform", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Insomniac Games", "PS5", "Sony Interactive Entertainment", "Spider-Man 2" },
                    { 2, "Nintendo EPD", "Nintendo Switch", "Nintendo", "The Legend of Zelda: Breath of the Wild" },
                    { 3, "Santa Monica Studio", "PS5", "Sony Interactive Entertainment", "God of War Ragnarok" },
                    { 4, "343 Industries", "Xbox Series X", "Xbox Game Studios", "Halo Infinite" },
                    { 5, "CD Projekt Red", "PC", "CD Projekt", "Cyberpunk 2077" },
                    { 6, "FromSoftware", "PS5, Xbox Series X, PC", "Bandai Namco Entertainment", "Elden Ring" },
                    { 7, "Rockstar Games", "PC, PS4, Xbox One", "Rockstar Games", "Red Dead Redemption 2" },
                    { 8, "CD Projekt Red", "PC, PS4, Xbox One, Switch", "CD Projekt", "The Witcher 3: Wild Hunt" },
                    { 9, "Square Enix", "PS4, PS5, PC", "Square Enix", "Final Fantasy VII Remake" },
                    { 10, "Rockstar North", "PC, PS5, Xbox Series X, PS4, Xbox One", "Rockstar Games", "Grand Theft Auto V" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
