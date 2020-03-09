using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime dataPedido { get; set; }
        public int usuarioID { get; set; }
        public DateTime dataPrevisaoEntrega { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string enderecoCompleto { get; set; }
        public int numeroEndereco { get; set; }

        public int FormaPagamentoId { get;set }
        public FormaPagamento FormaPagamento { get; set }
        /// <summary>
        /// Pedido deve ter pelo menos um item pedido
        /// ou muitos itens pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
