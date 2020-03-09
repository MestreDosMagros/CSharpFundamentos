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

            if (peso == null)
                Console.WriteLine("Valor inválido!");

            // pegar altura do usuário
            Console.WriteLine("Insira sua altura");
            var altura = BuscaValor();

            if (altura == null)
                Console.WriteLine("Valor inválido!");

            var imc = (double)peso.Value / Math.Pow((double)altura.Value, 2);

            var classificacao = string.Empty;

            //usando o if
            classificacao = If(imc, classificacao);
            
            //usando o switch
            classificacao = Switch(imc, classificacao);

            Console.WriteLine("Seu IMC atual é: " + Math.Round(imc, 2) + ", sua classificação é: " + classificacao);

            Console.ReadLine();
        }

        private static string Switch(double imc, string classificacao)
        {
            switch (imc)
            {
                case double n when (n < 18.5):
                    classificacao = "Abaixo do peso normal";
                    break;
                case double n when (n >= 18.5 && n < 25):
                    classificacao = "Peso normal";
                    break;
                case double n when (n >= 25 && n < 30):
                    classificacao = "Excesso de peso";
                    break;
                case double n when (n >= 30 && n < 35):
                    classificacao = "Obesidade classe I";
                    break;
                case double n when (n >= 35 && n < 40):
                    classificacao = "Obesidade classe II";
                    break;
                case double n when (n > 40):
                    classificacao = "Obesidade classe III";
                    break;
                default:
                    break;
            }

            return classificacao;
        }

        private static string If(double imc, string classificacao)
        {
            if (imc < 18.5)
                classificacao = "Abaixo do peso normal";
            else if (imc >= 18.5 && imc < 25)
                classificacao = "Peso normal";
            else if (imc >= 25 && imc < 30)
                classificacao = "Excesso de peso";
            else if (imc >= 30 && imc < 35)
                classificacao = "Obesidade classe I";
            else if (imc >= 35 && imc < 40)
                classificacao = "Obesidade classe II";
            else if (imc > 40)
                classificacao = "Obesidade classe III";
            return classificacao;
        }

        private static decimal? BuscaValor()
        {
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
                return null;

            return valor;
        }
    }
}
