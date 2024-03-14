using ApiNet6.Interfaces;
using Domain.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiNet6.Controllers
{
    [Route("api/[controller]")]
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
                var positions = _alquilerService.QueryNoTracking().OrderBy(x => x.Fecha_Reservacion);

                var response = new
                {
                    success = true,
                    data = positions
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult,
                    InnerError = ex.InnerException
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
