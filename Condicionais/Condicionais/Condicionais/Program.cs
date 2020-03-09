using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //VerificaIdade();
            //VerificaGanhador();
        }

        private static void VerificaGanhador()
        {
            const string timeGanhador = "Alemanha";

            Console.WriteLine("Qual time ganhou a copa de 2014?");
            Console.WriteLine("1 - Brasil");
            Console.WriteLine("2 - Alemanha");
            Console.WriteLine("3 - Argentina");
            Console.WriteLine("4 - Costa Rica");

            var escolhaDoUsuario = Console.ReadLine();

            //if/else
            if (escolhaDoUsuario.Equals(timeGanhador, StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("Acertou");
            else
                Console.WriteLine("Errou");

            //switch
            switch (escolhaDoUsuario)
            {
                case ("Alemanha"):
                    Console.WriteLine("Acertou");
                    break;
                case ("Brasil"):
                    Console.WriteLine("Errou");
                    break;
                case ("Argentina"):
                    Console.WriteLine("Errou");
                    break;
                case ("Costa Rica"):
                    Console.WriteLine("Errou");
                    break;
                default:
                    Console.WriteLine("Errou");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
        }

        private static void VerificaIdade()
        {
            Console.WriteLine("Insira sua idade");
            var idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 13 && idade < 19)
                Console.WriteLine("Adolescente");
            else if (idade >= 19 && idade <= 60)
                Console.WriteLine("Adulto");
            else if (idade > 60)
                Console.WriteLine("Idoso");
            else
                Console.WriteLine("Criança");

            Console.ReadKey();
        }
    }
}
