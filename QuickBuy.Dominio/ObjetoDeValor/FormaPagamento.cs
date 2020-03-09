using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Enumerados;
namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public bool ehBoleto {
            get { return id == (int)TipoFormaPagamentoEnum.boleto; }
        }
        public bool ehCartao {
            get { return id == (int)TipoFormaPagamentoEnum.cartaoCredito; }
        }

        public bool ehDeposito {
            get { return id == (int)TipoFormaPagamentoEnum.deposito; }
        }

        public bool naoFoiDefinido {
            get { return id == (int)TipoFormaPagamentoEnum.naoDefinido; }
        }


    }
}
    
