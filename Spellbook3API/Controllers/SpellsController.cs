using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spellbook3API.Models;

namespace Spellbook3API.Controllers
{
    [Produces("application/json")]
    [Route("Spells")]
    public class SpellsController : Controller
    {
        private readonly SpellbookContext _context;

        public SpellsController(SpellbookContext context)
        {
            _context = context;
        }

        // GET: api/Spells
        [HttpGet]
        public IEnumerable<Spell> GetSpell()
        {
            return _context.Spells;
        }



        // GET: api/Spells
        [HttpGet("GetSpellList")]
        public IEnumerable<SpellSimple> GetSpellList()
        {
            return _context.Spells.Select(x => new SpellSimple { Name = x.Name, Level = x.Level, Id = x.SpellId, Class = x.Class });
        }

        // GET: api/Spells/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpell([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var spell = await _context.Spells.SingleOrDefaultAsync(m => m.SpellId == id);

            if (spell == null)
            {
                return NotFound();
            }

            return Ok(spell);
        }

        // PUT: api/Spells/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpell([FromRoute] int id, [FromBody] Spell spell)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != spell.SpellId)
            {
                return BadRequest();
            }
            

            try
            {
                var spellToUpdate = _context.Spells.Where(x => x.SpellId == id).FirstOrDefault();
                spellToUpdate.Archetype = spell.Archetype;
                spellToUpdate.Casting_time = spell.Casting_time;
                spellToUpdate.Circles = spell.Circles;
                spellToUpdate.Class = spell.Class;
                spellToUpdate.Components = spell.Components;
                spellToUpdate.Concentration = spell.Concentration;
                spellToUpdate.Desc = spell.Desc;
                spellToUpdate.Domains = spell.Domains;
                spellToUpdate.Duration = spell.Duration;
                spellToUpdate.Higher_level = spell.Higher_level;
                spellToUpdate.Level = spell.Level;
                spellToUpdate.Material = spell.Material;
                spellToUpdate.Name = spell.Name;
                spellToUpdate.Oaths = spell.Oaths;
                spellToUpdate.Page = spell.Page;
                spellToUpdate.Patrons = spell.Patrons;
                spellToUpdate.Range = spell.Range;
                spellToUpdate.Ritual = spell.Ritual;
                spellToUpdate.School = spell.School;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpellExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Spells
        //[HttpPost]
        //public async Task<IActionResult> PostSpell([FromBody] Spell spell)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Spells.Add(spell);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSpell", new { id = spell.Id }, spell);
        //}

        // POST: api/Spells
        [HttpPost]
        public async Task<IActionResult> PostSpell([FromBody] List<Spell> spells)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Spells.AddRange(spells);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Spells/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpell([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var spell = await _context.Spells.SingleOrDefaultAsync(m => m.SpellId == id);
            if (spell == null)
            {
                return NotFound();
            }

            _context.Spells.Remove(spell);
            await _context.SaveChangesAsync();

            return Ok(spell);
        }

        private bool SpellExists(int id)
        {
            return _context.Spells.Any(e => e.SpellId == id);
        }
    }
}