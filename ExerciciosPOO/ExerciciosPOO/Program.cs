using System;

namespace ExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //var animais = new Animal[2];

            //animais[0] = new Cachorro("Cachorro");
            //animais[1] = new Gato("Gato");

            //animais[0].EmitirSom();
            //animais[1].EmitirSom();

            var pessoas = new Pessoa[3];

            pessoas[0] = new Programador("Bill gates");
            pessoas[1] = new Professor("Ronaldinho");
            pessoas[2] = new Medico("House");

            foreach (var pessoa in pessoas)
                pessoa.Trabalhar();

            Console.ReadKey();
        }
    }
}
