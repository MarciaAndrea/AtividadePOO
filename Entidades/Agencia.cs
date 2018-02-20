using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class Agencia
    {
        public Agencia()
        {
            Solicitacao = new List<Solicitacao>();
            Conta = new List<Conta>();
        }
        public int IdSolicitacao { get; set; }
        public string cidade { get; set; }
        public virtual ICollection<Conta> Conta { get; set; }
        public virtual ICollection<Solicitacao> Solicitacao { get; set; }

    }
}
