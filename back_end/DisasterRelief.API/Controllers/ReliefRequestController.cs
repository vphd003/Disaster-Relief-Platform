using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DisasterRelief.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ReliefRequestController : ControllerBase
{
    private readonly AppDbContext _context;

    public ReliefRequestController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/reliefrequest
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var requests = await _context.ReliefRequests
            .Include(x => x.Requester)
            .Include(x => x.RequestSupplies)
                .ThenInclude(x => x.Supply)
            .ToListAsync();

        return Ok(requests);
    }

    // GET: api/reliefrequest/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var request = await _context.ReliefRequests
            .Include(x => x.RequestSupplies)
                .ThenInclude(x => x.Supply)
            .FirstOrDefaultAsync(x => x.RequestId == id);

        if (request == null)
            return NotFound();

        return Ok(request);
    }

    // POST: api/reliefrequest
    [Authorize(Roles = "Requester")]
    [HttpPost]
    public async Task<IActionResult> Create(ReliefRequest request)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var requester = await _context.Requesters
            .FirstOrDefaultAsync(x => x.UserId == userId);

        if (requester == null)
            return BadRequest("Requester not found.");

        request.RequesterId = requester.RequesterId;
        request.CreatedAt = DateTime.UtcNow;
        request.Status = 0;

        _context.ReliefRequests.Add(request);

        await _context.SaveChangesAsync();

        return Ok(request);
    }

    // PUT: api/reliefrequest/5/status
    [Authorize(Roles = "Coordinator,Admin")]
    [HttpPut("{id}/status")]
    public async Task<IActionResult> UpdateStatus(int id, byte status)
    {
        var request = await _context.ReliefRequests.FindAsync(id);

        if (request == null)
            return NotFound();

        request.Status = status;

        await _context.SaveChangesAsync();

        return Ok(request);
    }

    // DELETE: api/reliefrequest/5
    [Authorize(Roles = "Coordinator,Admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var request = await _context.ReliefRequests.FindAsync(id);

        if (request == null)
            return NotFound();

        _context.ReliefRequests.Remove(request);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}