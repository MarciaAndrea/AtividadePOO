using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    class ContaPoupanca
    {
        public int IdCP { get; set; }
        public int IdConta { get; set; }
        public decimal Sacar { get; set; }
        public decimal Depositar { get; set; }
        public DateTime Nive { get; set; }
        public decimal Juros { get; set; }

        [ForeignKey("ContaId")]
        public virtual Conta Conta { set; get; }

    }
}
