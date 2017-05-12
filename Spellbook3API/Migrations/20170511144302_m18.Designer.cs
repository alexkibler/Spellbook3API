using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Spellbook3API.Models;

namespace Spellbook3API.Migrations
{
    [DbContext(typeof(SpellbookContext))]
    [Migration("20170511144302_m18")]
    partial class m18
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

                    b.Property<int>("SpellbookId");

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

            modelBuilder.Entity("Spellbook3API.Models.SavingThrows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CharismaProficient");

                    b.Property<int>("CharismaValue");

                    b.Property<bool>("ConstitutionProficient");

                    b.Property<int>("ConstitutionValue");

                    b.Property<bool>("DexterityProficient");

                    b.Property<int>("DexterityValue");

                    b.Property<bool>("IntelligenceProficient");

                    b.Property<int>("IntelligenceValue");

                    b.Property<bool>("StrengthProficient");

                    b.Property<int>("StrengthValue");

                    b.Property<bool>("WisdomProficient");

                    b.Property<int>("WisdomValue");

                    b.HasKey("Id");

                    b.ToTable("SavingThrows");
                });

            modelBuilder.Entity("Spellbook3API.Models.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AcrobaticsProficient1");

                    b.Property<bool>("AcrobaticsProficient2");

                    b.Property<int>("AcrobaticsValue");

                    b.Property<bool>("AnimalHandlingProficient1");

                    b.Property<bool>("AnimalHandlingProficient2");

                    b.Property<int>("AnimalHandlingValue");

                    b.Property<bool>("ArcanaProficient1");

                    b.Property<bool>("ArcanaProficient2");

                    b.Property<int>("ArcanaValue");

                    b.Property<bool>("AthleticsProficient1");

                    b.Property<bool>("AthleticsProficient2");

                    b.Property<int>("AthleticsValue");

                    b.Property<bool>("DeceptionProficient1");

                    b.Property<bool>("DeceptionProficient2");

                    b.Property<int>("DeceptionValue");

                    b.Property<bool>("HistoryProficient1");

                    b.Property<bool>("HistoryProficient2");

                    b.Property<int>("HistoryValue");

                    b.Property<bool>("InsightProficient1");

                    b.Property<bool>("InsightProficient2");

                    b.Property<int>("InsightValue");

                    b.Property<bool>("IntimidationProficient1");

                    b.Property<bool>("IntimidationProficient2");

                    b.Property<int>("IntimidationValue");

                    b.Property<bool>("InvestigationProficient1");

                    b.Property<bool>("InvestigationProficient2");

                    b.Property<int>("InvestigationValue");

                    b.Property<bool>("MedicineProficient1");

                    b.Property<bool>("MedicineProficient2");

                    b.Property<int>("MedicineValue");

                    b.Property<bool>("PerceptionProficient1");

                    b.Property<bool>("PerceptionProficient2");

                    b.Property<int>("PerceptionValue");

                    b.Property<bool>("PerformanceProficient1");

                    b.Property<bool>("PerformanceProficient2");

                    b.Property<int>("PerformanceValue");

                    b.Property<bool>("PersuasionProficient1");

                    b.Property<bool>("PersuasionProficient2");

                    b.Property<int>("PersuasionValue");

                    b.Property<bool>("ReligionProficient1");

                    b.Property<bool>("ReligionProficient2");

                    b.Property<int>("ReligionValue");

                    b.Property<bool>("SleightOfHandProficient1");

                    b.Property<bool>("SleightOfHandProficient2");

                    b.Property<int>("SleightOfHandValue");

                    b.Property<bool>("StealthProficient1");

                    b.Property<bool>("StealthProficient2");

                    b.Property<int>("StealthValue");

                    b.Property<bool>("SurvivalProficient1");

                    b.Property<bool>("SurvivalProficient2");

                    b.Property<int>("SurvivalValue");

                    b.HasKey("Id");

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

                    b.Property<int?>("CharacterId");

                    b.Property<int>("CharacterSheetId");

                    b.Property<string>("Class");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("SpellbookId");

                    b.HasIndex("CharacterId");

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

            modelBuilder.Entity("Spellbook3API.Models.Spellbook", b =>
                {
                    b.HasOne("Spellbook3API.Models.Character", "CharacterSheet")
                        .WithMany()
                        .HasForeignKey("CharacterId");
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
