using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    class Conta
    {
        public int IdConta { get; set; }
        public int IdCP { get; set; }
        public int IdCC { get; set; }
        public int IdAgencia { get; set; }
        public int IdCliente { get; set; }
        public decimal Saldo { get; set; }
        public string Titular { get; set; }
        [ForeignKey("AgenciaId")]
        public virtual Agencia Agencia { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }



    }
}
