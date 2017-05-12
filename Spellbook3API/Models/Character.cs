using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spellbook3API.Models
{
public class Character
{
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }
public string Name { get; set; }
public string Race { get; set; }
public string Alignment { get; set; }
public int? ProficiencyBonus { get; set; }
public bool Inspiration { get; set; }
public int? PassivePerception { get; set; }
public int? ArmorClass { get; set; }
public int? Initiative { get; set; }
public int? Speed { get; set; }
public int? MaxHP { get; set; }
public int? CurrentHP { get; set; }
public string TotalHitDice { get; set; }
public string CurrentHitDice { get; set; }
public string Equipment { get; set; }
public string PersonalityTraits { get; set; }
public string Ideals { get; set; }
public string Bonds { get; set; }
public string Flaws { get; set; }
public string ClassFeatures { get; set; }
public int SpellbookId { get; set; }
public DeathSaves DeathSaves{ get; set; }
public List<ClassLevel> ClassLevels { get; set; }
public AbilityScores AbilityScores { get; set; }
public SavingThrows SavingThrows { get; set; }
public Skills Skills { get; set; }
public List<Attack> Attacks { get; set; }
public List<Ammo> Ammos { get; set; }
public Currency Currency { get; set; }
}

    public class Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal? CP { get; set; }
        public decimal? SP { get; set; }
        public decimal? EP { get; set; }
        public decimal? GP { get; set; }
        public decimal? PP { get; set; }
    }

    public class Attack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AttackModifier { get; set; }
        public string Damage { get; set; }
    }

    public class Ammo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Remaining { get; set; }
        public int? Max { get; set; }
    }

    public class DeathSaves
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool? Success1 { get; set; }
        public bool? Success2 { get; set; }
        public bool? Success3 { get; set; }
        public bool? Failure1 { get; set; }
        public bool? Failure2 { get; set; }
        public bool? Failure3 { get; set; }
    }


    public class ClassLevel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? Level { get; set; }
        public string Class { get; set; }
    }

    public class AbilityScores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Constitution { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }
    }
    

    public class SavingThrows
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int StrengthValue { get; set; }
        public bool StrengthProficient { get; set; }
        public int DexterityValue { get; set; }
        public bool DexterityProficient { get; set; }
        public int ConstitutionValue { get; set; }
        public bool ConstitutionProficient { get; set; }
        public int IntelligenceValue { get; set; }
        public bool IntelligenceProficient { get; set; }
        public int WisdomValue { get; set; }
        public bool WisdomProficient { get; set; }
        public int CharismaValue { get; set; }
        public bool CharismaProficient { get; set; }
    }
    
    public class Skills
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int AcrobaticsValue { get; set; }
        public bool AcrobaticsProficient1 { get; set; }
        public bool AcrobaticsProficient2 { get; set; }
        public int AnimalHandlingValue { get; set; }
        public bool AnimalHandlingProficient1 { get; set; }
        public bool AnimalHandlingProficient2 { get; set; }
        public int ArcanaValue { get; set; }
        public bool ArcanaProficient1 { get; set; }
        public bool ArcanaProficient2 { get; set; }
        public int AthleticsValue { get; set; }
        public bool AthleticsProficient1 { get; set; }
        public bool AthleticsProficient2 { get; set; }
        public int DeceptionValue { get; set; }
        public bool DeceptionProficient1 { get; set; }
        public bool DeceptionProficient2 { get; set; }
        public int HistoryValue { get; set; }
        public bool HistoryProficient1 { get; set; }
        public bool HistoryProficient2 { get; set; }
        public int InsightValue { get; set; }
        public bool InsightProficient1 { get; set; }
        public bool InsightProficient2 { get; set; }
        public int IntimidationValue { get; set; }
        public bool IntimidationProficient1 { get; set; }
        public bool IntimidationProficient2 { get; set; }
        public int InvestigationValue { get; set; }
        public bool InvestigationProficient1 { get; set; }
        public bool InvestigationProficient2 { get; set; }
        public int MedicineValue { get; set; }
        public bool MedicineProficient1 { get; set; }
        public bool MedicineProficient2 { get; set; }
        public int PerceptionValue { get; set; }
        public bool PerceptionProficient1 { get; set; }
        public bool PerceptionProficient2 { get; set; }
        public int PerformanceValue { get; set; }
        public bool PerformanceProficient1 { get; set; }
        public bool PerformanceProficient2 { get; set; }
        public int PersuasionValue { get; set; }
        public bool PersuasionProficient1 { get; set; }
        public bool PersuasionProficient2 { get; set; }
        public int ReligionValue { get; set; }
        public bool ReligionProficient1 { get; set; }
        public bool ReligionProficient2 { get; set; }
        public int SleightOfHandValue { get; set; }
        public bool SleightOfHandProficient1 { get; set; }
        public bool SleightOfHandProficient2 { get; set; }
        public int StealthValue { get; set; }
        public bool StealthProficient1 { get; set; }
        public bool StealthProficient2 { get; set; }
        public int SurvivalValue { get; set; }
        public bool SurvivalProficient1 { get; set; }
        public bool SurvivalProficient2 { get; set; }
    }
}
