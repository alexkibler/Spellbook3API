namespace Spellbook3API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    public partial class Spell
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpellId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Desc { get; set; }

        public string Page { get; set; }

        public string Range { get; set; }

        public string Components { get; set; }

        public string Material { get; set; }

        public bool? Ritual { get; set; }

        public string Duration { get; set; }

        public bool? Concentration { get; set; }

        public string Casting_time { get; set; }

        public string Level { get; set; }

        public string School { get; set; }

        public string Class { get; set; }

        public string Higher_level { get; set; }

        public string Archetype { get; set; }

        public string Domains { get; set; }

        public string Oaths { get; set; }

        public string Circles { get; set; }

        public string Patrons { get; set; }
        [IgnoreDataMember]
        public virtual List<SpellbookSpell> SpellbookSpells { get; set; }
    }

    public class SpellSimple
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public int Id { get; set; }
        public string Class { get; set; }
    }
}
