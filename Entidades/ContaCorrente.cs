using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    class ContaCorrente
    {
        public int IdCC { get; set; }
        public int IdConta { get; set; }
        public decimal TaxaJuro { get; set; }
        public decimal Sacar { get; set; }
        public decimal Depositar { get; set; }
        [ForeignKey("ContaId")]
        public virtual Conta Conta { get; set; }

    }
}
