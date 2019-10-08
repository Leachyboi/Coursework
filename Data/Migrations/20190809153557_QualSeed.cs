using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCFTracker.Data.Migrations
{
    public partial class QualSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QualificationView");

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QualName = table.Column<string>(maxLength: 60, nullable: false),
                    PassMark = table.Column<int>(nullable: false),
                    ParOrChi = table.Column<string>(nullable: true),
                    Parent = table.Column<string>(nullable: true),
                    NumChi = table.Column<int>(nullable: false),
                    MinChiPass = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.CreateTable(
                name: "QualificationView",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MinChiPass = table.Column<int>(nullable: false),
                    NumChi = table.Column<int>(nullable: false),
                    ParOrChi = table.Column<string>(nullable: true),
                    Parent = table.Column<string>(nullable: true),
                    PassMark = table.Column<int>(nullable: false),
                    QualName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualificationView", x => x.ID);
                });
        }
    }
}
