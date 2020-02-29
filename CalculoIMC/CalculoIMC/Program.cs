using System;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // pegar peso do usuário
            Console.WriteLine("Insira seu peso");
            var peso = BuscaValor();
            if (peso == null) Console.WriteLine("Valor inválido!");

            // pegar altura do usuário
            Console.WriteLine("Insira sua altura");
            var altura = BuscaValor();
            if (altura == null)
            {
                Console.WriteLine("Valor inválido!");
            }
            var imc = (double)peso.Value / Math.Pow((double)altura.Value, 2);

            Console.WriteLine("Seu IMC atual é: " + Math.Round(imc, 2));

            Console.ReadLine();
        }

        private static decimal? BuscaValor()
        {
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
                return null;

            return valor;
        }
    }
}
