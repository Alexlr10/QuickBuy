using QuickBuy.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int id { get; set; }
        public int produtoID { get; set; }
        public int quantidade { get; set; }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }

        public override void validate()
        {
            if (produtoID == 0)
                AdcionarCritica("Não foi identificado qual a referencia");

            if (quantidade == 0)
                AdcionarCritica("Quantidade não foi informada");
        }
    }
}
