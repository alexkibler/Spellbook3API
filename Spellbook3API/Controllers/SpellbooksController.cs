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
    [Route("Spellbooks")]
    public class SpellbooksController : Controller
    {
        private readonly SpellbookContext _context;

        public SpellbooksController(SpellbookContext context)
        {
            _context = context;
        }

        // GET: api/Spellbooks
        [HttpGet]
        public IEnumerable<Spellbook> GetSpellbook()
        {
            return _context.Spellbooks;
        }

        [HttpGet("GetSpellbooksByUserId/{userId}")]
        public async Task<IActionResult> GetSpellbooksByUserId([FromRoute] string userId)
        {
            var spellbooks = await _context.Spellbooks.Where(x => x.UserId == userId && !x.IsDeleted).ToListAsync();
            return Ok(spellbooks);
        }

        // GET: api/Spellbooks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpellbook([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var spellbook = await _context.Spellbooks.SingleOrDefaultAsync(m => m.SpellbookId == id);

            if (spellbook == null)
            {
                return NotFound();
            }

            spellbook.Spells = await GetSpellsFromSpellbookId(spellbook.SpellbookId);
            return Ok(spellbook);
        }

        // PUT: api/Spellbooks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpellbook([FromRoute] int id, [FromBody] Spellbook updatedSpellbook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != updatedSpellbook.SpellbookId)
            {
                return BadRequest();
            }
            var spellbook = await _context.Spellbooks.Where(x => x.SpellbookId == id).FirstOrDefaultAsync();
            spellbook.Name = updatedSpellbook.Name ?? spellbook.Name;
            spellbook.UserId = updatedSpellbook.UserId ?? spellbook.UserId;
            spellbook.Description = updatedSpellbook.Description ?? spellbook.Description;
            spellbook.CharacterSheetUrl = updatedSpellbook.CharacterSheetUrl ?? spellbook.CharacterSheetUrl;
            spellbook.Class = updatedSpellbook.Class.ToLower() ?? spellbook.Class.ToLower();            
            spellbook.ImageUrl = updatedSpellbook.ImageUrl ?? spellbook.ImageUrl;
            spellbook.IsDeleted = spellbook.IsDeleted;
            spellbook.DateModified = DateTime.UtcNow;
            try
            { 
                _context.Attach(spellbook);
                _context.Entry(spellbook).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpellbookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(spellbook);
        }

        // POST: api/Spellbooks
        [HttpPost]
        public async Task<IActionResult> PostSpellbook([FromBody] Spellbook spellbook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            spellbook.DateCreated = DateTime.UtcNow;
            spellbook.DateModified = DateTime.UtcNow;
            _context.Spellbooks.Add(spellbook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpellbook", new { id = spellbook.SpellbookId }, spellbook);
        }

        //// POST: api/Spellbooks
        [HttpPost("AddSpell")]
        public async Task<IActionResult> AddSpell([FromBody]SpellbookSpell spellToAdd)
        {
            var spellbook = _context.Spellbooks.Where(x => x.SpellbookId == spellToAdd.SpellbookId).FirstOrDefault();
            var spell = _context.Spells.Where(x => x.SpellId == spellToAdd.SpellId).FirstOrDefault();
            if (spellbook != null && spell != null)
            {
                if (spellbook.SpellbookSpells == null)
                {
                    spellbook.SpellbookSpells = new List<SpellbookSpell>();
                }
                spellToAdd.Spellbook = spellbook;
                spellToAdd.Spell = spell;
                spellbook.SpellbookSpells.Add(spellToAdd);
                await _context.SaveChangesAsync();
            }
            else
            {
                return BadRequest();
            }            
            return CreatedAtAction("GetSpellbook", new { id = spellbook.SpellbookId }, spellbook);
        }

        // DELETE: api/Spellbooks/5
        [HttpPost("Delete/{id}")]
        public async Task<IActionResult> DeleteSpellbook([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var spellbook = await _context.Spellbooks.SingleOrDefaultAsync(m => m.SpellbookId == id);
            if (spellbook == null)
            {
                return NotFound();
            }

            spellbook.IsDeleted = true;
            await _context.SaveChangesAsync();

            return Ok(spellbook);
        }

        // POST: api/Spellbooks/Delete
        [HttpPost("DeleteSpell")]
        public async Task<IActionResult> DeleteSpellFromSpellbook([FromBody] SpellbookSpell spell)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var spellbook = await _context.Spellbooks.SingleOrDefaultAsync(m => m.SpellbookId == spell.SpellbookId);
            if (spellbook == null)
            {
                return NotFound();
            }
            _context.SpellbookSpell.Remove(spell);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool SpellbookExists(int id)
        {
            return _context.Spellbooks.Any(e => e.SpellbookId == id);
        }

        private async Task<List<SpellSimple>> GetSpellsFromSpellbookId(int id)
        {
            var spellbookSpells = await _context.SpellbookSpell.Where(x => x.SpellbookId == id).Select(x => x.Spell).ToListAsync();
            return spellbookSpells.Select(x => new SpellSimple { Name = x.Name, Level = x.Level, Id = x.SpellId, Class = x.Class }).ToList();
        }
    }

    public class AddSpell
    {
        public int SpellbookId { get; set; }
        public int SpellId { get; set; }
    }
}