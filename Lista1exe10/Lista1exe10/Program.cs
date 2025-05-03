using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double QuantDolar;
            double cotacaoDolar;
            double valoremReais;

            Console.WriteLine("Digite a cotação do Dolar.");
            cotacaoDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em dolar que você quer calcular. ");
            QuantDolar = double.Parse(Console.ReadLine());

            valoremReais = QuantDolar * cotacaoDolar;

            Console.WriteLine("O valor em reais é: " + valoremReais + " reais.");
        }



    }
}
