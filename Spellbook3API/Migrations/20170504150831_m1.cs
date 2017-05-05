using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Spellbook3API.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spellbooks",
                columns: table => new
                {
                    SpellbookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spellbooks", x => x.SpellbookId);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    SpellId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Archetype = table.Column<string>(nullable: true),
                    Casting_time = table.Column<string>(nullable: true),
                    Circles = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Components = table.Column<string>(nullable: true),
                    Concentration = table.Column<bool>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Domains = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Higher_level = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Oaths = table.Column<string>(nullable: true),
                    Page = table.Column<string>(nullable: true),
                    Patrons = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Ritual = table.Column<bool>(nullable: true),
                    School = table.Column<string>(nullable: true),
                    SpellbookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.SpellId);
                    table.ForeignKey(
                        name: "FK_Spells_Spellbooks_SpellbookId",
                        column: x => x.SpellbookId,
                        principalTable: "Spellbooks",
                        principalColumn: "SpellbookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SpellbookId",
                table: "Spells",
                column: "SpellbookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Spellbooks");
        }
    }
}
