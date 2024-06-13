using ApiNet6.HttpRequest;
using ApiNet6.Interfaces;
using ApiNet6.Utils;
using Domain.DB;
using Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiNet6.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("Policy")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        private readonly ApiNet6Context _context;

        public AuthController(IConfiguration configuration, ApiNet6Context context)
        {
            Configuration = configuration;
            _context = context;
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Login([FromBody] AuthRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.username) || string.IsNullOrEmpty(request.password))
                    return new BadRequestObjectResult(new { success = false, data = "El usuario y/o contraseña estan vacios" });

                var user = _context.Users.Where(x => x.Username == request.username).FirstOrDefault();
                if (user == null)
                    return new BadRequestObjectResult(new { success = false, data = "El usuario no se encuentra registrado" });

                if (!user.IsActive)
                    return new BadRequestObjectResult(new { success = false, data = "El usuario no se encuentra activo en el sistema" });

                var person = _context.Cliente.Where(x => x.ClienteId == user.ClienteId).FirstOrDefault();

                var pass = Globals.MD5(request.password);
                if (pass != user.PasswordHash)
                {
                    if (user.IsAdmin)
                        return new BadRequestObjectResult(new { success = false, data = "La contraseña es incorrecta" });

                    if (user.AccessFailCount <= 4)
                    {
                        user.AccessFailCount++;
                        user.UpdatedAt = Globals.FechaActual();
                        _context.Users.Update(user);
                        _context.SaveChanges();
                        return new BadRequestObjectResult(new { success = false, data = $"Lleva {user.AccessFailCount}/5 intentos" });
                    }
                    else
                    {
                        user.IsActive = false;
                        user.UpdatedAt = Globals.FechaActual();
                        _context.Users.Update(user);
                        _context.SaveChanges();
                        return new BadRequestObjectResult(new { success = false, data = "No tiene mas intentos y sera bloqueado, comuniquese con el administrador" });
                    }
                }

                //Tiempo de Tokenn
                var expiration_date = Globals.FechaActual().AddHours(5).AddHours(8);//8 horas de vida para el token
                var jwtHelper = new JWTHelper(this.Configuration.GetValue<string>("SecurityKey"));
                var token = jwtHelper.CreateToken(request.username, expiration_date);

                //Validamos la sesion
                var _sesion = _context.Sesions
                    .Include(x => x.User)
                        .ThenInclude(x => x.Cliente)
                    .Where(x => x.UserId == user.UserId)
                    .FirstOrDefault();

                if (_sesion == null)
                {
                    var sesion = new Sesion
                    {
                        UserId = user.UserId,
                        Token = token,
                        Expiration_Date = expiration_date,
                        CreatedAt = Globals.FechaActual(),
                        CreatedBy = Globals.UserSystem()
                    };
                    _context.Sesions.Add(sesion);

                    user.AccessFailCount = 0;
                    user.UpdatedAt = Globals.FechaActual();
                    _context.Users.Update(user);
                    _context.SaveChanges();

                    _sesion = _context.Sesions
                        .Include(x => x.User)
                            .ThenInclude(x => x.Cliente)
                        .Where(x => x.UserId == user.UserId)
                        .FirstOrDefault();
                }
                else
                {
                    _sesion.Token = token;
                    _sesion.Expiration_Date = expiration_date;
                    _sesion.UpdatedAt = Globals.FechaActual();
                    _context.Sesions.Update(_sesion);
                }

                user.AccessFailCount = 0;
                user.UpdatedAt = Globals.FechaActual();
                _context.Users.Update(user);

                //Log
                var addlog = new LogLogin()
                {
                    UserID = _sesion == null ? user.UserId : _sesion.UserId,
                    CreatedAt = Globals.FechaActual(),
                    CreatedBy = user.Username
                };
                await _context.LogLogin.AddAsync(addlog);

                _context.SaveChanges();

                var response = new
                {
                    success = true,
                    data = new
                    {
                        token,
                        sesion = new
                        {
                            departamento = _sesion.User.Cliente.Nombre,
                            isAdmin = _sesion.User.IsAdmin,
                        }
                    },
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    data = new
                    {
                        success = false,
                        error = ex.Message,
                        errorCode = ex.HResult,
                        InnerError = ex.InnerException
                    }
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
