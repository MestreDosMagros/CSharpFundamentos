using System;

namespace CSharpPOO.Polimorfismo
{
    public class Veiculo
    {
        public Veiculo(string tipoModelo)
        {
            TipoModelo = tipoModelo;
        }

        public string TipoModelo { get; private set; }

        public virtual void Mover()
        {
            Console.WriteLine("Chamando método base");
        }

        public virtual void Parar()
        {
            Console.WriteLine("Chamando método base");
        }

        public virtual void Parar(string comoParar)
        {
            Console.WriteLine("Chamando método base");
        }

        public virtual void Abastecer()
        {
            Console.WriteLine("Eu não sei o que abastecer");
        }
    }
}
