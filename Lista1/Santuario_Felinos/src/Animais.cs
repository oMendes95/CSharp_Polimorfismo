using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santuario_Animal.src
{
    public class Animais
    {
        public string Nome { get; set; }
        string Especie { get; set; }
        double Qtdpatas { get; set; }
        string Cor { get; set; }

        public Animais()
        {

        }

        public Animais(string nome, string especie, double qtdpatas, string cor)
        {
            Nome = nome;
            Especie = especie;
            Qtdpatas = qtdpatas;
            Cor = cor;
        }

        public virtual void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }

        public virtual void Dormir()
        {
            Console.WriteLine($"{Nome} está dormindo");
        } 


    }
}
