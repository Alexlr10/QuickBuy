using QuickBuy.Repositorio.Entidades;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }

        public override void validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
