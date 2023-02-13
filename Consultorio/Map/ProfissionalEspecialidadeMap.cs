using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Map
{
    public class ProfissionalEspecialidadeMap : BaseMap<ProfissionalEspecialidade>
    {
        public ProfissionalEspecialidadeMap() : base("tb_profissional_especialidades") 
        { }
        public override void Configure(EntityTypeBuilder<ProfissionalEspecialidade> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.EspecialidadeId).HasColumnName("especialidade_id");
            builder.Property(x => x.ProfissionalId).HasColumnName("profissional_id");
        }
    }
}
