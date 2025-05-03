using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aqui declaramos as variaveis
            int valor1;
            int valor2;
            int valor3;
            int valor4;
            int media;

            //Pegamos o valor do usuario
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine()); ;

            Console.WriteLine("Digite o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine()); ;

            Console.WriteLine("Digite o quarto valor");
            valor4 =int.Parse(Console.ReadLine()); ;

            media = (valor1 + valor2 + valor3 + valor4) / 4;
            Console.WriteLine($"A média dos valores é: {media}");
            //Essa variavel é para que o console não feche imediatamente
            Console.ReadKey();
        }
    }
}
