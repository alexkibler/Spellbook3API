using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spellbook3API.Models
{
    public class SpellbookSpell
    {
        public int SpellId { get; set; }
        public Spell Spell { get; set; }
        public int SpellbookId { get; set; }
        public Spellbook Spellbook { get; set; }
    }
}
