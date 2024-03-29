using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Characterlist.Models;

namespace Characterlist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterlistController(CharacterlistContext context) : ControllerBase
    {
        private readonly CharacterlistContext _context = context;

        // GET: api/Characterlist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Characterstats>>> GetCharacterlistItems()
        {
            return await _context.Characterlist.ToListAsync();
        }

        // GET: api/Characterlist/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Characterstats>> GetCharacterlistitem(long id)
        {
            var characterlistitem = await _context.Characterlist.FindAsync(id);

            if (characterlistitem == null)
            {
                return NotFound();
            }

            return characterlistitem;
        }

        // PUT: api/Characterlist/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterlistitem(long id, Characterstats characterlistitem)
        {
            if (id != characterlistitem.Id)
            {
                return BadRequest();
            }

            _context.Entry(characterlistitem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterlistitemExists(id))
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

        // POST: api/Characterlistitems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Characterstats>> PostCharacterlistitem(Characterstats characterlistitem)
        {
            _context.Characterlist.Add(characterlistitem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterlistitem", new { id = characterlistitem.Id }, characterlistitem);
        }

        // DELETE: api/Characterlistitems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterlistitem(long id)
        {
            var characterlistitem = await _context.Characterlist.FindAsync(id);
            if (characterlistitem == null)
            {
                return NotFound();
            }

            _context.Characterlist.Remove(characterlistitem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterlistitemExists(long id)
        {
            return _context.Characterlist.Any(e => e.Id == id);
        }
    }
}