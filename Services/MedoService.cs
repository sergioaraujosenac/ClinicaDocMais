using ClinicaDocMais.Models;
using System.ComponentModel;

namespace ClinicaDocMais.Services
{
    public class MedicoService

    {
        public static List<MedicoModel> ListaMedicos = new List<MedicoModel>();
        public MedicoModel editarMedico(MedicoModel medicoeditado, string crm)
        {
            foreach (var medico in ListaMedicos)
            {
                if (medico.numerodocrmMedico == crm)
                {
                    medico.dataNascimentoMedico = medicoeditado.dataNascimentoMedico;
                    medico.nomedoMedico = medicoeditado.nomedoMedico;
                    medico.telefoneMedico = medicoeditado.telefoneMedico;
                    medico.dataNascimentoMedico = medicoeditado.dataNascimentoMedico;
                    medico.especialidade = medicoeditado.especialidade;
                    return medico;

                }
            }
            return null;
        }

    }
}
