using Microsoft.EntityFrameworkCore.Migrations;

namespace Energy_Shop.Data.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Energydrinks");

            migrationBuilder.AddColumn<int>(
                name: "Anzahl",
                table: "Energydrinks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bez",
                table: "Energydrinks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GeschmackId",
                table: "Energydrinks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarkeId",
                table: "Energydrinks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Preis",
                table: "Energydrinks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Energydrinks",
                table: "Energydrinks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Geschmack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bez = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geschmack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bez = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marke", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Energydrinks_GeschmackId",
                table: "Energydrinks",
                column: "GeschmackId");

            migrationBuilder.CreateIndex(
                name: "IX_Energydrinks_MarkeId",
                table: "Energydrinks",
                column: "MarkeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Energydrinks_Geschmack_GeschmackId",
                table: "Energydrinks",
                column: "GeschmackId",
                principalTable: "Geschmack",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Energydrinks_Marke_MarkeId",
                table: "Energydrinks",
                column: "MarkeId",
                principalTable: "Marke",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Energydrinks_Geschmack_GeschmackId",
                table: "Energydrinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Energydrinks_Marke_MarkeId",
                table: "Energydrinks");

            migrationBuilder.DropTable(
                name: "Geschmack");

            migrationBuilder.DropTable(
                name: "Marke");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Energydrinks",
                table: "Energydrinks");

            migrationBuilder.DropIndex(
                name: "IX_Energydrinks_GeschmackId",
                table: "Energydrinks");

            migrationBuilder.DropIndex(
                name: "IX_Energydrinks_MarkeId",
                table: "Energydrinks");

            migrationBuilder.DropColumn(
                name: "Anzahl",
                table: "Energydrinks");

            migrationBuilder.DropColumn(
                name: "Bez",
                table: "Energydrinks");

            migrationBuilder.DropColumn(
                name: "GeschmackId",
                table: "Energydrinks");

            migrationBuilder.DropColumn(
                name: "MarkeId",
                table: "Energydrinks");

            migrationBuilder.DropColumn(
                name: "Preis",
                table: "Energydrinks");

            migrationBuilder.RenameTable(
                name: "Energydrinks",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }
    }
}
