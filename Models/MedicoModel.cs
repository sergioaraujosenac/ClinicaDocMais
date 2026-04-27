using System.ComponentModel.DataAnnotations;

namespace ClinicaDocMais.Models
{
    public class MedicoModel
    {
        public string? nomedoMedico { get; set; }
        [Key] public string? numerodocrmMedico { get; set; }
        public string? telefoneMedico  { get; set; }
        public string? emailMedico { get; set; }
        public string? dataNascimentoMedico { get; set; }
        public string? especialidade {  get; set; }
        

    }
}
