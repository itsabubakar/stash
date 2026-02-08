using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stash.Data;
using Stash.Dtos;
using Stash.Models;

namespace Stash.Controllers
{
    [ApiController]
    [Route("api/bookmarks")]
    public class BookmarksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookmarksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookmarkDto dto)
        {
            var bookmark = new Bookmark
            {
                Url = dto.Url,
                Title = dto.Title,
                Description = dto.Description
            };

            _context.Bookmarks.Add(bookmark);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = bookmark.Id }, bookmark);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var bookmark = await _context.Bookmarks.FindAsync(id);
            if (bookmark == null) return NotFound();

            return Ok(bookmark);
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var bookmark = await _context.Bookmarks.ToListAsync();
            if (bookmark == null) return NotFound();

            return Ok(bookmark);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var bookmark = await _context.Bookmarks.FindAsync(id);
            if(bookmark == null)
                return NotFound();

            _context.Bookmarks.Remove(bookmark);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] BookmarkEditDto dto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var bookmark = await _context.Bookmarks.FindAsync(id);
            if(bookmark == null)
                return NotFound();

            if(dto.Title !=null)
                bookmark.Title = dto.Title;

            if(dto.Url != null)
                bookmark.Url = dto.Url;
            if(dto.Description != null)
                bookmark.Description = dto.Description;
            
            bookmark.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return NoContent();
        }
       
    }

}
