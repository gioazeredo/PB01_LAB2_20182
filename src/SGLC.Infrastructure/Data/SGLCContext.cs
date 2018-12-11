using Microsoft.EntityFrameworkCore;
using SGLC.ApplicationCore.Entity;
using SGLC.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.Infrastructure.Data
{
    public class SGLCContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<LocacaoVeiculo> LocacaoVeiculos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdSGLC;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.ApplyConfiguration(new ClienteConfig());

            modelBuilder.ApplyConfiguration(new MarcaConfig());

            modelBuilder.ApplyConfiguration(new VeiculoConfig());

            modelBuilder.ApplyConfiguration(new EnderecoConfig());



            #region propagação de dados das entidades

            modelBuilder.Entity<Cliente>()
                  .HasData(

                  new Cliente { ClienteId = 1, Nome = "Geovani", Email = "Geovane@teste.com",   }
                 

                  );

            modelBuilder.Entity<Locacao>()
                .HasData(
                
                new Locacao { ClienteId = 1, LocacaoId = 1, Numero = 1 }
                
                );

            modelBuilder.Entity<LocacaoVeiculo>()
                .HasData(

                new LocacaoVeiculo { VeiculoId = 1, LocacaoId = 1, Id = 1 }

                );



            modelBuilder.Entity<Veiculo>()
                  .HasData(

                  new Veiculo { VeiculoId = 1, Placa = "ABC-1234", Descricao = "asdasd21", MarcaId = 1}
                  


      );


            modelBuilder.Entity<Marca>()
                .HasData(

                new Marca { MarcaId = 1, Descricao = "VW"}
             

                );

            modelBuilder.Entity<Endereco>()
                .HasData(

                new Endereco
                {
                    EnderecoId = 1, Logradouro = "Rua 12312, Quandra 1323123", Bairro = "CPA V", CEP = "78058-55",
                    Numero = "22",
                    ClienteId = 1
                }

                );


            #endregion
        }
    }
}
