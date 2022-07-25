using System;
using Lista2_Formas.src;

namespace Lista2_Formas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Qual forma Geometrica deseja Calcular: ");
            string forma = Console.ReadLine();
            Console.WriteLine("Qual a Altura do Objeto: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a Largura do Objeto: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (forma == "Triangulo")
            {

                Triangulo Xtriang = new Triangulo("Triangulo", h, b);
                Console.WriteLine(Xtriang.ToString());
                Xtriang.Area();

            }
            else if (forma == "Quadrado")
            {

                Quadrado Xquadra = new Quadrado("Quadrado", h, b);
                Console.Write(Xquadra.ToString());
                Xquadra.Area();
            }
            else if (forma == "Retangulo")
            {
                Retangulo Xretan = new Retangulo("Retangulo", h, b);
                Console.WriteLine(Xretan.ToString());
                Xretan.Area();
            }
            else
            {
                Console.WriteLine("Insira uma forma geometrica valida.");
            }
        }
    }
}
