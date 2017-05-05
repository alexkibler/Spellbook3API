using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spellbook3API.Migrations
{
    public partial class m3 : Migration
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

            migrationBuilder.CreateTable(
                name: "SpellbookSpell",
                columns: table => new
                {
                    SpellId = table.Column<int>(nullable: false),
                    SpellbookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellbookSpell", x => new { x.SpellId, x.SpellbookId });
                    table.ForeignKey(
                        name: "FK_SpellbookSpell_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpellbookSpell_Spellbooks_SpellbookId",
                        column: x => x.SpellbookId,
                        principalTable: "Spellbooks",
                        principalColumn: "SpellbookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpellbookSpell_SpellbookId",
                table: "SpellbookSpell",
                column: "SpellbookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpellbookSpell");

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
