using System;
using Atividade1POO;

namespace AppAtividade1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DateTime(10, 02, 2018);
            Conta cc = new ContaCorrente("Juca");
            Conta cp = new ContaPoupanca("Ana", 0.1M, data);
            cp.Depositar(1500);
            cp.Sacar(800);
            cc.Depositar(1000);
            cc.Sacar(950);

            Console.WriteLine();
            Console.ReadKey();  
         
        }
    }
}
