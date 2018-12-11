using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGLC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.Infrastructure.EntityConfig
{
    public class MarcaConfig : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            #region Configurando a entidade Marca com Fluent API

            builder.Property(m => m.Descricao)
              .HasColumnType("varchar(200)");

            #endregion
        }
    }
}
