using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualJournal.Migrations
{
    public partial class RegistrationDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistrationData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    LastName = table.Column<string>(type: "text", maxLength: 15, nullable: true),
                    UserName = table.Column<string>(type: "text", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "text", maxLength: 16, nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationData", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationData");
        }
    }
}
