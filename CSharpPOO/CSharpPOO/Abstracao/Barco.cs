using System;

namespace CSharpPOO.Abstracao
{
    public class Barco : Veiculo
    {
        public Barco(string tipoModelo) : base(tipoModelo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o barco");
        }

        public override void Parar()
        {
            Console.WriteLine("Atracando o barco");
        }

        public override void Abastecer()
        {
            Console.WriteLine("Abastecendo diesel");
        }

        public override void Parar(string comoParar)
        {
        }
    }
}
