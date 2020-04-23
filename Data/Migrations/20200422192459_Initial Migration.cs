using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsTryAgain.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Ranking = table.Column<int>(nullable: false),
                    ProspectLevel = table.Column<int>(nullable: false),
                    ChipLevel = table.Column<int>(nullable: false),
                    CommitStatus = table.Column<bool>(nullable: false),
                    Potential = table.Column<bool>(nullable: false),
                    Sleeper = table.Column<bool>(nullable: false),
                    Eligible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Opponent = table.Column<string>(nullable: false),
                    OpponentStateRanking = table.Column<int>(nullable: false),
                    OppenentNationalRanking = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    Rebounds = table.Column<int>(nullable: false),
                    Steals = table.Column<int>(nullable: false),
                    Assist = table.Column<int>(nullable: false),
                    Blocks = table.Column<int>(nullable: false),
                    Turnovers = table.Column<int>(nullable: false),
                    MissedFieldGoals = table.Column<int>(nullable: false),
                    MissedFreeThrows = table.Column<int>(nullable: false),
                    Fouls = table.Column<int>(nullable: false),
                    MinutesPlayed = table.Column<int>(nullable: false),
                    Posessions = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Opponent);
                    table.ForeignKey(
                        name: "FK_Stats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Coach = table.Column<string>(nullable: true),
                    Roster = table.Column<string>(nullable: true),
                    Division = table.Column<string>(nullable: true),
                    NationalRank = table.Column<int>(nullable: false),
                    StateRank = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Teams_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stats_PlayerId",
                table: "Stats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PlayerId",
                table: "Teams",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
