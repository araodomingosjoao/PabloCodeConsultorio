using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Map
{
    public class EspecialidadeMap : BaseMap<Especialidade>
    {
        public EspecialidadeMap() : base("tb_especialidades")
        {}
        public override void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Activa).HasColumnName("ativa");
            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
        }
    }
}
