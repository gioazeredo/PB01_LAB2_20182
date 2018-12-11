using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGLC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.Infrastructure.EntityConfig
{
    public class VeiculoConfig : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            #region Configurando a entidade Veiculo com Fluent API

            builder.Property(v => v.Descricao)
              .HasColumnType("varchar(200)");

            builder.Property(v => v.Placa)
              .HasColumnType("varchar(20)");

            #endregion
        }
    }
}
