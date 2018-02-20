using System;
using Atividade2EFCore;
using System.Linq;
using Entidades;

namespace Atividade2EFCore
{
    class Program
    {
        public static object newCliente { get; private set; }

        static void Main(string[] args)
        {

            using (var context = new Context())
            {
                
                context.Set<Banco>().RemoveRange(context.Bancos);
                

                while (true)
                {
                    Console.WriteLine("1 - Cadastrar cliente;");
                    var leitura = Convert.ToInt32(Console.ReadLine());

                    if (leitura == 1)
                    {
                        Console.WriteLine("Digite o nome do cliente:");
                        var CliNome = Console.ReadLine();
                        var Cli = new Cliente { Nome = CliNome };
                        context.Add(newCliente);
                        context.SaveChanges();
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                    
                }
            }

            Console.ReadKey();
        }

       
    }
}
