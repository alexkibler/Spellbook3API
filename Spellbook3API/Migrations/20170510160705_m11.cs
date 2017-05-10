using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Spellbook3API.Migrations
{
    public partial class m11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbilityScores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Charisma = table.Column<int>(nullable: false),
                    Constitution = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Wisdom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CP = table.Column<decimal>(nullable: false),
                    EP = table.Column<decimal>(nullable: false),
                    GP = table.Column<decimal>(nullable: false),
                    PP = table.Column<decimal>(nullable: false),
                    SP = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeathSaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Failure1 = table.Column<bool>(nullable: false),
                    Failure2 = table.Column<bool>(nullable: false),
                    Failure3 = table.Column<bool>(nullable: false),
                    Success1 = table.Column<bool>(nullable: false),
                    Success2 = table.Column<bool>(nullable: false),
                    Success3 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeathSaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Proficient = table.Column<bool>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Proficient1 = table.Column<bool>(nullable: false),
                    Proficient2 = table.Column<bool>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharismaId = table.Column<int>(nullable: true),
                    ConstitutionId = table.Column<int>(nullable: true),
                    DexterityId = table.Column<int>(nullable: true),
                    IntelligenceId = table.Column<int>(nullable: true),
                    StrengthId = table.Column<int>(nullable: true),
                    WisdomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavingThrows_SavingThrow_CharismaId",
                        column: x => x.CharismaId,
                        principalTable: "SavingThrow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavingThrows_SavingThrow_ConstitutionId",
                        column: x => x.ConstitutionId,
                        principalTable: "SavingThrow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavingThrows_SavingThrow_DexterityId",
                        column: x => x.DexterityId,
                        principalTable: "SavingThrow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavingThrows_SavingThrow_IntelligenceId",
                        column: x => x.IntelligenceId,
                        principalTable: "SavingThrow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavingThrows_SavingThrow_StrengthId",
                        column: x => x.StrengthId,
                        principalTable: "SavingThrow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavingThrows_SavingThrow_WisdomId",
                        column: x => x.WisdomId,
                        principalTable: "SavingThrow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcrobaticsId = table.Column<int>(nullable: true),
                    AnimalHandlingId = table.Column<int>(nullable: true),
                    ArcanaId = table.Column<int>(nullable: true),
                    AthleticsId = table.Column<int>(nullable: true),
                    DeceptionId = table.Column<int>(nullable: true),
                    HistoryId = table.Column<int>(nullable: true),
                    InsightId = table.Column<int>(nullable: true),
                    IntimidationId = table.Column<int>(nullable: true),
                    InvestigationId = table.Column<int>(nullable: true),
                    MedicineId = table.Column<int>(nullable: true),
                    PerceptionId = table.Column<int>(nullable: true),
                    PerformanceId = table.Column<int>(nullable: true),
                    PersuasionId = table.Column<int>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    SleightOfHandId = table.Column<int>(nullable: true),
                    StealthId = table.Column<int>(nullable: true),
                    SurvivalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_AcrobaticsId",
                        column: x => x.AcrobaticsId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_AnimalHandlingId",
                        column: x => x.AnimalHandlingId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_ArcanaId",
                        column: x => x.ArcanaId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_AthleticsId",
                        column: x => x.AthleticsId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_DeceptionId",
                        column: x => x.DeceptionId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_HistoryId",
                        column: x => x.HistoryId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_InsightId",
                        column: x => x.InsightId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_IntimidationId",
                        column: x => x.IntimidationId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_InvestigationId",
                        column: x => x.InvestigationId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_PerceptionId",
                        column: x => x.PerceptionId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_PersuasionId",
                        column: x => x.PersuasionId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_SleightOfHandId",
                        column: x => x.SleightOfHandId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_StealthId",
                        column: x => x.StealthId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Skill_SurvivalId",
                        column: x => x.SurvivalId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbilityScoresId = table.Column<int>(nullable: true),
                    Alignment = table.Column<string>(nullable: true),
                    ArmorClass = table.Column<int>(nullable: false),
                    Bonds = table.Column<string>(nullable: true),
                    ClassFeatures = table.Column<string>(nullable: true),
                    CurrencyId = table.Column<int>(nullable: true),
                    CurrentHP = table.Column<int>(nullable: false),
                    CurrentHitDice = table.Column<string>(nullable: true),
                    DeathSavesId = table.Column<int>(nullable: true),
                    Equipment = table.Column<string>(nullable: true),
                    Flaws = table.Column<string>(nullable: true),
                    Ideals = table.Column<string>(nullable: true),
                    Initiative = table.Column<int>(nullable: false),
                    Inspiration = table.Column<bool>(nullable: false),
                    MaxHP = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PersonalityTraits = table.Column<string>(nullable: true),
                    ProficiencyBonus = table.Column<int>(nullable: false),
                    Race = table.Column<string>(nullable: true),
                    SavingThrowsId = table.Column<int>(nullable: true),
                    SkillsId = table.Column<int>(nullable: true),
                    Speed = table.Column<int>(nullable: false),
                    TotalHitDice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_AbilityScores_AbilityScoresId",
                        column: x => x.AbilityScoresId,
                        principalTable: "AbilityScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_DeathSaves_DeathSavesId",
                        column: x => x.DeathSavesId,
                        principalTable: "DeathSaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_SavingThrows_SavingThrowsId",
                        column: x => x.SavingThrowsId,
                        principalTable: "SavingThrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ammo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacterId = table.Column<int>(nullable: true),
                    Max = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Remaining = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ammo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ammo_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttackModifier = table.Column<string>(nullable: true),
                    CharacterId = table.Column<int>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attack_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassLevel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacterId = table.Column<int>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassLevel_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ammo_CharacterId",
                table: "Ammo",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Attack_CharacterId",
                table: "Attack",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AbilityScoresId",
                table: "Characters",
                column: "AbilityScoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CurrencyId",
                table: "Characters",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DeathSavesId",
                table: "Characters",
                column: "DeathSavesId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SavingThrowsId",
                table: "Characters",
                column: "SavingThrowsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SkillsId",
                table: "Characters",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassLevel_CharacterId",
                table: "ClassLevel",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_CharismaId",
                table: "SavingThrows",
                column: "CharismaId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_ConstitutionId",
                table: "SavingThrows",
                column: "ConstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_DexterityId",
                table: "SavingThrows",
                column: "DexterityId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_IntelligenceId",
                table: "SavingThrows",
                column: "IntelligenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_StrengthId",
                table: "SavingThrows",
                column: "StrengthId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_WisdomId",
                table: "SavingThrows",
                column: "WisdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_AcrobaticsId",
                table: "Skills",
                column: "AcrobaticsId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_AnimalHandlingId",
                table: "Skills",
                column: "AnimalHandlingId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ArcanaId",
                table: "Skills",
                column: "ArcanaId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_AthleticsId",
                table: "Skills",
                column: "AthleticsId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_DeceptionId",
                table: "Skills",
                column: "DeceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_HistoryId",
                table: "Skills",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_InsightId",
                table: "Skills",
                column: "InsightId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_IntimidationId",
                table: "Skills",
                column: "IntimidationId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_InvestigationId",
                table: "Skills",
                column: "InvestigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_MedicineId",
                table: "Skills",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PerceptionId",
                table: "Skills",
                column: "PerceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PerformanceId",
                table: "Skills",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PersuasionId",
                table: "Skills",
                column: "PersuasionId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ReligionId",
                table: "Skills",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SleightOfHandId",
                table: "Skills",
                column: "SleightOfHandId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_StealthId",
                table: "Skills",
                column: "StealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SurvivalId",
                table: "Skills",
                column: "SurvivalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ammo");

            migrationBuilder.DropTable(
                name: "Attack");

            migrationBuilder.DropTable(
                name: "ClassLevel");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "AbilityScores");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "DeathSaves");

            migrationBuilder.DropTable(
                name: "SavingThrows");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SavingThrow");

            migrationBuilder.DropTable(
                name: "Skill");
        }
    }
}
