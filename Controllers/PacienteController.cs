using ClinicaDocMais.Data;
using ClinicaDocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ClinicaDocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : Controller
    {
        public static List<PacienteModel> listaPaciente = new List<PacienteModel>();

        private readonly ClinicaContext _context;

        public PacienteController(ClinicaContext context)
        {
            _context = context;
        }

        [HttpPost("cadastrarpaciente")]
        public async Task<IActionResult> cadastrarPaciente([FromBody] PacienteModel pacienteCadastrado)
        {
            try
            {
                _context.Add(pacienteCadastrado);
                await _context.SaveChangesAsync();
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro Inesperado. Erro: " + ex.Message);
            }
        }




        [HttpGet("listarPaciente")]
        public async Task<IActionResult> listarPacientes()
        {
            try
            {
               var listaPacientes = await _context.Pacientes.ToListAsync();
                return Ok(listaPacientes);

            }catch (Exception ex)
            {
                return BadRequest("Erro."+ex.Message);
            }


        }
        [HttpGet("buscarPaciente/{nome}")]
        public async Task<IActionResult> BuscarPaciente(string nome)
        {
            try
            {
                var listabuscaPaciente = await _context.Pacientes.Where(p => p.nome.Contains(nome)).ToListAsync();
                return Ok(listabuscaPaciente);

            }catch(Exception ex)
            {
                return BadRequest("Erro." +ex.Message);
            }

        }


            
        [HttpPut("editarPaciente/{cpf}")]

        public async Task<IActionResult> editarPaciente([FromBody] PacienteModel pacienteEditado, string cpf)
        {
            try
            {
                _context.Pacientes.Update(pacienteEditado);
                await _context.SaveChangesAsync();
                return Ok(pacienteEditado);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        
        }

        [HttpDelete("deletarPaciente/{cpf}")]
        public async Task<IActionResult> deletarPaciente(string cpf)

        {
            try

            {
                PacienteModel? pacienteEncontrado = await _context.Pacientes.FindAsync(cpf, cpf);


                if (pacienteEncontrado != null)
                {
                    _context.Pacientes.Remove(pacienteEncontrado);
                    await _context.SaveChangesAsync();
                    return NoContent();

                }

                else
                {
                    throw new Exception($"Paciente de cpf:{cpf} nao existe");
                }

            }

            catch (Exception ex)
            {
                return BadRequest(" Erro" + ex.Message);

            }






        }

    }


}    