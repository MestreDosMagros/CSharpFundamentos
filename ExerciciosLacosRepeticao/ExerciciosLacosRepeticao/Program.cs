using System;

namespace ExerciciosLacosRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            //EscreverNumeroAteZero();
            //NumeroPar();
            //VerificaGanhador();

            Console.ReadKey();
        }

        private static void NumeroPar()
        {
            var digitouNumeroPar = false;

            while (!digitouNumeroPar)
            {
                Console.WriteLine("Digite um número");
                var numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado % 2 == 0)
                {
                    digitouNumeroPar = true;

                    var x = (int)numeroDigitado / 2;

                    for (int i = 0; i < x; i++)
                        Console.WriteLine("Repetição: " + (i + 1));
                }
            }
        }

        private static void EscreverNumeroAteZero()
        {
            Console.WriteLine("Escreva um número");
            var numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = numero; i >= 0; i--)
                Console.WriteLine(i);
        }

        private static void VerificaGanhador()
        {
            const string timeGanhador = "Alemanha";
            var acertou = false;

            Console.WriteLine("Qual time ganhou a copa de 2014?");
            Console.WriteLine("1 - Brasil");
            Console.WriteLine("2 - Alemanha");
            Console.WriteLine("3 - Argentina");
            Console.WriteLine("4 - Costa Rica");

            while (!acertou)
            {
                var escolhaDoUsuario = Console.ReadLine();

                if (escolhaDoUsuario.Equals(timeGanhador, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Acertou");
                    acertou = true;
                }
                else
                    Console.WriteLine("Errou");
            }
        }
    }
}
