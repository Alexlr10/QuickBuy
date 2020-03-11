using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {

            builder.HasKey(p => p.id);

            //builder utiliza o padrao fluent

            builder
                .Property(p => p.dataPedido)
                .IsRequired();

            builder
               .Property(p => p.dataPrevisaoEntrega)
               .IsRequired();

            builder
                .Property(p => p.cep)
                .IsRequired()
                .HasMaxLength(10);
                

        }
    }
}
