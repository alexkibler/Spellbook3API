using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Spellbook3API.Migrations
{
    public partial class m8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Spellbooks_SpellbookId",
                table: "Spells");

            migrationBuilder.DropIndex(
                name: "IX_Spells_SpellbookId",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SpellbookId",
                table: "Spells");

            migrationBuilder.AddColumn<string>(
                name: "CharacterSheetUrl",
                table: "Spellbooks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Spellbooks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Spellbooks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Spellbooks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Spellbooks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Spellbooks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SpellSimple",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Class = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SpellbookId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSimple", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellSimple_Spellbooks_SpellbookId",
                        column: x => x.SpellbookId,
                        principalTable: "Spellbooks",
                        principalColumn: "SpellbookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpellSimple_SpellbookId",
                table: "SpellSimple",
                column: "SpellbookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpellSimple");

            migrationBuilder.DropColumn(
                name: "CharacterSheetUrl",
                table: "Spellbooks");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Spellbooks");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Spellbooks");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Spellbooks");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Spellbooks");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Spellbooks");

            migrationBuilder.AddColumn<int>(
                name: "SpellbookId",
                table: "Spells",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SpellbookId",
                table: "Spells",
                column: "SpellbookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Spellbooks_SpellbookId",
                table: "Spells",
                column: "SpellbookId",
                principalTable: "Spellbooks",
                principalColumn: "SpellbookId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
