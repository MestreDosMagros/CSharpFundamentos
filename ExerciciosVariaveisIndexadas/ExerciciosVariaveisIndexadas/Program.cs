using System;
using System.Collections.Generic;

namespace ExerciciosVariaveisIndexadas
{
    class Program
    {
        static void Main(string[] args)
        {
            MartizDeNomes();
            VetorVsLista();
        }

        private static void VetorVsLista()
        {
            var vetor = new int[10];
            var lista = new List<int>();

            vetor[0] = 2;
            vetor[1] = 4;
            vetor[2] = 5;
            vetor[3] = 8;
            vetor[4] = 10;
            vetor[5] = 12;
            vetor[6] = 14;
            vetor[7] = 16;
            vetor[8] = 18;
            vetor[9] = 20;

            for (int i = 0; i <= vetor.Length - 1; i++)
                lista.Add(vetor[i] * 10);

            Console.WriteLine("Valores do vetor:");
            for (int i = 0; i <= vetor.Length - 1; i++)
                Console.WriteLine(vetor[i]);

            Console.WriteLine("Valores da lista:");
            for (int i = 0; i <= lista.Count - 1; i++)
                Console.WriteLine(lista[i]);
        }

        private static void MartizDeNomes()
        {
            var nomes = new string[5, 2];

            nomes[0, 0] = "Power Ranger";
            nomes[1, 0] = "Power Ranger";
            nomes[2, 0] = "Power Ranger";
            nomes[3, 0] = "Power Ranger";
            nomes[4, 0] = "Power Ranger";

            for (int i = 0; i <= nomes.GetLength(0) - 1; i++)
            {
                Console.WriteLine("Qual o sobrenome do: " + nomes[i, 0]);
                nomes[i, 1] = Console.ReadLine();
                Console.Clear();
            }

            for (int i = 0; i <= nomes.GetLength(0) - 1; i++)
                Console.WriteLine(nomes[i, 0] + " " + nomes[i, 1]);

            Console.ReadLine();
        }
    }
}
