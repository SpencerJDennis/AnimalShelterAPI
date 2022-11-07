using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    AnimalSpecies = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    AnimalAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AnimalAge", "AnimalName", "AnimalSpecies" },
                values: new object[,]
                {
                    { 1, 2, "Fido", "Dog" },
                    { 2, 15, "Amber", "Cat" },
                    { 3, 10, "Tilly", "Dog" },
                    { 4, 10, "Tobby", "Dog" },
                    { 5, 6, "Rocky", "Dog" },
                    { 6, 9, "Pudgey", "Cat" },
                    { 7, 1, "Niki", "Cat" },
                    { 8, 2, "Memo", "Cat" },
                    { 9, 3, "Late", "Cat" },
                    { 10, 5, "Jack", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
