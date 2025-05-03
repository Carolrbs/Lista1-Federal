using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto1;
            double produto2;
            double produto3;
            double produto4;
            double produto5;
            double somaprodutos;
            double pagamento;
            double troco;

            Console.WriteLine("Digite o valor do Primeiro Produto");
            produto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Segundo Produto");
            produto2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Terceiro Produto");
            produto3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Quarto Produto");
            produto4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Quinto Produto");
            produto5 = double.Parse(Console.ReadLine());

            somaprodutos = produto1 + produto2 + produto3 + produto4 + produto5;

            Console.WriteLine("Digite o valor do Pagamento do cliente");
            pagamento = double.Parse(Console.ReadLine());

            troco =  pagamento - somaprodutos;

            Console.WriteLine("O valor do troco do cliente é: R$ " + troco);
        }
    }
}
