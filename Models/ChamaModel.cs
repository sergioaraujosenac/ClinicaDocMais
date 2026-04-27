namespace ClinicaDocMais.Models
{
    public class ChamaModel
    {
        public string? id { get; set; }
        public string? nomePaciente { get; set; }
        public string? consultorio { get; set; }
        public static List<string>chamadaPaciente = new List<string>();
    }
}