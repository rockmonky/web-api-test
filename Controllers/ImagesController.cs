using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace web_api_test;

[ApiController]
[Route("api/[controller]")]
public class ImagesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ImagesController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet("{id}")]

    public async Task<ActionResult<IEnumerable<string>>> GetAllImagesByJourneyId( int id)
    {
        var images = await _context.Viajefoto.Where(x => x.vi_id == id && x.to_id == 1).Select(x => x.vf_path).ToListAsync();
        if (images == null)
        {
            return NotFound();
        }
        return images;
    }


    // [HttpPost]
    // public async Task PostImage([FromBody]  )
    // {

    // }

}
