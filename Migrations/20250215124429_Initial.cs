using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Platform = table.Column<string>(type: "text", nullable: true),
                    Developer = table.Column<string>(type: "text", nullable: true),
                    Publisher = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoGameDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VideoGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoGameDetails_VideoGames_VideoGameId",
                        column: x => x.VideoGameId,
                        principalTable: "VideoGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Developer", "Platform", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, null, "PS5", null, "Spider-Man 2" },
                    { 2, null, "Nintendo Switch", null, "The Legend of Zelda: Breath of the Wild" },
                    { 3, null, "PS5", null, "God of War Ragnarok" },
                    { 4, null, "Xbox Series X", null, "Halo Infinite" },
                    { 5, null, "PC", null, "Cyberpunk 2077" },
                    { 6, null, "PS5, Xbox Series X, PC", null, "Elden Ring" },
                    { 7, null, "PC, PS4, Xbox One", null, "Red Dead Redemption 2" },
                    { 8, null, "PC, PS4, Xbox One, Switch", null, "The Witcher 3: Wild Hunt" },
                    { 9, null, "PS4, PS5, PC", null, "Final Fantasy VII Remake" },
                    { 10, null, "PC, PS5, Xbox Series X, PS4, Xbox One", null, "Grand Theft Auto V" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameDetails_VideoGameId",
                table: "VideoGameDetails",
                column: "VideoGameId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGameDetails");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
