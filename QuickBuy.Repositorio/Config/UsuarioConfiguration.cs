using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
   public  class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.id);

            //builder utiliza o padrao fluent
            builder
                .Property(u => u.email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.nome)
                .IsRequired()
                .HasMaxLength(50);


            builder
                .Property(u => u.sobrenome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.usuario);
        }
    }
}
