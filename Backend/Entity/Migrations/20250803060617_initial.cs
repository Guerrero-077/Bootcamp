using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Winner = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayers_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GamePlayerId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decks_GamePlayers_GamePlayerId",
                        column: x => x.GamePlayerId,
                        principalTable: "GamePlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Force = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Popularity = table.Column<int>(type: "int", nullable: false),
                    Appearances = table.Column<int>(type: "int", nullable: false),
                    Resistance = table.Column<int>(type: "int", nullable: false),
                    IQ = table.Column<int>(type: "int", nullable: false),
                    DeckId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Appearances", "DeckId", "Force", "IQ", "Popularity", "Resistance", "Speed", "Url" },
                values: new object[,]
                {
                    { 1, 33, null, 52, 59, 46, 53, 45, "https://guerrero-077.github.io/imagenes/img/img1.png" },
                    { 2, 36, null, 59, 63, 52, 56, 50, "https://guerrero-077.github.io/imagenes/img/img2.png" },
                    { 3, 39, null, 66, 67, 58, 60, 55, "https://guerrero-077.github.io/imagenes/img/img3.png" },
                    { 4, 42, null, 73, 71, 64, 64, 60, "https://guerrero-077.github.io/imagenes/img/img4.png" },
                    { 5, 45, null, 80, 75, 70, 68, 65, "https://guerrero-077.github.io/imagenes/img/img5.png" },
                    { 6, 48, null, 87, 79, 76, 72, 70, "https://guerrero-077.github.io/imagenes/img/img6.png" },
                    { 7, 51, null, 94, 83, 82, 76, 75, "https://guerrero-077.github.io/imagenes/img/img7.png" },
                    { 8, 54, null, 45, 87, 88, 62, 80, "https://guerrero-077.github.io/imagenes/img/img8.png" },
                    { 9, 57, null, 52, 56, 94, 57, 85, "https://guerrero-077.github.io/imagenes/img/img9.png" },
                    { 10, 60, null, 59, 60, 40, 60, 40, "https://guerrero-077.github.io/imagenes/img/img10.png" },
                    { 11, 63, null, 66, 64, 46, 62, 45, "https://guerrero-077.github.io/imagenes/img/img11.png" },
                    { 12, 66, null, 73, 68, 52, 65, 50, "https://guerrero-077.github.io/imagenes/img/img12.png" },
                    { 13, 69, null, 80, 72, 58, 68, 55, "https://guerrero-077.github.io/imagenes/img/img13.png" },
                    { 14, 72, null, 87, 76, 64, 71, 60, "https://guerrero-077.github.io/imagenes/img/img14.png" },
                    { 15, 30, null, 94, 80, 70, 74, 65, "https://guerrero-077.github.io/imagenes/img/img15.png" },
                    { 16, 33, null, 45, 84, 76, 60, 70, "https://guerrero-077.github.io/imagenes/img/img16.png" },
                    { 17, 36, null, 52, 88, 82, 63, 75, "https://guerrero-077.github.io/imagenes/img/img17.png" },
                    { 18, 39, null, 59, 57, 88, 59, 80, "https://guerrero-077.github.io/imagenes/img/img18.png" },
                    { 19, 42, null, 66, 61, 94, 61, 85, "https://guerrero-077.github.io/imagenes/img/img19.png" },
                    { 20, 45, null, 73, 65, 40, 69, 40, "https://guerrero-077.github.io/imagenes/img/img20.png" },
                    { 21, 48, null, 80, 69, 46, 65, 45, "https://guerrero-077.github.io/imagenes/img/img21.png" },
                    { 22, 51, null, 87, 73, 52, 68, 50, "https://guerrero-077.github.io/imagenes/img/img22.png" },
                    { 23, 54, null, 94, 77, 58, 71, 55, "https://guerrero-077.github.io/imagenes/img/img23.png" },
                    { 24, 57, null, 45, 81, 64, 64, 60, "https://guerrero-077.github.io/imagenes/img/img24.png" },
                    { 25, 60, null, 52, 85, 70, 67, 65, "https://guerrero-077.github.io/imagenes/img/img25.png" },
                    { 26, 63, null, 59, 66, 76, 60, 70, "https://guerrero-077.github.io/imagenes/img/img26.png" },
                    { 27, 66, null, 66, 70, 82, 63, 75, "https://guerrero-077.github.io/imagenes/img/img27.png" },
                    { 28, 69, null, 73, 74, 88, 66, 80, "https://guerrero-077.github.io/imagenes/img/img28.png" },
                    { 29, 72, null, 80, 78, 94, 69, 85, "https://guerrero-077.github.io/imagenes/img/img29.png" },
                    { 30, 30, null, 87, 82, 40, 72, 40, "https://guerrero-077.github.io/imagenes/img/img30.png" },
                    { 31, 33, null, 94, 86, 46, 75, 45, "https://guerrero-077.github.io/imagenes/img/img31.png" },
                    { 32, 36, null, 45, 90, 52, 62, 50, "https://guerrero-077.github.io/imagenes/img/img32.png" },
                    { 33, 39, null, 52, 61, 58, 65, 55, "https://guerrero-077.github.io/imagenes/img/img33.png" },
                    { 34, 42, null, 59, 65, 64, 68, 60, "https://guerrero-077.github.io/imagenes/img/img34.png" },
                    { 35, 45, null, 66, 69, 70, 71, 65, "https://guerrero-077.github.io/imagenes/img/img35.png" },
                    { 36, 48, null, 73, 73, 76, 74, 70, "https://guerrero-077.github.io/imagenes/img/img36.png" },
                    { 37, 51, null, 80, 77, 82, 77, 75, "https://guerrero-077.github.io/imagenes/img/img37.png" },
                    { 38, 54, null, 87, 81, 88, 80, 80, "https://guerrero-077.github.io/imagenes/img/img38.png" },
                    { 39, 57, null, 94, 85, 94, 83, 85, "https://guerrero-077.github.io/imagenes/img/img39.png" },
                    { 40, 60, null, 45, 89, 40, 66, 40, "https://guerrero-077.github.io/imagenes/img/img40.png" },
                    { 41, 63, null, 52, 93, 46, 69, 45, "https://guerrero-077.github.io/imagenes/img/img41.png" },
                    { 42, 66, null, 59, 66, 52, 72, 50, "https://guerrero-077.github.io/imagenes/img/img42.png" },
                    { 43, 69, null, 66, 70, 58, 75, 55, "https://guerrero-077.github.io/imagenes/img/img43.png" },
                    { 44, 72, null, 73, 74, 64, 78, 60, "https://guerrero-077.github.io/imagenes/img/img44.png" },
                    { 45, 30, null, 80, 78, 70, 81, 65, "https://guerrero-077.github.io/imagenes/img/img45.png" },
                    { 46, 33, null, 87, 82, 76, 84, 70, "https://guerrero-077.github.io/imagenes/img/img46.png" },
                    { 47, 36, null, 94, 86, 82, 87, 75, "https://guerrero-077.github.io/imagenes/img/img47.png" },
                    { 48, 39, null, 45, 90, 88, 70, 80, "https://guerrero-077.github.io/imagenes/img/img48.png" },
                    { 49, 42, null, 52, 62, 94, 73, 85, "https://guerrero-077.github.io/imagenes/img/img49.png" },
                    { 50, 45, null, 59, 66, 40, 76, 40, "https://guerrero-077.github.io/imagenes/img/img50.png" },
                    { 51, 48, null, 66, 70, 46, 79, 45, "https://guerrero-077.github.io/imagenes/img/img51.png" },
                    { 52, 51, null, 73, 74, 52, 82, 50, "https://guerrero-077.github.io/imagenes/img/img52.png" },
                    { 53, 54, null, 80, 78, 58, 85, 55, "https://guerrero-077.github.io/imagenes/img/img53.png" },
                    { 54, 57, null, 87, 82, 64, 88, 60, "https://guerrero-077.github.io/imagenes/img/img54.png" },
                    { 55, 60, null, 94, 86, 70, 91, 65, "https://guerrero-077.github.io/imagenes/img/img55.png" },
                    { 56, 63, null, 45, 69, 76, 58, 70, "https://guerrero-077.github.io/imagenes/img/img56.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DeckId",
                table: "Cards",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_GamePlayerId",
                table: "Decks",
                column: "GamePlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayers_PlayerId",
                table: "GamePlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayers_RoomId",
                table: "GamePlayers",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "GamePlayers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
