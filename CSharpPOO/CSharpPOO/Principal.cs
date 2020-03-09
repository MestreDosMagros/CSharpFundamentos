using CSharpPOO.Interfaces;
using System;

namespace CSharpPOO
{
    class Principal
    {
        static void Main(string[] args)
        {
            //var pessoa = new Pessoa("nome",
            //    "endereco",
            //    "000000000",
            //    "000000000",
            //    "000000",
            //    21);

            //var aluno = new Aluno("nome",
            //    "endereco",
            //    "000000000",
            //    "000000000",
            //    "000000",
            //    21,
            //    123456,
            //    "programação",
            //    "apex");

            //Cria array de veiculos, pondendo ser Automovel, Barco ou qualquer que herde de Veiculo
            //Veiculo[] veiculo = new Veiculo[2];

            var x = new Automovel("BMW");
            //veiculo[1] = new Barco("Phantom");

            //AbastecerVeiculo(veiculo[0]);
            //AbastecerVeiculo(veiculo[1]);

            MovimentarVeiculo(x);
            //MovimentarVeiculo(veiculo[1]);

            Console.WriteLine("Digite Enter para os veículos pararem. ");
            Console.ReadLine();

            PararVeiculo(x);
            //PararVeiculo(veiculo[1]);

            Console.Read();
        }

        public static void MovimentarVeiculo(Automovel veiculo)
        {
            veiculo.Mover();
        }
        public static void PararVeiculo(Automovel veiculo)
        {
            veiculo.Parar();
        }

        //public static void AbastecerVeiculo(Veiculo veiculo)
        //{
        //    veiculo.Abastecer();
        //}

    }
}
