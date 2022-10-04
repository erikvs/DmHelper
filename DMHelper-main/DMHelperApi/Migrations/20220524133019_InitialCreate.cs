using Microsoft.EntityFrameworkCore.Migrations;

namespace DMHelperApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnvironmentType",
                columns: table => new
                {
                    EnvironmentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentType", x => x.EnvironmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Encounters",
                columns: table => new
                {
                    EncounterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encounters", x => x.EncounterId);
                    table.ForeignKey(
                        name: "FK_Encounters_EnvironmentType_EnvironmentTypeId",
                        column: x => x.EnvironmentTypeId,
                        principalTable: "EnvironmentType",
                        principalColumn: "EnvironmentTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Armour = table.Column<int>(type: "int", nullable: false),
                    HitPoints = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dexterity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Constitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intelligence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wisdom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Charisma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.MonsterId);
                    table.ForeignKey(
                        name: "FK_Monsters_EnvironmentType_EnvironmentTypeId",
                        column: x => x.EnvironmentTypeId,
                        principalTable: "EnvironmentType",
                        principalColumn: "EnvironmentTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterEncounter",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    EncounterId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterEncounter", x => new { x.EncounterId, x.MonsterId });
                    table.ForeignKey(
                        name: "FK_MonsterEncounter_Encounters_EncounterId",
                        column: x => x.EncounterId,
                        principalTable: "Encounters",
                        principalColumn: "EncounterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterEncounter_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EnvironmentType",
                columns: new[] { "EnvironmentTypeId", "Name" },
                values: new object[] { 10, "Forest" });

            migrationBuilder.InsertData(
                table: "EnvironmentType",
                columns: new[] { "EnvironmentTypeId", "Name" },
                values: new object[] { 17, "Underdark" });

            migrationBuilder.InsertData(
                table: "EnvironmentType",
                columns: new[] { "EnvironmentTypeId", "Name" },
                values: new object[] { 19, "Urban" });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "EncounterId", "EnvironmentTypeId", "Name" },
                values: new object[,]
                {
                    { 1, 10, "Forest encounter" },
                    { 2, 10, "Special Swampy forest encounter" },
                    { 3, 10, "Hard forest encounter" }
                });

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "MonsterId", "Armour", "Attack", "Charisma", "Constitution", "Dexterity", "EnvironmentTypeId", "Experience", "HitPoints", "Intelligence", "Name", "Speed", "Strength", "Wisdom" },
                values: new object[,]
                {
                    { 13, 12, "Pseudopod", "8 (-1)", "15 (+2)", "12 (+1)", 19, 450, 58, "5 (-3)", "Mimic", 15, "17 (+3)", "13 (+1)" },
                    { 10, 13, "Shortsword", "10 (+0)", "9 (-1)", "17 (+3)", 19, 200, 35, "14 (+2)", "Meazel", 30, "8 (-1)", "13 (+1)" },
                    { 8, 13, "Shortsword", "5 (-3)", "15 (+2)", "14 (+2)", 19, 50, 13, "6 (-2)", "Skeleton", 30, "10 (+0)", "8 (-1)" },
                    { 7, 16, "Spear", "10 (+0)", "12 (+1)", "12 (+1)", 19, 25, 11, "10 (+0)", "Guard", 30, "13 (+1)", "11 (+0)" },
                    { 6, 15, "Rapier", "16 (+3)", "11 (+0)", "12 (+1)", 19, 25, 9, "12 (+1)", "Noble", 30, "11 (+0)", "14 (+2)" },
                    { 22, 13, "Greataxe", "10 (+0)", "16 (+3)", "12 (+1)", 17, 100, 15, "7 (-2)", "Orc", 30, "16 (+3)", "11 (+0)" },
                    { 21, 12, "Dagger", "8 (-1)", "9 (-1)", "15 (+2)", 17, 25, 5, "11 (+0)", "Kobold", 30, "7 (-2)", "7 (-2)" },
                    { 20, 13, "Light Crossbow", "9 (-1)", "12 (+1)", "14 (+2)", 17, 50, 13, "11 (+0)", "Derro", 30, "10 (+0)", "5 (-3)" },
                    { 19, 14, "Dagger", "10 (+0)", "12 (+1)", "16 (+3)", 17, 100, 13, "10 (+0)", "Darkling", 30, "9 (-1)", "12 (+1)" },
                    { 16, 15, "Shortsword", "12 (+1)", "10 (+0)", "14 (+2)", 17, 50, 13, "11 (+0)", "Drow", 30, "10 (+0)", "11 (+0)" },
                    { 12, 12, "Battleaxe", "8 (-1)", "17 (+3)", "8 (-1)", 17, 1100, 85, "6 (-2)", "Ettin", 40, "21 (+5)", "10 (+0)" },
                    { 9, 14, "Longsword", "15 (+2)", "16 (+3)", "14 (+2)", 17, 700, 45, "10 (+0)", "Wight", 30, "15 (+2)", "13 (+1)" },
                    { 18, 16, "Morningstar", "9 (-1)", "13 (+1)", "14 (+2)", 10, 200, 27, "8 (-1)", "Bugbear", 30, "15 (+2)", "11 (+0)" },
                    { 17, 18, "Longsword", "9 (-1)", "12 (+1)", "12 (+1)", 10, 100, 11, "10 (+0)", "Hobgoblin", 30, "13 (+1)", "10 (+0)" },
                    { 11, 15, "Spear", "7 (-2)", "11 (+0)", "12 (+1)", 10, 100, 22, "6 (-2)", "Gnoll", 30, "14 (+2)", "10 (+0)" },
                    { 5, 13, "Bite", "6 (-2)", "12 (+1)", "15 (+2)", 10, 50, 11, "3 (-4)", "Wolf", 30, "12 (+1)", "12 (+1)" },
                    { 4, 13, "Club", "15 (+2)", "10 (+0)", "14 (+2)", 10, 200, 7, "10 (+0)", "Nilbog", 30, "8 (-1)", "8 (-1)" },
                    { 3, 13, "Beak", "7 (-2)", "17 (+3)", "12 (+1)", 10, 700, 59, "3 (-4)", "Owlbear", 40, "20 (+5)", "12 (+1)" },
                    { 2, 15, "Bite", "7 (-2)", "20 (+5)", "12 (+1)", 10, 900, 172, "2 (-4)", "Hydra", 30, "20 (+5)", "10 (+0)" },
                    { 1, 15, "Scimitar", "8 (-1)", "10 (+0)", "14 (+2)", 10, 50, 7, "10 (+0)", "Goblin", 30, "8 (-1)", "8 (-1)" },
                    { 14, 15, "Scimitar", "14 (+2)", "14 (+2)", "16 (+3)", 19, 450, 65, "14 (+2)", "Bandit Captain", 30, "15 (+2)", "11 (+0)" },
                    { 15, 12, "Scimitar", "10 (+0)", "12 (+1)", "12 (+1)", 19, 25, 11, "10 (+0)", "Bandit", 30, "11 (+0)", "10 (+0)" }
                });

            migrationBuilder.InsertData(
                table: "MonsterEncounter",
                columns: new[] { "EncounterId", "MonsterId", "Amount" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 3, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Encounters_EnvironmentTypeId",
                table: "Encounters",
                column: "EnvironmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterEncounter_MonsterId",
                table: "MonsterEncounter",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_EnvironmentTypeId",
                table: "Monsters",
                column: "EnvironmentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterEncounter");

            migrationBuilder.DropTable(
                name: "Encounters");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "EnvironmentType");
        }
    }
}
