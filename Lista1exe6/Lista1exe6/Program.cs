using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double valor1;
                double valor2;

                Console.Write("Digite o primeiro valor: ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                valor2 = Convert.ToDouble(Console.ReadLine());

                // Cálculo da média geométrica: raiz quadrada de (valor1 * valor2)
                double mediaGeometrica = Math.Sqrt(valor1 * valor2);

                // Exibição do resultado
                Console.WriteLine($"A média geométrica entre {valor1} e {valor2} é: {mediaGeometrica}");
            
        }

    }
}
