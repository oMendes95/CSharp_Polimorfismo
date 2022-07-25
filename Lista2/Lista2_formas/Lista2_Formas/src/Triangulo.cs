using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Formas.src
{
    public class Triangulo : Formas
    {

        public Triangulo(string forma, double altura, double largura) : base(forma, altura, largura)
        {

        }

        public override void Area()
        {
            Console.WriteLine($"A area do {Forma} é de: {(Altura * Largura) /2} ");
        }
    }
}
