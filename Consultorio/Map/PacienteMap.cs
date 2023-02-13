﻿using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Map
{
    public class PacienteMap : BaseMap<Paciente>
    {
        public PacienteMap() : base("tb_pacientes")
        {}
        public override void Configure(EntityTypeBuilder<Paciente> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Cpf).HasColumnName("cpf").HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Celular).HasColumnName("celular").HasColumnType("varchar(20)").IsRequired();
        }
    }
}
