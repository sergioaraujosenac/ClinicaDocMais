using ClinicaDocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        [HttpGet("AtendidosHoje")]
        public List<string> PacientesAtendidoHoje()
        {
            List<string> pacienteAtendidoHoje = new List<string>();
            pacienteAtendidoHoje =["Sergio", "Carlos", "celio"];
            return pacienteAtendidoHoje;
           
        }
    }
}
