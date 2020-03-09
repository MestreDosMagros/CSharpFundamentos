using System;

namespace FuncoesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome completo");
            var nome = Console.ReadLine();

            Console.WriteLine("Insira sua idade");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira seu telefone com DDD (somente numeros)");
            var telefone = Console.ReadLine();

            Console.WriteLine("Telefone formatado: " + FormataTelefone(telefone));
            Console.WriteLine("Raiz quadrada do nome: " + CalculaRaizQuadrada(idade));
            Console.WriteLine("Sem espaços: " + TrocaEspacos(nome));
            
            Console.ReadLine();
        }

        private static string TrocaEspacos(string nome)
        {
            return nome.Replace(" ", ";");
        }

        private static double CalculaRaizQuadrada(int idade)
        {
            return Math.Round(Math.Sqrt(idade), 2);
        }

        private static string FormataTelefone(string telefone)
        {
            var ddd = telefone.Substring(0, 2);
            var primeiraParte = telefone.Substring(2, 5);
            var segundaParte = telefone.Substring(7);

            return string.Format("({0}) {1}-{2}", ddd, primeiraParte, segundaParte);
        }
    }
}
