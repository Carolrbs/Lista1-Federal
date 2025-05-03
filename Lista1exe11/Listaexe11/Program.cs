using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaexe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorX;
            double valorY;
            double resultado;

            Console.WriteLine("Digite o valor de x ");
            valorX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y ");
            valorY = double.Parse(Console.ReadLine());

            resultado = Math.Pow(valorX, valorY);
            // Aqui o primeiro numero e o segundo é que está elevado;

            Console.WriteLine("O resultado de {0} elevado a {1} é: {2}", valorX, valorY, resultado);
            //Lembro que em Java o {} referencia ao valor da variável, já no C# o {0} é o primeiro valor, {1} é o segundo valor e assim por diante.
            // Acontece a mesma coisa.

        }
    }
}
