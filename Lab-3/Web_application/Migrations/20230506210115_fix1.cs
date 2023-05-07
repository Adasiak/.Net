using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_application.Migrations
{
    public partial class fix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokedexAbility_Pokedex_PokedexId",
                table: "PokedexAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_PokedexType_Pokedex_PokedexId",
                table: "PokedexType");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Pokedex",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_PokedexAbility_Pokedex_PokedexId",
                table: "PokedexAbility",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokedexType_Pokedex_PokedexId",
                table: "PokedexType",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokedexAbility_Pokedex_PokedexId",
                table: "PokedexAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_PokedexType_Pokedex_PokedexId",
                table: "PokedexType");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Pokedex");

            migrationBuilder.AddForeignKey(
                name: "FK_PokedexAbility_Pokedex_PokedexId",
                table: "PokedexAbility",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PokedexType_Pokedex_PokedexId",
                table: "PokedexType",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "Id");
        }
    }
}
