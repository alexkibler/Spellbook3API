using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Spellbook3API.Models
{
    public class Spellbook
    {
        public int SpellbookId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public string Class { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public List<SpellSimple> Spells { get; set; }
        public Character CharacterSheet { get; set; }
        public int CharacterSheetId { get; set; }
        [IgnoreDataMember]
        public virtual List<SpellbookSpell> SpellbookSpells { get; set; }
    }
}
