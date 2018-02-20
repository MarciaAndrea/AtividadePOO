using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class Solicitacao
    {
        public Solicitacao()
        {
            Cliente = new List<Cliente>();
        }
        public int IdSolicitacao { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
