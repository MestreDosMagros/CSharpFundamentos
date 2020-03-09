using System;

namespace CSharpPOO.Polimorfismo
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoModelo) : base(tipoModelo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o automóvel");
        }

        public override void Parar()
        {
            Console.WriteLine("Freiando o automóvel");
        }

        public override void Parar(string comoParar)
        {
            Console.WriteLine("Freiando o automóvel " + comoParar);
        }

        public override void Abastecer()
        {
            Console.WriteLine("Abastecendo gasolina");
        }
    }
}
