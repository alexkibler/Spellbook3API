﻿using System;
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
        public List<SpellSimple> Spells { get; set; }
        [IgnoreDataMember]
        public virtual List<SpellbookSpell> SpellbookSpells { get; set; }
    }
}