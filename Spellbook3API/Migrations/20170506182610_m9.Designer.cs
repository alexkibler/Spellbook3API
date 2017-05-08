using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Spellbook3API.Models;

namespace Spellbook3API.Migrations
{
    [DbContext(typeof(SpellbookContext))]
    [Migration("20170506182610_m9")]
    partial class m9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Spellbook3API.Models.Spell", b =>
                {
                    b.Property<int>("SpellId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Archetype");

                    b.Property<string>("Casting_time");

                    b.Property<string>("Circles");

                    b.Property<string>("Class");

                    b.Property<string>("Components");

                    b.Property<bool?>("Concentration");

                    b.Property<string>("Desc");

                    b.Property<string>("Domains");

                    b.Property<string>("Duration");

                    b.Property<string>("Higher_level");

                    b.Property<string>("Level");

                    b.Property<string>("Material");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Oaths");

                    b.Property<string>("Page");

                    b.Property<string>("Patrons");

                    b.Property<string>("Range");

                    b.Property<bool?>("Ritual");

                    b.Property<string>("School");

                    b.HasKey("SpellId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("Spellbook3API.Models.Spellbook", b =>
                {
                    b.Property<int>("SpellbookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CharacterSheetUrl");

                    b.Property<string>("Class");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("SpellbookId");

                    b.ToTable("Spellbooks");
                });

            modelBuilder.Entity("Spellbook3API.Models.SpellbookSpell", b =>
                {
                    b.Property<int>("SpellId");

                    b.Property<int>("SpellbookId");

                    b.HasKey("SpellId", "SpellbookId");

                    b.HasIndex("SpellbookId");

                    b.ToTable("SpellbookSpell");
                });

            modelBuilder.Entity("Spellbook3API.Models.SpellSimple", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Level");

                    b.Property<string>("Name");

                    b.Property<int?>("SpellbookId");

                    b.HasKey("Id");

                    b.HasIndex("SpellbookId");

                    b.ToTable("SpellSimple");
                });

            modelBuilder.Entity("Spellbook3API.Models.SpellbookSpell", b =>
                {
                    b.HasOne("Spellbook3API.Models.Spell", "Spell")
                        .WithMany("SpellbookSpells")
                        .HasForeignKey("SpellId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Spellbook3API.Models.Spellbook", "Spellbook")
                        .WithMany("SpellbookSpells")
                        .HasForeignKey("SpellbookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Spellbook3API.Models.SpellSimple", b =>
                {
                    b.HasOne("Spellbook3API.Models.Spellbook")
                        .WithMany("Spells")
                        .HasForeignKey("SpellbookId");
                });
        }
    }
}
