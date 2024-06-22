using ApiNet6.HttpRequest;
using ApiNet6.Interfaces;
using Domain.DB;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ApiNet6.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("Policy")]
    [Authorize]
    [ApiController]
    public class AlquilerController : ControllerBase
    {
        private readonly IAlquilerServices _alquilerService;
        private readonly IConfiguration Configuration;
        private readonly ApiNet6Context _context;

        public AlquilerController(IAlquilerServices alquilerService, IConfiguration configuration, ApiNet6Context context)
        {
            _alquilerService = alquilerService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAll()
        {
            var sw = new Stopwatch();
            sw.Start();
            var query = _alquilerService
                .QueryNoTracking()
                .Include(x => x.Cliente)
                .Include(x => x.Estado)
                .Include(x => x.AlquilerDets)
                    .ThenInclude(j => j.Juego)
                        .ThenInclude(j => j.Director)
                .Include(x => x.AlquilerDets)
                    .ThenInclude(j => j.Juego)
                        .ThenInclude(p => p.PlataformaJuegos)
                            .ThenInclude(pj => pj.Plataforma)
                .Select(x => new
                {
                    x.AlquilerId,
                    x.Cliente.Nombre,
                    x.Cliente.Apellido,
                    x.Cliente.Telefono,
                    x.Cliente.Nit,
                    x.Cliente.Email,
                    x.Cliente.Nacimiento,
                    x.Estado.EstadoId,
                    EstadoActual = x.Estado.Nombre,
                    x.Fecha_Devolucion,
                    x.Fecha_Reservacion,
                    x.Valor_Total,
                    AlquilerDets = x.AlquilerDets.Select(a => new
                    {
                        a.AlquilerId,
                        a.Juego.Nombre,
                        a.Juego.Precio,
                        NombreDirector = a.Juego.Director.Nombre,
                        Plataformas = a.Juego.PlataformaJuegos.Select(pl => pl.Plataforma.Nombre)
                    })
                })
                .ToList();

            sw.Stop();

            //throw new Exception();

            var response = new
            {
                timer = sw.ElapsedMilliseconds / 1000.0,
                success = true,
                data = query,
            };
            return new OkObjectResult(response);
        }

        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetByGameId([FromRoute]int id)
        {
            try
            {
                //var list = _context.AlquilerDets.Where(x => x.JuegoId == id).Select(x => x.AlquilerDetId).ToList();

                var query = _alquilerService
                    .QueryNoTracking()
                    .Include(x => x.Cliente)
                    .Include(x => x.Estado)
                    .Include(x => x.AlquilerDets)
                        .ThenInclude(j => j.Juego)
                            .ThenInclude(j => j.Director)
                    .Include(x => x.AlquilerDets)
                        .ThenInclude(j => j.Juego)
                            .ThenInclude(p => p.PlataformaJuegos)
                                .ThenInclude(pj => pj.Plataforma)
                    .Select(x => new
                    {
                        x.AlquilerId,
                        x.Cliente.Nombre,
                        x.Cliente.Apellido,
                        x.Cliente.Telefono,
                        x.Cliente.Nit,
                        x.Cliente.Email,
                        x.Cliente.Nacimiento,
                        x.Estado.EstadoId,
                        EstadoActual = x.Estado.Nombre,
                        x.Fecha_Devolucion,
                        x.Fecha_Reservacion,
                        x.Valor_Total,
                        AlquilerDets = x.AlquilerDets.Where(ad => ad.JuegoId == id).Select(a => new
                        {
                            a.AlquilerId,
                            a.JuegoId,
                            a.Juego.Nombre,
                            a.Juego.Precio,
                            NombreDirector = a.Juego.Director.Nombre,
                            Plataformas = a.Juego.PlataformaJuegos.Select(pl => pl.Plataforma.Nombre)
                        })
                    })
                    .Where(x => x.AlquilerDets.Select(ad => ad.JuegoId).Contains(id))
                    .ToList();

                var response = new
                {
                    success = true,
                    data = query,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] AlquilerCreateUpdate request)
        {
            try
            {
                using (var transaccion = _context.Database.BeginTransaction())
                {
                    if (request == null)
                        return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                    Alquiler a = new Alquiler
                    {
                        ClienteId = request.ClienteId,
                        EstadoId = request.EstadoId,
                        Fecha_Devolucion = request.Fecha_Devolucion,
                        Fecha_Reservacion = request.Fecha_Reservacion,
                        Valor_Total = request.Valor_Total,
                        CreatedAt = Utils.Globals.FechaActual(),
                        CreatedBy = request.CreatedBy
                    };

                    foreach (var aj in request.Juegos)
                        await _context.AlquilerDets.AddAsync(aj);

                    await _alquilerService.AddAsync(a);
                    _context.SaveChanges();
                    transaccion.Commit();
                }

                var response = new
                {
                    success = true,
                    data = request
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] AlquilerCreateUpdate request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var a = _alquilerService.GetByIdAsync(id).Result;
                    if (a != null)
                    {
                        a.AlquilerId = request.AlquilerId;
                        a.ClienteId = request.ClienteId;
                        a.EstadoId = request.EstadoId;
                        a.Fecha_Devolucion = request.Fecha_Devolucion;
                        a.Fecha_Reservacion = request.Fecha_Reservacion;
                        a.Valor_Total = request.Valor_Total;
                        a.CreatedAt = request.CreatedAt;
                        a.CreatedBy = request.CreatedBy;
                        a.UpdatedAt = Utils.Globals.FechaActual();

                        var list = _context.AlquilerDets.Where(x => x.AlquilerId == a.AlquilerId);
                        foreach (var del in list)
                            _context.AlquilerDets.Remove(del);

                        foreach (var aj in request.Juegos)
                            await _context.AlquilerDets.AddAsync(aj);

                        await _alquilerService.UpdateAsync(a);
                        _context.SaveChanges();
                        transaccion.Commit();
                    }
                }

                var response = new
                {
                    success = true
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var a = _alquilerService.QueryNoTracking().Where(x => x.AlquilerId == id).FirstOrDefault();
            if (a != null)
            {
                try
                {
                    using (var transaccion = _context.Database.BeginTransaction())
                    {
                        var rpta = _alquilerService.DeleteAsync(a).Result;

                        var list = _context.AlquilerDets.Where(x => x.AlquilerId == a.AlquilerId);
                        foreach (var del in list)
                            _context.AlquilerDets.Remove(del);

                        transaccion.Commit();
                    }

                    var response = new
                    {
                        success = true
                    };
                    return new OkObjectResult(response);
                }
                catch (Exception ex)
                {
                    var response = new
                    {
                        success = false,
                        error = ex.Message,
                        errorCode = ex.HResult
                    };
                    return new BadRequestObjectResult(response);
                }
            }
            else
            {
                var response = new
                {
                    success = false,
                    error = "No se encontro Alquiler.",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
