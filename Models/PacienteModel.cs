using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace ClinicaDocMais.Models
{
    public class PacienteModel
    {

        [Key] public string? cpf { get; set; }
        public string? nome { get; set; }

        public string? telefone { get; set; }

        public DateOnly? dataNascimento { get; set; }
       
        
        public string? email { get; set; }

        public PacienteModel (string? cpf, string? nome, string?telefone ,string?email)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            

        }

    }
}
