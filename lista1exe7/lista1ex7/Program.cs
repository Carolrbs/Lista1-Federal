using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quilometros;

            Console.Write("Digite a quantidade de milhas marítimas: ");
            double milhas = Convert.ToDouble(Console.ReadLine());

            quilometros = milhas * 1.852;
            Console.WriteLine("A quantidade de milhas marítimas em quilômetros é: " + quilometros);
        }
    }
}
