using ClinicaDocMais.Models;

namespace ClinicaDocMais.DTOs
{
    public class AgendamentoDTO
    {

        public   string? crmMedico {  get; set; }
        public   string? cpfPaciente {  get; set; }
        public string?  id { get; set; }
        public DateTime dataHoraAgendada { get; set; }



    }
}
