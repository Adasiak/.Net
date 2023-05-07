using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_application.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokedex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokedexAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    PokedexId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokedexAbility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokedexAbility_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokedexAbility_Pokedex_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedex",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokedexType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    PokedexId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokedexType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokedexType_Pokedex_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedex",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PokedexType_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokedexAbility_AbilityId",
                table: "PokedexAbility",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexAbility_PokedexId",
                table: "PokedexAbility",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexType_PokedexId",
                table: "PokedexType",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexType_TypeId",
                table: "PokedexType",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokedexAbility");

            migrationBuilder.DropTable(
                name: "PokedexType");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Pokedex");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
