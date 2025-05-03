using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lista1exe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //temperarura em celsius para Fahrenheit

            int celsius;
            int fahrenheit;

            Console.WriteLine("Digite a temperatura em Celsius: ");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
            Console.ReadKey();

        }
    }
}
