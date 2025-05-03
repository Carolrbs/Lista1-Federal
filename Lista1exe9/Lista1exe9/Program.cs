using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double diametro;
            double area;
            
            Console.WriteLine("Digite o diâmetro do círculo:");
            diametro = Convert.ToDouble(Console.ReadLine());

            // 1. Calcular o raio
            raio = diametro / 2;

            // 2. Calcular a área
            area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($"A área do círculo com diâmetro {diametro} é: {area}");
            //o conole.readkey é para que o programa não feche imediatamente
            Console.ReadKey();
        }
    }
}
