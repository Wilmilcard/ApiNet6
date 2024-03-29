using ApiNet6.Interfaces;
using Domain.DB;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
