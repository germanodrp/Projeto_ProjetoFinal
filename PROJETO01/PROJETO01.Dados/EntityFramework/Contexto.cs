using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PROJETO01.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data source = 201.62.57.93; 
                                     Database = BD040160; 
                                     User ID = RA040160; 
                                     Password = 040160";
            optionsBuilder.UseSqlServer(conn);
        }

        //Nome das Classes que representarão o Banco de Dados
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<evento> evento { get; set; }

        public DbSet<TipoEvento> TipoEvento { get; set; }

        public DbSet<Bar> Bar { get; set; }

        public DbSet<Cidade> Cidade { get; set; }


        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>()
                .ToTable("Estado")
                .HasKey("UF");

            modelBuilder.Entity<Estado>()
                .Property("UF")
                .HasColumnName("Uf")
                .HasColumnType("char(2)")
                .IsRequired();

            modelBuilder.Entity<Estado>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();
    ///////////////////////////////// CLIENTE /////////////////////////////////////////////////////
    
        modelBuilder.Entity<Cliente>()
               .ToTable("Cliente")
               .HasKey("ClienteID");


            modelBuilder.Entity<Cliente>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
               .Property("Telefone")
               .HasColumnName("telefone")
               .HasColumnType("varchar(20)")
               .IsRequired();

            modelBuilder.Entity<Cliente>()
               .Property("Email")
               .HasColumnName("Email")
               .HasColumnType("varchar(200)")
               .IsRequired();

            modelBuilder.Entity<Cliente>()
             .Property("Cpf")
             .HasColumnName("Cpf")
             .HasColumnType("char(11)")
             .IsRequired();

        modelBuilder.Entity<Cliente>()
             .Property("DataNascimento")
             .HasColumnName("DataNascimento")
             .HasColumnType("datetime")
             .IsRequired();


        ///////////////////////////////////// CIDADE ////////////////////////////////////////////////////

        modelBuilder.Entity<Cidade>()
                .ToTable("Cidade")
                .HasKey("CidadeId");

            modelBuilder.Entity<Cidade>()
                .Property("uf")
                .HasColumnName("uf")
                .HasColumnType("char(2)")
                .IsRequired();

            modelBuilder.Entity<Cidade>()
               .Property("CidadeId")
               .HasColumnName("CidadeId")
               .HasColumnType("int")
               .IsRequired();

            modelBuilder.Entity<Cidade>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

           
            /////////////////////////////////// BAR ///////////////////////////////////////////////

            modelBuilder.Entity<Bar>()
             .ToTable("Bar")
             .HasKey("BarID");

            modelBuilder.Entity<Bar>()
                .Property("nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Bar>()
               .Property("cnpj")
               .HasColumnName("cnpj")
               .HasColumnType("int")
               .IsRequired();

            modelBuilder.Entity<Bar>()
               .Property("restricao")
               .HasColumnName("Restricao")
               .HasColumnType("varchar(100)")
               .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("horario")
             .HasColumnName("horario")
             .HasColumnType("DateTime")
             .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("capacidade")
             .HasColumnName("Capacidade")
             .HasColumnType("int")
             .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("localizacao")
             .HasColumnName("Localizacao")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("numero")
             .HasColumnName("Numero")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("CEP")
             .HasColumnName("Cep")
             .HasColumnType("char(8)")
             .IsRequired();

            modelBuilder.Entity<Bar>()
                       .ToTable("Bar")
                       .HasKey("BarID");

            modelBuilder.Entity<Bar>()
                         .Property("BarID")
                         .HasColumnName("BarID")
                         .HasColumnType("int")
                         .IsRequired();

            ///////////////////////////////// EVENTO ////////////////////////////

            modelBuilder.Entity<evento>()
             .ToTable("Evento")
             .HasKey("EventoID");

            modelBuilder.Entity<evento>()
                       .Property("nome")
                       .HasColumnName("Nome")
                       .HasColumnType("varchar(200)")
                       .IsRequired();

            modelBuilder.Entity<evento>()
                        .Property("taxa")
                        .HasColumnName("Taxa")
                        .HasColumnType("Decimal")
                        .IsRequired();

            modelBuilder.Entity<evento>()
                        .Property("horario")
                        .HasColumnName("Horario")
                        .HasColumnType("DateTime")
                        .IsRequired();

          //////////////////////////////////// TIPO EVENTO ///////////////////////////////////////////////

            
      
            modelBuilder.Entity<TipoEvento>()
                         .ToTable("TipoEvento")
                         .HasKey("TipoEventoID");

            modelBuilder.Entity<TipoEvento>()
                         .Property("modelo")
                         .HasColumnName("modelo")
                         .HasColumnType("varchar(100)")
                         .IsRequired();
         
            base.OnModelCreating(modelBuilder);
        }
    }
}
