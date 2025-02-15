using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VideoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class Added_Publisher_and_Developer_Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Developer",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "VideoGames");

            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "VideoGames",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "VideoGames",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
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
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeveloperId", "PublisherId" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_DeveloperId",
                table: "VideoGames",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_PublisherId",
                table: "VideoGames",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGames_Developers_DeveloperId",
                table: "VideoGames",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGames_Publishers_PublisherId",
                table: "VideoGames",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoGames_Developers_DeveloperId",
                table: "VideoGames");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGames_Publishers_PublisherId",
                table: "VideoGames");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_VideoGames_DeveloperId",
                table: "VideoGames");

            migrationBuilder.DropIndex(
                name: "IX_VideoGames_PublisherId",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "VideoGames");

            migrationBuilder.AddColumn<string>(
                name: "Developer",
                table: "VideoGames",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "VideoGames",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Developer", "Publisher" },
                values: new object[] { null, null });
        }
    }
}
