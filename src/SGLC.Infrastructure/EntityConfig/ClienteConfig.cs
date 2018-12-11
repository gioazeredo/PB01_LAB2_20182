using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGLC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.Infrastructure.EntityConfig
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            #region Configurando a entidade Cliente com Fluent API

            builder.Property(c => c.Nome)
              .HasColumnType("varchar(200)");

            builder.Property(c => c.Email)
              .HasColumnType("varchar(100)");

            #endregion
        }
    }
}
