using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDFOfferCreator.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfferData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModuleType = table.Column<int>(type: "int", nullable: false),
                    BatteryStorage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OfferData",
                columns: new[] { "Id", "BatteryStorage", "City", "ModuleType", "Name", "Street", "Surname" },
                values: new object[] { 1, 0, "City1", 0, "John", "Street1", "Doe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfferData");
        }
    }
}
