using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spellbook3API.Models;
using Microsoft.EntityFrameworkCore;

namespace Spellbook3API.Models
{
    public class SpellbookContext : DbContext
    {
        public SpellbookContext(DbContextOptions<SpellbookContext> options) : base(options)
        {

        }
        public DbSet<Spell> Spells { get; set; }

        public DbSet<Spellbook> Spellbooks { get; set; }
        public DbSet<SpellbookSpell> SpellbookSpell { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpellbookSpell>()
                .HasKey(t => new { t.SpellId, t.SpellbookId });

            modelBuilder.Entity<SpellbookSpell>()
                .HasOne(pt => pt.Spell)
                .WithMany(p => p.SpellbookSpells)
                .HasForeignKey(pt => pt.SpellId);

            modelBuilder.Entity<SpellbookSpell>()
                .HasOne(pt => pt.Spellbook)
                .WithMany(t => t.SpellbookSpells)
                .HasForeignKey(pt => pt.SpellbookId);
        }
    }
}
