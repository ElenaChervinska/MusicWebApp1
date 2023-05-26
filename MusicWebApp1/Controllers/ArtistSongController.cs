using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicWebApp1.Models;

namespace MusicWebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistSongController : ControllerBase
    {
        private readonly MusicApiContext _context;

        public ArtistSongController(MusicApiContext context)
        {
            _context = context;
        }

        // GET: api/ArtistSong
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArtistSong>>> GetArtistSongs()
        {
            if (_context.ArtistSongs == null)
            {
                return NotFound();
            }

            return await _context.ArtistSongs.ToListAsync();
        }

        // GET: api/ArtistSong/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArtistSong>> GetArtistSong(int id)
        {
            if (_context.ArtistSongs == null)
            {
                return NotFound();
            }

            var artistSong = await _context.ArtistSongs.FindAsync(id);

            if (artistSong == null)
            {
                return NotFound();
            }

            return artistSong;
        }

        // PUT: api/ArtistSong/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtistSong(int id, ArtistSong artistSong)
        {
            if (id != artistSong.Id)
            {
                return BadRequest();
            }

            _context.Entry(artistSong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistSongExists(id))
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

        // POST: api/ArtistSong
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArtistSong>> PostArtistSong(ArtistSong artistSong)
        {
            if (_context.ArtistSongs == null)
            {
                return Problem("Entity set 'MusicApiContext.ArtistSongs'  is null.");
            }

            _context.ArtistSongs.Add(artistSong);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtistSong", new { id = artistSong.Id }, artistSong);
        }

        // DELETE: api/ArtistSong/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtistSong(int id)
        {
            if (_context.ArtistSongs == null)
            {
                return NotFound();
            }

            var artistSong = await _context.ArtistSongs.FindAsync(id);
            if (artistSong == null)
            {
                return NotFound();
            }

            _context.ArtistSongs.Remove(artistSong);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArtistSongExists(int id)
        {
            return (_context.ArtistSongs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
