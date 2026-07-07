using DisasterReliefAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DisasterRelief.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class VolunteerController : ControllerBase
{
    private readonly AppDbContext _context;

    public VolunteerController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/volunteer/me
    [Authorize(Roles = "Volunteer")]
    [HttpGet("me")]
    public async Task<IActionResult> MyVolunteerInfo()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var volunteer = await _context.Volunteers
            .Include(v => v.VolunteerSkills)
                .ThenInclude(x => x.Skill)
            .FirstOrDefaultAsync(v => v.UserId == userId);

        if (volunteer == null)
            return NotFound();

        return Ok(volunteer);
    }

    // GET: api/volunteer
    [Authorize(Roles = "Coordinator,Admin")]
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var volunteers = await _context.Volunteers
            .Include(x => x.User)
            .Include(x => x.VolunteerSkills)
                .ThenInclude(x => x.Skill)
            .ToListAsync();

        return Ok(volunteers);
    }

    // GET: api/volunteer/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var volunteer = await _context.Volunteers
            .Include(v => v.User)
            .Include(v => v.VolunteerSkills)
                .ThenInclude(x => x.Skill)
            .FirstOrDefaultAsync(x => x.VolunteerId == id);

        if (volunteer == null)
            return NotFound();

        return Ok(volunteer);
    }
}