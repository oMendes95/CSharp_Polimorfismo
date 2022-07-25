using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santuario_Animal.src
{
    public class Alce :Animais
    {

        public Alce(string nome, string especie, double qtdpatas, string cor) : base(nome, especie, qtdpatas, cor)
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


        public void Pastar()
        {
            Console.WriteLine($"Eu {Nome} vou Pastar");
        }

    }
}
