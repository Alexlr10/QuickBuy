﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
   public  class ItemPedidoConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.id);

            builder
                .Property(i => i.produtoID)
                .IsRequired();

            builder
                .Property(i => i.quantidade)
                .IsRequired();

        }
    }
}
