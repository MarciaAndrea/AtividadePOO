using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class Cliente
    {
        public Cliente()
        {
            Solicitacao = new List<Solicitacao>();
            Conta = new List<Conta>();

        }
        public int IdCliente { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Conta> Conta { get; set; }
        public virtual ICollection<Solicitacao> Solicitacao { get; set; }
    }
}
