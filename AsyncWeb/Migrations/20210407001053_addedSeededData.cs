using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncWeb.Migrations
{
    public partial class addedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "MuchFun" },
                    { 2, "MuchDIO" },
                    { 3, "MuchMareofNight" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "City", "Country", "Name", "Phone", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Mysterious Room", " Country of Mystery", " The uhhh room", "123 345 7442", "ScoobySnack", " 123 Mystery Street" },
                    { 2, "JOJOOO", " Girly teen girl", " Niceu Niceu Very Niceu", "109 876 5432", "Adventure of Bizarre", " 321 sesame street" },
                    { 3, "NightmareFun", "La La Land", "Chimkin of Nightmares", "111 222 3334", "fshh", "456 elm street" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Layout", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Myst" },
                    { 2, 2, "JOJO" },
                    { 3, 0, "Night" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
