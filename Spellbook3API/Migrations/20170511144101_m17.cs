using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spellbook3API.Migrations
{
    public partial class m17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spellbooks_Characters_CharacterSheetId",
                table: "Spellbooks");

            migrationBuilder.DropIndex(
                name: "IX_Spellbooks_CharacterSheetId",
                table: "Spellbooks");

            migrationBuilder.DropColumn(
                name: "CharacterSheetId",
                table: "Spellbooks");

            migrationBuilder.AddColumn<int>(
                name: "SpellbookId",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SpellbookId",
                table: "Characters",
                column: "SpellbookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Spellbooks_SpellbookId",
                table: "Characters",
                column: "SpellbookId",
                principalTable: "Spellbooks",
                principalColumn: "SpellbookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Spellbooks_SpellbookId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_SpellbookId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SpellbookId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "CharacterSheetId",
                table: "Spellbooks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spellbooks_CharacterSheetId",
                table: "Spellbooks",
                column: "CharacterSheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spellbooks_Characters_CharacterSheetId",
                table: "Spellbooks",
                column: "CharacterSheetId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
