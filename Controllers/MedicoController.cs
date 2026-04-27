using ClinicaDocMais.Data;
using ClinicaDocMais.Models;
using ClinicaDocMais.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ClinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private ClinicaContext _context;
        public MedicoController(ClinicaContext context)
        {
            _context = context;
        }

        [HttpPost("CadastrarMedico")]
        public async Task<IActionResult> cadastrarMedico([FromBody]MedicoModel medicoCadastrado) 
        {
            try
            {
                _context.Add(medicoCadastrado);
                return BadRequest("Erro Inesperado.Ero" );
            }
           

            catch (Exception ex)
            {
                return BadRequest("Erro inesperado" +ex.Message);
            }
        }
        [HttpGet("buscaMedico/{crm}")]
        public async Task<IActionResult> buscaMedico(string crm)
        {
            return Ok();

        }

        [HttpPut("editarMedico/{crm}")]

        public string editarmedico([FromBody] MedicoModel medicoEditado, string crm)
        {
            MedicoService medico = new MedicoService();
            medico.editarMedico(medicoEditado, crm);

            if (medico == null)

            {
                return "Medico nao encontrado";
            }

            else
            {
                return  $"medico de crm N {crm} editado com sucesso";
            }
        }
    }
}
        

