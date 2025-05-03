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
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            // Pede o segundo número
            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            // Compara os dois números e mostra o maior
            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O maior número é: " + numero2);
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }
    }
}