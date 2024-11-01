using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace web_api_test;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly AppSettings _appSettings;
    public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
    {
        _next = next;
        _appSettings = appSettings.Value;
    }

    public async Task Invoke(HttpContext context, IUserService userService)
    {
        // = context.Request.Headers["Authorization"].SingleOrDefault()?.Split(" ").Last(): Es un operador ternario que se encarga de obtener el token de la cabecera de la petición.
        var token = context.Request.Headers["Authorization"].SingleOrDefault()?.Split(" ").Last();

        if (token != null)
            // await attachUserToContext(context, userService, token): Se encarga de adjuntar el usuario al contexto de la petición.
            await attachUserToContext(context, userService, token);

        // await _next(context): Se encarga de continuar con la petición.
        await _next(context);
    }

    private async Task attachUserToContext(HttpContext context, IUserService userService, string token)
    {
        try
        {
            // JwtSecurityTokenHandler: Clase que se encarga de manejar los tokens JWT.
            var tokenHandler = new JwtSecurityTokenHandler();
            // Encoding.ASCII.GetBytes(_appSettings.Secret): Se encarga de obtener el secreto de la aplicación.
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            // tokenHandler.ValidateToken(token, new TokenValidationParameters: Se encarga de validar el token.
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true, // Valida la clave del emisor.
                IssuerSigningKey = new SymmetricSecurityKey(key), // Clave simétrica.
                ValidateIssuer = false, // Valida el emisor.
                ValidateAudience = false, // Valida la audiencia.
                ClockSkew = TimeSpan.Zero // Sin retraso.
            }, out SecurityToken validatedToken // Se encarga de validar el token.
            );

            var jwtToken = (JwtSecurityToken)validatedToken; // Se obtiene el token JWT.
            var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value); // Se obtiene el id del usuario.


            context.Items["User"] = await userService.GetById(userId);
        }
        catch
        {
            // do nothing if jwt validation fails
            // user is not attached to context so request won't have access to secure routes
        }
    }

}
