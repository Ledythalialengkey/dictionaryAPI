using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dctrestapi.Models;

namespace dctrestapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentsController : ControllerBase
    {
        private readonly ContentsContext _context;
        private List<Content>? listContains;

        public ContentsController(ContentsContext context)
        {
            _context = context;
            listContains = new List<Content>();
        }

        // GET: api/Contents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Content>>> GetContents()
        {
            return await _context.Contents.ToListAsync();
        }
        // GET: api/Contents/strings
        [HttpGet("content/{searchString}")]
        public async Task<ActionResult<IEnumerable<Content>>> ContentContains(string searchString)
        {
            var allContents = await _context.Contents.ToListAsync(); 
            
            var filteredContents = allContents.Where(content =>
                content.contentFrom.Contains(searchString)
            );
            
            return Ok(filteredContents);
        }

        // GET: api/Contents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Content>> GetContent(long id)
        {
            var content = await _context.Contents.FindAsync(id);

            if (content == null)
            {
                return NotFound();
            }

            return content;
        }

        // PUT: api/Contents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContent(long id, Content content)
        {
            if (id != content.Id)
            {
                return BadRequest();
            }

            _context.Entry(content).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContentExists(id))
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

        // POST: api/Contents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Content>> PostContent(Content content)
        {
            _context.Contents.Add(content);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContent", new { id = content.Id }, content);
        }

        // DELETE: api/Contents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContent(long id)
        {
            var content = await _context.Contents.FindAsync(id);
            if (content == null)
            {
                return NotFound();
            }

            _context.Contents.Remove(content);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContentExists(long id)
        {
            return _context.Contents.Any(e => e.Id == id);
        }
    }
}
