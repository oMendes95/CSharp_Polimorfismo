using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santuario_Animal.src
{
    public class Peixe : Animais
    {

        public Peixe(string nome, string especie, double qtdpatas, string cor) : base(nome, especie, qtdpatas, cor)
        {

        }

        public override void Comer()
        {
            Console.WriteLine($"Eu {Nome} vou Comer");
        }

        public override void Dormir()
        {
            Console.WriteLine($"Eu {Nome} estou Dormindo zzzzZZZzzzz");
        }


        public void Nadar()
        {
            Console.WriteLine($"Eu {Nome} vou nadar");
        }



    }
}
