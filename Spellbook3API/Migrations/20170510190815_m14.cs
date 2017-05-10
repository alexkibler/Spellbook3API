using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Spellbook3API.Migrations
{
    public partial class m14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingThrows_SavingThrow_CharismaId",
                table: "SavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_SavingThrows_SavingThrow_ConstitutionId",
                table: "SavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_SavingThrows_SavingThrow_DexterityId",
                table: "SavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_SavingThrows_SavingThrow_IntelligenceId",
                table: "SavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_SavingThrows_SavingThrow_StrengthId",
                table: "SavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_SavingThrows_SavingThrow_WisdomId",
                table: "SavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_AcrobaticsId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_AnimalHandlingId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_ArcanaId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_AthleticsId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_DeceptionId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_HistoryId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_InsightId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_IntimidationId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_InvestigationId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_MedicineId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_PerceptionId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_PerformanceId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_PersuasionId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_ReligionId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_SleightOfHandId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_StealthId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Skill_SurvivalId",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "SavingThrow");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skills_AcrobaticsId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_AnimalHandlingId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ArcanaId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_AthleticsId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_DeceptionId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_HistoryId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_InsightId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_IntimidationId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_InvestigationId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_MedicineId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_PerceptionId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_PerformanceId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_PersuasionId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ReligionId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_SleightOfHandId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_StealthId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_SurvivalId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_SavingThrows_CharismaId",
                table: "SavingThrows");

            migrationBuilder.DropIndex(
                name: "IX_SavingThrows_ConstitutionId",
                table: "SavingThrows");

            migrationBuilder.DropIndex(
                name: "IX_SavingThrows_DexterityId",
                table: "SavingThrows");

            migrationBuilder.DropIndex(
                name: "IX_SavingThrows_IntelligenceId",
                table: "SavingThrows");

            migrationBuilder.DropIndex(
                name: "IX_SavingThrows_StrengthId",
                table: "SavingThrows");

            migrationBuilder.DropIndex(
                name: "IX_SavingThrows_WisdomId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "AcrobaticsId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AnimalHandlingId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ArcanaId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AthleticsId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DeceptionId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "HistoryId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InsightId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "IntimidationId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InvestigationId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerceptionId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerformanceId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PersuasionId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ReligionId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SleightOfHandId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "StealthId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SurvivalId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CharismaId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "ConstitutionId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "DexterityId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "IntelligenceId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "StrengthId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "WisdomId",
                table: "SavingThrows");

            migrationBuilder.AddColumn<bool>(
                name: "AcrobaticsProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AcrobaticsProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AcrobaticsValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AnimalHandlingProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AnimalHandlingProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AnimalHandlingValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ArcanaProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ArcanaProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ArcanaValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AthleticsProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AthleticsProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AthleticsValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DeceptionProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DeceptionProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DeceptionValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HistoryProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HistoryProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "HistoryValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "InsightProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InsightProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "InsightValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IntimidationProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IntimidationProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IntimidationValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "InvestigationProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InvestigationProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "InvestigationValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "MedicineProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MedicineProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MedicineValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PerceptionProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PerceptionProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PerceptionValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PerformanceProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PerformanceProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PersuasionProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PersuasionProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PersuasionValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ReligionProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ReligionProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ReligionValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "SleightOfHandProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SleightOfHandProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SleightOfHandValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "StealthProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StealthProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StealthValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "SurvivalProficient1",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SurvivalProficient2",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SurvivalValue",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "CharismaProficient",
                table: "SavingThrows",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CharismaValue",
                table: "SavingThrows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ConstitutionProficient",
                table: "SavingThrows",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ConstitutionValue",
                table: "SavingThrows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DexterityProficient",
                table: "SavingThrows",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DexterityValue",
                table: "SavingThrows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IntelligenceProficient",
                table: "SavingThrows",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IntelligenceValue",
                table: "SavingThrows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "StrengthProficient",
                table: "SavingThrows",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StrengthValue",
                table: "SavingThrows",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "WisdomProficient",
                table: "SavingThrows",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "WisdomValue",
                table: "SavingThrows",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcrobaticsProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AcrobaticsProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AcrobaticsValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AnimalHandlingProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AnimalHandlingProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AnimalHandlingValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ArcanaProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ArcanaProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ArcanaValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AthleticsProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AthleticsProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AthleticsValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DeceptionProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DeceptionProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DeceptionValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "HistoryProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "HistoryProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "HistoryValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InsightProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InsightProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InsightValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "IntimidationProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "IntimidationProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "IntimidationValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InvestigationProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InvestigationProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "InvestigationValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "MedicineProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "MedicineProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "MedicineValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerceptionProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerceptionProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerceptionValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerformanceProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerformanceProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PerformanceValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PersuasionProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PersuasionProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PersuasionValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ReligionProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ReligionProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ReligionValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SleightOfHandProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SleightOfHandProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SleightOfHandValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "StealthProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "StealthProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "StealthValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SurvivalProficient1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SurvivalProficient2",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SurvivalValue",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CharismaProficient",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "CharismaValue",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "ConstitutionProficient",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "ConstitutionValue",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "DexterityProficient",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "DexterityValue",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "IntelligenceProficient",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "IntelligenceValue",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "StrengthProficient",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "StrengthValue",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "WisdomProficient",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "WisdomValue",
                table: "SavingThrows");

            migrationBuilder.AddColumn<int>(
                name: "AcrobaticsId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimalHandlingId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArcanaId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AthleticsId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeceptionId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoryId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsightId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IntimidationId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvestigationId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerceptionId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersuasionId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReligionId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SleightOfHandId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StealthId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SurvivalId",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharismaId",
                table: "SavingThrows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConstitutionId",
                table: "SavingThrows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DexterityId",
                table: "SavingThrows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IntelligenceId",
                table: "SavingThrows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StrengthId",
                table: "SavingThrows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WisdomId",
                table: "SavingThrows",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SavingThrow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Proficient = table.Column<bool>(nullable: true),
                    Value = table.Column<int>(nullable: true)
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
                    Proficient1 = table.Column<bool>(nullable: true),
                    Proficient2 = table.Column<bool>(nullable: true),
                    Value = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_SavingThrows_SavingThrow_CharismaId",
                table: "SavingThrows",
                column: "CharismaId",
                principalTable: "SavingThrow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SavingThrows_SavingThrow_ConstitutionId",
                table: "SavingThrows",
                column: "ConstitutionId",
                principalTable: "SavingThrow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SavingThrows_SavingThrow_DexterityId",
                table: "SavingThrows",
                column: "DexterityId",
                principalTable: "SavingThrow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SavingThrows_SavingThrow_IntelligenceId",
                table: "SavingThrows",
                column: "IntelligenceId",
                principalTable: "SavingThrow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SavingThrows_SavingThrow_StrengthId",
                table: "SavingThrows",
                column: "StrengthId",
                principalTable: "SavingThrow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SavingThrows_SavingThrow_WisdomId",
                table: "SavingThrows",
                column: "WisdomId",
                principalTable: "SavingThrow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_AcrobaticsId",
                table: "Skills",
                column: "AcrobaticsId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_AnimalHandlingId",
                table: "Skills",
                column: "AnimalHandlingId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_ArcanaId",
                table: "Skills",
                column: "ArcanaId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_AthleticsId",
                table: "Skills",
                column: "AthleticsId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_DeceptionId",
                table: "Skills",
                column: "DeceptionId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_HistoryId",
                table: "Skills",
                column: "HistoryId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_InsightId",
                table: "Skills",
                column: "InsightId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_IntimidationId",
                table: "Skills",
                column: "IntimidationId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_InvestigationId",
                table: "Skills",
                column: "InvestigationId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_MedicineId",
                table: "Skills",
                column: "MedicineId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_PerceptionId",
                table: "Skills",
                column: "PerceptionId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_PerformanceId",
                table: "Skills",
                column: "PerformanceId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_PersuasionId",
                table: "Skills",
                column: "PersuasionId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_ReligionId",
                table: "Skills",
                column: "ReligionId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_SleightOfHandId",
                table: "Skills",
                column: "SleightOfHandId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_StealthId",
                table: "Skills",
                column: "StealthId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Skill_SurvivalId",
                table: "Skills",
                column: "SurvivalId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
