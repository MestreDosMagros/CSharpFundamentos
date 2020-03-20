using System;

namespace TratamentoDeErros
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um numero");
                var numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 10)
                    throw new ValorMuitoBaixoException("Ops, assim nao tem graça");
                if (numero > 10000)
                    throw new ValorMuitoAltoException("Ops, muita coisa, vai com calma");

                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch(ValorMuitoBaixoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ValorMuitoAltoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class ValorMuitoBaixoException : Exception
    {
        public ValorMuitoBaixoException() : base() { }
        public ValorMuitoBaixoException(string mensagem) : base(mensagem) { } 
    }

    public class ValorMuitoAltoException : Exception
    {
        public ValorMuitoAltoException() : base() { }
        public ValorMuitoAltoException(string mensagem) : base(mensagem) { }
    }
}
