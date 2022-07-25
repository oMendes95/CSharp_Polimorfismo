using Santuario_Animal.src;
using System;

namespace Santuario_Animal
{
    public class Animais
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Onça onça = new("Juma", "Onça", 4, "Pintada" );
            Alce alce = new("Rutt", "Alce", 4, "Marrom");
            Alce alce2 = new("Tuke", "Alce", 4, "Marrom Claro");
            Peixe peixe = new("Nemo", "Peixe", 1.5, "Laranja e Branco");

            Console.WriteLine("Juma".ToString());
            onça.caçar();
            Console.WriteLine("Rutt".ToString());
            alce.Comer();
            alce.Pastar();
            Console.WriteLine("Tuke".ToString());
            alce2.Dormir();
            alce2.Comer();
            alce2.Pastar();
            Console.WriteLine("Nemo".ToString());
            peixe.Nadar();


        }
    }
}
