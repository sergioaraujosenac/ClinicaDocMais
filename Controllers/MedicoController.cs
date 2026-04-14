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
        public static List<MedicoModel> listaMedicos = new List<MedicoModel>();

        [HttpPost("CadastroMedico")]
        public string cadastrarMedico([FromBody] MedicoModel medico)
        {
            listaMedicos.Add(medico);
            return $"Dr.{medico.nomedoMedico} cadastrado com sucesso";

        }
        [HttpGet("listaMedico")]
        public List<MedicoModel> listarMedico()
        {
            return listaMedicos;

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
        

