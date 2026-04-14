using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaCepController : ControllerBase
    {
        [HttpGet("{cep}")]
        public async Task<IActionResult> BuscarEndereco(string cep)
        {

            if (cep.Length != 8)
            {
                return NotFound("CEP nao encontrado.");
            }
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync($"http://ViaCep.com.br/ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<EnderecoModel>();
                    if (content.cep == null)
                    {
                        return NotFound("Cep nao encontrado.");
                    }

                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro de rede: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

            return BadRequest();
        }

    }

    internal class EnderecoModel
    {
    }
}
