using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spellbook3API.Migrations
{
    public partial class m15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
