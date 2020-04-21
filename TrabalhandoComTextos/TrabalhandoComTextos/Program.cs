using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace TrabalhandoComTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            //LeituraDeArquivoTXT();
            //EscritaDeArquivoTXT();

            LerArquivoAlunosInteressadosEhReordenar();

            Console.WriteLine("-------- Input --------");
            LeituraDeArquivoTXT(@"C:\temp\Alunos Interessados Input.txt");

            Console.WriteLine("-------- Output --------");
            LeituraDeArquivoTXT(@"C:\temp\Alunos Interessados Output.txt");

            Console.ReadKey();
        }

        private static void LeituraDeArquivoTXT()
        {
            using var sr = new StreamReader(@"C:\temp\teste.txt");

            while (!sr.EndOfStream)
            {
                string linha = sr.ReadLine();
                Console.WriteLine(linha);
            }
        }

        private static void EscritaDeArquivoTXT()
        {
            using var sw = new StreamWriter(@"C:\temp\EscrevendoArquivo.txt");
           
            sw.AutoFlush = true;
            
            var conteudo = "Programando em C#";

            sw.Write(conteudo);
        }

        private static void LerArquivoAlunosInteressadosEhReordenar()
        {
            var linhas = new List<string>();
            using var sr = new StreamReader(@"C:\temp\Alunos Interessados Input.txt");

            while (!sr.EndOfStream)
                linhas.Add(sr.ReadLine());

            var linhasOrdenadas = linhas.OrderBy(linha => linha).ToList();

            using var sw = new StreamWriter(@"C:\temp\Alunos Interessados Output.txt");

            sw.AutoFlush = true;

            foreach (var linha in linhasOrdenadas)
                sw.WriteLine(linha);
        }

        private static void LeituraDeArquivoTXT(string path)
        {
            using var sr = new StreamReader(path);

            while (!sr.EndOfStream)
                Console.WriteLine(sr.ReadLine());
        }
    }
}
