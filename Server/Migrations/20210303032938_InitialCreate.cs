using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<short>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Manufacturer", "Model", "Year" },
                values: new object[] { 1, "Ford", "Fusion", 2000 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Manufacturer", "Model", "Year" },
                values: new object[] { 2, "Volkswagem", "Golf", 2005 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Manufacturer", "Model", "Year" },
                values: new object[] { 3, "Fiat", "Uno", 2012 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Manufacturer", "Model", "Year" },
                values: new object[] { 4, "Mercedes-Benz", "A45", 2020 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Manufacturer", "Model", "Year" },
                values: new object[] { 5, "BMW", "550i", 2003 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Manufacturer", "Model", "Year" },
                values: new object[] { 6, "Chevrolet", "Cruze", 2001 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 1, (short)21, "Oliver", "Oniper" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 2, (short)30, "John", "Lorks" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 3, (short)45, "Chris", "Mork" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
