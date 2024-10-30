using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace web_api_test;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public LoginController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult> GetUser(string username, string password, int applicationId)
    {

        var user = await (
            from userApplication in _context.UsuarioAplicacion
            join accessApplication in _context.AccesoUsuarioAplicacion on userApplication.ua_id equals accessApplication.ua_id
            join contact in _context.Contacto on userApplication.co_id equals contact.co_id
            join installer in _context.Instalador on contact.co_id equals installer.co_id
            where userApplication.ua_usr == username && userApplication.ua_con == password && accessApplication.ap_id == applicationId && accessApplication.aua_fechafin == null && userApplication.ua_fechafin == null && installer.in_fechafin == null
            select new
            {
                userId = userApplication.ua_id,
                contact = userApplication.co_id,
                fullname = contact.co_nombre + " " + contact.co_apellido,
                // userApplication.ua_usr,
                // userApplication.ua_con,
                // userApplication.ua_fechafin,
                // installer.in_fechafin
            }
        ).FirstOrDefaultAsync();

        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

}
