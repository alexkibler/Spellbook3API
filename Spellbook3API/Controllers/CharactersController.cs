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
    [Route("Characters")]
    public class CharactersController : Controller
    {
        private readonly SpellbookContext _context;

        public CharactersController(SpellbookContext context)
        {
            _context = context;
        }

        // GET: api/Characters
        [HttpGet]
        public async Task<IEnumerable<Character>> GetCharacters()
        {
            var characters = await _context.Characters
                .Include(x => x.AbilityScores)
                .Include(x => x.Ammos)
                .Include(x => x.Attacks)
                .Include(x => x.ClassLevels)
                .Include(x => x.Currency)
                .Include(x => x.DeathSaves)
                .Include(x => x.SavingThrows)
                .Include(x => x.Skills)
                .ToListAsync();
            return characters;
        }

        // GET: api/Characters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacter([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var character = await _context.Characters
                .Include(x => x.AbilityScores)
                .Include(x => x.Ammos)
                .Include(x => x.Attacks)
                .Include(x => x.ClassLevels)
                .Include(x => x.Currency)
                .Include(x => x.DeathSaves)
                .Include(x => x.SavingThrows)
                .Include(x => x.Skills).SingleOrDefaultAsync(m => m.Id == id);

            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }

        // PUT: api/Characters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacter([FromRoute] int id, [FromBody] Character character)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != character.Id)
            {
                return BadRequest();
            }


            try
            {
                _context.Update(character);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/Characters
        [HttpPost]
        public async Task<IActionResult> PostCharacter([FromBody] Character character)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Characters.Add(character);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacter", new { id = character.Id }, character);
        }

        // DELETE: api/Characters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacter([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var character = await _context.Characters.SingleOrDefaultAsync(m => m.Id == id);
            if (character == null)
            {
                return NotFound();
            }

            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();

            return Ok(character);
        }

        private bool CharacterExists(int id)
        {
            return _context.Characters.Any(e => e.Id == id);
        }
    }
}