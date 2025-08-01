using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class Cards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Decks_DecksId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_DecksId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Decks");

            migrationBuilder.DropColumn(
                name: "DecksId",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "DeckId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DeckId",
                table: "Cards",
                column: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Decks_DeckId",
                table: "Cards",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Decks_DeckId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_DeckId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "DeckId",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Decks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DecksId",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DecksId",
                table: "Cards",
                column: "DecksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Decks_DecksId",
                table: "Cards",
                column: "DecksId",
                principalTable: "Decks",
                principalColumn: "Id");
        }
    }
}
