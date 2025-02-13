using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameApi.Data;
using VideoGameApi.Models;

namespace VideoGameApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VideoGameDetailsController(VideoGameDBContext context): ControllerBase
{
    private readonly VideoGameDBContext _context = context; 

    [HttpGet]
    public async Task<ActionResult<List<VideoGameDetails>>> GetVideoGameDetails()
    {
        return Ok(await _context.VideoGameDetails.ToListAsync()); 
        

    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<VideoGameDetails>> GetVideoGameDetailsById(int id)
    {
        var gameDetails = await _context.VideoGameDetails.FindAsync(id);
        if(gameDetails is null) return NotFound();
        return Ok(gameDetails);
    }

    [HttpPost]
    public async Task<ActionResult<VideoGameDetails>> CreateVideoGameDetails(VideoGameDetails gameDetails)
    {
        if(gameDetails is null)
        {
            return BadRequest();
        }

        _context.VideoGameDetails.Add(gameDetails);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetVideoGameDetailsById), new { id = gameDetails.Id}, gameDetails);


    }

    [HttpPut("{id:int}")]
     public async Task<IActionResult> UpdateVideoGameDetails(int id, VideoGameDetails updatedGameDetails)
    {
        var gameDetails = await _context.VideoGameDetails.FindAsync(id); 
        if(gameDetails is null)
        {
            return NotFound();

        }
        gameDetails.Description = updatedGameDetails.Description;
        gameDetails.ReleaseData = updatedGameDetails.ReleaseData;
        
        await _context.SaveChangesAsync(); 

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteVideoGameDetails(int id)
    {
        var gameDetails = await _context.VideoGameDetails.FindAsync(id);

        if(gameDetails is null) return NotFound();

        _context.VideoGameDetails.Remove(gameDetails);

        await _context.SaveChangesAsync();
        return NoContent();
    }
    



}