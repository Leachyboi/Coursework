using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCFTracker.Data.Migrations
{
    public partial class CadetScaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rank = table.Column<string>(maxLength: 5, nullable: false),
                    Surname = table.Column<string>(maxLength: 25, nullable: false),
                    KnownAs = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(maxLength: 6, nullable: false),
                    Form = table.Column<string>(maxLength: 5, nullable: false),
                    Platoon = table.Column<int>(nullable: false),
                    Section = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadet", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadet");
        }
    }
}
