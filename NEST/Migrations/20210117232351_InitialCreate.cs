using Microsoft.EntityFrameworkCore.Migrations;

namespace NEST.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IsolationPointList",
                columns: table => new
                {
                    UDC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsolationUID = table.Column<int>(nullable: false),
                    ParentSystem = table.Column<string>(nullable: true),
                    IsolationPoint = table.Column<string>(nullable: true),
                    SwitchboardOrCubicle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PhysicalLocation = table.Column<string>(nullable: true),
                    IsolationCat = table.Column<int>(nullable: false),
                    DefaultIso = table.Column<int>(nullable: false),
                    FacilityCode = table.Column<int>(nullable: false),
                    IsolationType = table.Column<string>(nullable: true),
                    EnergyPotential = table.Column<string>(nullable: true),
                    Padlockable = table.Column<bool>(nullable: false),
                    PreferredPadlock = table.Column<string>(nullable: true),
                    PreferredLockout = table.Column<string>(nullable: true),
                    AlternateLockout = table.Column<string>(nullable: true),
                    IsIsolationPoint = table.Column<bool>(nullable: false),
                    ValidationPoss = table.Column<bool>(nullable: false),
                    ValidationMethod = table.Column<string>(nullable: true),
                    HighRiskPlant = table.Column<bool>(nullable: false),
                    Photos = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    CheckedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationPointList", x => x.UDC);
                });

            migrationBuilder.CreateTable(
                name: "IsolationPointTools",
                columns: table => new
                {
                    StockCodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    PartNum = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationPointTools", x => x.StockCodeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsolationPointList");

            migrationBuilder.DropTable(
                name: "IsolationPointTools");
        }
    }
}
