using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Spellbook3API.Models;

namespace Spellbook3API.Migrations
{
    [DbContext(typeof(SpellbookContext))]
    [Migration("20170510161203_m12")]
    partial class m12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Spellbook3API.Models.AbilityScores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Charisma");

                    b.Property<int?>("Constitution");

                    b.Property<int?>("Dexterity");

                    b.Property<int?>("Intelligence");

                    b.Property<int?>("Strength");

                    b.Property<int?>("Wisdom");

                    b.HasKey("Id");

                    b.ToTable("AbilityScores");
                });

            modelBuilder.Entity("Spellbook3API.Models.Ammo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CharacterId");

                    b.Property<int?>("Max");

                    b.Property<string>("Name");

                    b.Property<int?>("Remaining");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Ammo");
                });

            modelBuilder.Entity("Spellbook3API.Models.Attack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AttackModifier");

                    b.Property<int?>("CharacterId");

                    b.Property<string>("Damage");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Attack");
                });

            modelBuilder.Entity("Spellbook3API.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AbilityScoresId");

                    b.Property<string>("Alignment");

                    b.Property<int?>("ArmorClass");

                    b.Property<string>("Bonds");

                    b.Property<string>("ClassFeatures");

                    b.Property<int?>("CurrencyId");

                    b.Property<int?>("CurrentHP");

                    b.Property<string>("CurrentHitDice");

                    b.Property<int?>("DeathSavesId");

                    b.Property<string>("Equipment");

                    b.Property<string>("Flaws");

                    b.Property<string>("Ideals");

                    b.Property<int?>("Initiative");

                    b.Property<bool>("Inspiration");

                    b.Property<int?>("MaxHP");

                    b.Property<string>("Name");

                    b.Property<string>("PersonalityTraits");

                    b.Property<int?>("ProficiencyBonus");

                    b.Property<string>("Race");

                    b.Property<int?>("SavingThrowsId");

                    b.Property<int?>("SkillsId");

                    b.Property<int?>("Speed");

                    b.Property<string>("TotalHitDice");

                    b.HasKey("Id");

                    b.HasIndex("AbilityScoresId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("DeathSavesId");

                    b.HasIndex("SavingThrowsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Spellbook3API.Models.ClassLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CharacterId");

                    b.Property<string>("Class");

                    b.Property<int?>("Level");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("ClassLevel");
                });

            modelBuilder.Entity("Spellbook3API.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("CP");

                    b.Property<decimal?>("EP");

                    b.Property<decimal?>("GP");

                    b.Property<decimal?>("PP");

                    b.Property<decimal?>("SP");

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("Spellbook3API.Models.DeathSaves", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Failure1");

                    b.Property<bool?>("Failure2");

                    b.Property<bool?>("Failure3");

                    b.Property<bool?>("Success1");

                    b.Property<bool?>("Success2");

                    b.Property<bool?>("Success3");

                    b.HasKey("Id");

                    b.ToTable("DeathSaves");
                });

            modelBuilder.Entity("Spellbook3API.Models.SavingThrow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Proficient");

                    b.Property<int?>("Value");

                    b.HasKey("Id");

                    b.ToTable("SavingThrow");
                });

            modelBuilder.Entity("Spellbook3API.Models.SavingThrows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CharismaId");

                    b.Property<int?>("ConstitutionId");

                    b.Property<int?>("DexterityId");

                    b.Property<int?>("IntelligenceId");

                    b.Property<int?>("StrengthId");

                    b.Property<int?>("WisdomId");

                    b.HasKey("Id");

                    b.HasIndex("CharismaId");

                    b.HasIndex("ConstitutionId");

                    b.HasIndex("DexterityId");

                    b.HasIndex("IntelligenceId");

                    b.HasIndex("StrengthId");

                    b.HasIndex("WisdomId");

                    b.ToTable("SavingThrows");
                });

            modelBuilder.Entity("Spellbook3API.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Proficient1");

                    b.Property<bool?>("Proficient2");

                    b.Property<int?>("Value");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Spellbook3API.Models.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AcrobaticsId");

                    b.Property<int?>("AnimalHandlingId");

                    b.Property<int?>("ArcanaId");

                    b.Property<int?>("AthleticsId");

                    b.Property<int?>("DeceptionId");

                    b.Property<int?>("HistoryId");

                    b.Property<int?>("InsightId");

                    b.Property<int?>("IntimidationId");

                    b.Property<int?>("InvestigationId");

                    b.Property<int?>("MedicineId");

                    b.Property<int?>("PerceptionId");

                    b.Property<int?>("PerformanceId");

                    b.Property<int?>("PersuasionId");

                    b.Property<int?>("ReligionId");

                    b.Property<int?>("SleightOfHandId");

                    b.Property<int?>("StealthId");

                    b.Property<int?>("SurvivalId");

                    b.HasKey("Id");

                    b.HasIndex("AcrobaticsId");

                    b.HasIndex("AnimalHandlingId");

                    b.HasIndex("ArcanaId");

                    b.HasIndex("AthleticsId");

                    b.HasIndex("DeceptionId");

                    b.HasIndex("HistoryId");

                    b.HasIndex("InsightId");

                    b.HasIndex("IntimidationId");

                    b.HasIndex("InvestigationId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PerceptionId");

                    b.HasIndex("PerformanceId");

                    b.HasIndex("PersuasionId");

                    b.HasIndex("ReligionId");

                    b.HasIndex("SleightOfHandId");

                    b.HasIndex("StealthId");

                    b.HasIndex("SurvivalId");

                    b.ToTable("Skills");
                });

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

            modelBuilder.Entity("Spellbook3API.Models.Ammo", b =>
                {
                    b.HasOne("Spellbook3API.Models.Character")
                        .WithMany("Ammos")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("Spellbook3API.Models.Attack", b =>
                {
                    b.HasOne("Spellbook3API.Models.Character")
                        .WithMany("Attacks")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("Spellbook3API.Models.Character", b =>
                {
                    b.HasOne("Spellbook3API.Models.AbilityScores", "AbilityScores")
                        .WithMany()
                        .HasForeignKey("AbilityScoresId");

                    b.HasOne("Spellbook3API.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Spellbook3API.Models.DeathSaves", "DeathSaves")
                        .WithMany()
                        .HasForeignKey("DeathSavesId");

                    b.HasOne("Spellbook3API.Models.SavingThrows", "SavingThrows")
                        .WithMany()
                        .HasForeignKey("SavingThrowsId");

                    b.HasOne("Spellbook3API.Models.Skills", "Skills")
                        .WithMany()
                        .HasForeignKey("SkillsId");
                });

            modelBuilder.Entity("Spellbook3API.Models.ClassLevel", b =>
                {
                    b.HasOne("Spellbook3API.Models.Character")
                        .WithMany("ClassLevels")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("Spellbook3API.Models.SavingThrows", b =>
                {
                    b.HasOne("Spellbook3API.Models.SavingThrow", "Charisma")
                        .WithMany()
                        .HasForeignKey("CharismaId");

                    b.HasOne("Spellbook3API.Models.SavingThrow", "Constitution")
                        .WithMany()
                        .HasForeignKey("ConstitutionId");

                    b.HasOne("Spellbook3API.Models.SavingThrow", "Dexterity")
                        .WithMany()
                        .HasForeignKey("DexterityId");

                    b.HasOne("Spellbook3API.Models.SavingThrow", "Intelligence")
                        .WithMany()
                        .HasForeignKey("IntelligenceId");

                    b.HasOne("Spellbook3API.Models.SavingThrow", "Strength")
                        .WithMany()
                        .HasForeignKey("StrengthId");

                    b.HasOne("Spellbook3API.Models.SavingThrow", "Wisdom")
                        .WithMany()
                        .HasForeignKey("WisdomId");
                });

            modelBuilder.Entity("Spellbook3API.Models.Skills", b =>
                {
                    b.HasOne("Spellbook3API.Models.Skill", "Acrobatics")
                        .WithMany()
                        .HasForeignKey("AcrobaticsId");

                    b.HasOne("Spellbook3API.Models.Skill", "AnimalHandling")
                        .WithMany()
                        .HasForeignKey("AnimalHandlingId");

                    b.HasOne("Spellbook3API.Models.Skill", "Arcana")
                        .WithMany()
                        .HasForeignKey("ArcanaId");

                    b.HasOne("Spellbook3API.Models.Skill", "Athletics")
                        .WithMany()
                        .HasForeignKey("AthleticsId");

                    b.HasOne("Spellbook3API.Models.Skill", "Deception")
                        .WithMany()
                        .HasForeignKey("DeceptionId");

                    b.HasOne("Spellbook3API.Models.Skill", "History")
                        .WithMany()
                        .HasForeignKey("HistoryId");

                    b.HasOne("Spellbook3API.Models.Skill", "Insight")
                        .WithMany()
                        .HasForeignKey("InsightId");

                    b.HasOne("Spellbook3API.Models.Skill", "Intimidation")
                        .WithMany()
                        .HasForeignKey("IntimidationId");

                    b.HasOne("Spellbook3API.Models.Skill", "Investigation")
                        .WithMany()
                        .HasForeignKey("InvestigationId");

                    b.HasOne("Spellbook3API.Models.Skill", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId");

                    b.HasOne("Spellbook3API.Models.Skill", "Perception")
                        .WithMany()
                        .HasForeignKey("PerceptionId");

                    b.HasOne("Spellbook3API.Models.Skill", "Performance")
                        .WithMany()
                        .HasForeignKey("PerformanceId");

                    b.HasOne("Spellbook3API.Models.Skill", "Persuasion")
                        .WithMany()
                        .HasForeignKey("PersuasionId");

                    b.HasOne("Spellbook3API.Models.Skill", "Religion")
                        .WithMany()
                        .HasForeignKey("ReligionId");

                    b.HasOne("Spellbook3API.Models.Skill", "SleightOfHand")
                        .WithMany()
                        .HasForeignKey("SleightOfHandId");

                    b.HasOne("Spellbook3API.Models.Skill", "Stealth")
                        .WithMany()
                        .HasForeignKey("StealthId");

                    b.HasOne("Spellbook3API.Models.Skill", "Survival")
                        .WithMany()
                        .HasForeignKey("SurvivalId");
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
