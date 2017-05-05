using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spellbook3API.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpellbookSpell_Spells_SpellId",
                table: "SpellbookSpell");

            migrationBuilder.DropForeignKey(
                name: "FK_SpellbookSpell_Spellbooks_SpellbookId",
                table: "SpellbookSpell");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpellbookSpell",
                table: "SpellbookSpell");

            migrationBuilder.RenameTable(
                name: "SpellbookSpell",
                newName: "SpellbookSpells");

            migrationBuilder.RenameIndex(
                name: "IX_SpellbookSpell_SpellbookId",
                table: "SpellbookSpells",
                newName: "IX_SpellbookSpells_SpellbookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpellbookSpells",
                table: "SpellbookSpells",
                columns: new[] { "SpellId", "SpellbookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SpellbookSpells_Spells_SpellId",
                table: "SpellbookSpells",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "SpellId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpellbookSpells_Spellbooks_SpellbookId",
                table: "SpellbookSpells",
                column: "SpellbookId",
                principalTable: "Spellbooks",
                principalColumn: "SpellbookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpellbookSpells_Spells_SpellId",
                table: "SpellbookSpells");

            migrationBuilder.DropForeignKey(
                name: "FK_SpellbookSpells_Spellbooks_SpellbookId",
                table: "SpellbookSpells");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpellbookSpells",
                table: "SpellbookSpells");

            migrationBuilder.RenameTable(
                name: "SpellbookSpells",
                newName: "SpellbookSpell");

            migrationBuilder.RenameIndex(
                name: "IX_SpellbookSpells_SpellbookId",
                table: "SpellbookSpell",
                newName: "IX_SpellbookSpell_SpellbookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpellbookSpell",
                table: "SpellbookSpell",
                columns: new[] { "SpellId", "SpellbookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SpellbookSpell_Spells_SpellId",
                table: "SpellbookSpell",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "SpellId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpellbookSpell_Spellbooks_SpellbookId",
                table: "SpellbookSpell",
                column: "SpellbookId",
                principalTable: "Spellbooks",
                principalColumn: "SpellbookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
