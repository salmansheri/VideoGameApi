using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial_create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoGameDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReleaseData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VidoeGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Platform = table.Column<string>(type: "text", nullable: true),
                    DeveloperId = table.Column<int>(type: "integer", nullable: true),
                    PublisherId = table.Column<int>(type: "integer", nullable: true),
                    VideoGameDetailsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoGames_Developers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VideoGames_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VideoGames_VideoGameDetails_VideoGameDetailsId",
                        column: x => x.VideoGameDetailsId,
                        principalTable: "VideoGameDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "DeveloperId", "Platform", "PublisherId", "Title", "VideoGameDetailsId" },
                values: new object[,]
                {
                    { 1, null, "PS5", null, "Spider-Man 2", null },
                    { 2, null, "Nintendo Switch", null, "The Legend of Zelda: Breath of the Wild", null },
                    { 3, null, "PS5", null, "God of War Ragnarok", null },
                    { 4, null, "Xbox Series X", null, "Halo Infinite", null },
                    { 5, null, "PC", null, "Cyberpunk 2077", null },
                    { 6, null, "PS5, Xbox Series X, PC", null, "Elden Ring", null },
                    { 7, null, "PC, PS4, Xbox One", null, "Red Dead Redemption 2", null },
                    { 8, null, "PC, PS4, Xbox One, Switch", null, "The Witcher 3: Wild Hunt", null },
                    { 9, null, "PS4, PS5, PC", null, "Final Fantasy VII Remake", null },
                    { 10, null, "PC, PS5, Xbox Series X, PS4, Xbox One", null, "Grand Theft Auto V", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_DeveloperId",
                table: "VideoGames",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_PublisherId",
                table: "VideoGames",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_VideoGameDetailsId",
                table: "VideoGames",
                column: "VideoGameDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGames");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "VideoGameDetails");
        }
    }
}
