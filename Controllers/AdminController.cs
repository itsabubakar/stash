using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stash.Data;

[ApiController]
[Route("admin")]
// [Authorize(Roles ="Admin")]
public sealed class AdminController : ControllerBase
{
    private readonly AppDbContext _context;

    public AdminController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet("overview")]
    public async Task<ActionResult<AdminOverviewDto>> GetOverview()
    {
        var dto = new AdminOverviewDto
        {
            TotalBookmarks = await _context.Bookmarks.CountAsync()
        };

        return Ok(dto);
    }
}