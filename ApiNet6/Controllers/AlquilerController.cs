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
            try
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


                var response = new
                {
                    timer = sw.ElapsedMilliseconds / 1000.0,
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
    }
}
