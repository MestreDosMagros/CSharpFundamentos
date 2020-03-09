using System;

namespace CSharpPOO.Interfaces
{
    public class Automovel : IVeiculo
    {
        public Automovel(string tipoModelo)
        {
            TipoModelo = tipoModelo;
        }

        public string TipoModelo { get; private set; }

        public void Mover()
        {
            Console.WriteLine("Acelerando o automóvel");
        }

        public void Parar()
        {
            Console.WriteLine("Freiando o automóvel");
        }
    }
}
