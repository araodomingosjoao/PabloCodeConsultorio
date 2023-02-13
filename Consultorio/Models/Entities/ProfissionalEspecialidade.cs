using System.Collections.Generic;

namespace Consultorio.Models.Entities
{
    public class ProfissionalEspecialidade : Base
    {
        public int ProfissionalId { get; set; }
        public List<Profissional> Profissionais { get; set; }
        public int EspecialidadeId { get; set; }
        public List<Especialidade> Especialidades { get; set; }

    }
}
