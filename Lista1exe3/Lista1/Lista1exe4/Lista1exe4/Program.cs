using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basetriangulo;
            double alturatriangulo;
            double area;

            Console.WriteLine("Digite a base do triangulo: ");
            basetriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do triangulo: ");
            alturatriangulo = Convert.ToDouble(Console.ReadLine());

            area = (basetriangulo * alturatriangulo) / 2;

            Console.WriteLine("A area do triangulo é: " + area);
        }
    }
}