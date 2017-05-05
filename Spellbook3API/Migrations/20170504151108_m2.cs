using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spellbook3API.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Spellbooks_SpellbookId",
                table: "Spells");

            migrationBuilder.AlterColumn<int>(
                name: "SpellbookId",
                table: "Spells",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Spellbooks_SpellbookId",
                table: "Spells",
                column: "SpellbookId",
                principalTable: "Spellbooks",
                principalColumn: "SpellbookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Spellbooks_SpellbookId",
                table: "Spells");

            migrationBuilder.AlterColumn<int>(
                name: "SpellbookId",
                table: "Spells",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Spellbooks_SpellbookId",
                table: "Spells",
                column: "SpellbookId",
                principalTable: "Spellbooks",
                principalColumn: "SpellbookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
