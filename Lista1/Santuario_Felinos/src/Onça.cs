using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santuario_Animal.src
{
    public class Onça : Animais
    {

        public Onça(string nome, string especie, double qtdpatas, string cor) : base(nome, especie, qtdpatas, cor)
        {

        }

        public override void Comer()
        {
            Console.WriteLine("Eu Onça estou Comendo Nham Nham");
        }

        public override void Dormir()
        {
            Console.WriteLine("Eu Onça estou Dormindo zzzzZZZzzzz");
        }

        public void caçar()
        {
            Console.WriteLine("Eu Onça vou caçar!");
        }

    }

}
