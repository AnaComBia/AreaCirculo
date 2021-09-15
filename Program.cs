using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Irei calcular a area de uma circuferência---\n");

            Console.Write("Infrome o valor do raio: ");
            double Raio = Convert.ToDouble(Console.ReadLine());

            double Area = (Math.PI) * (Math.Pow(Raio, 2));

            Console.WriteLine($"Area da Circuferência = {Area}");

        }
    }
}
