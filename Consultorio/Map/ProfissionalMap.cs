using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Map
{
    public class ProfissionalMap : BaseMap<Profissional>
    {
        public ProfissionalMap() : base("tb_profissionais") 
        { }
        public override void Configure(EntityTypeBuilder<Profissional> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo");

            builder.HasMany(x => x.Especialidades)
                    .WithMany(x => x.Profissionais)
                    .UsingEntity<ProfissionalEspecialidade>(
                        x => x.HasOne(p => p.Especialidades).WithMany().HasForeignKey(p => p.EspecialidadeId)
                    );
        }
    }
}
