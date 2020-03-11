using QuickBuy.Repositorio.Entidades;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void validate()
        {
            if (string.IsNullOrEmpty(email))
                AdcionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(senha)) 
            AdcionarCritica("Senha não foi informado");
        }
    }
}
