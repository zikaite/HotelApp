using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApp.Migrations
{
    public partial class citiesadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Hotels",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityModelId",
                table: "Hotels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityModelId",
                table: "Cleaners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Vilnius" },
                    { 2, "Kaunas" },
                    { 3, "Klaipėda" }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CityId", "Name", "RoomsCapacity" },
                values: new object[] { 1, null, 10 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CityId", "Name", "RoomsCapacity" },
                values: new object[] { 2, null, 7 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CityId", "Name", "RoomsCapacity" },
                values: new object[] { 3, null, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityModelId",
                table: "Hotels",
                column: "CityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cleaners_CityModelId",
                table: "Cleaners",
                column: "CityModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cleaners_Cities_CityModelId",
                table: "Cleaners",
                column: "CityModelId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityModelId",
                table: "Hotels",
                column: "CityModelId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cleaners_Cities_CityModelId",
                table: "Cleaners");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityModelId",
                table: "Hotels");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CityModelId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Cleaners_CityModelId",
                table: "Cleaners");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CityModelId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CityModelId",
                table: "Cleaners");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Hotels",
                newName: "City");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "RoomsCapacity" },
                values: new object[] { "Vilnius", 20 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "RoomsCapacity" },
                values: new object[] { "Kaunas", 25 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "RoomsCapacity" },
                values: new object[] { "Klaipeda", 15 });
        }
    }
}
