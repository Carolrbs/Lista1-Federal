using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        { // Calcular a área de um quadrado a partir da diagonal
            // Mostra uma mensagem para o usuário digitar o valor da diagonal
            Console.Write("Digite a diagonal do quadrado: ");

            // Lê o valor digitado (como texto) e transforma em número (tipo double)
            double diagonal = double.Parse(Console.ReadLine());

            // Calcula o lado do quadrado dividindo a diagonal por 1.41 (aproximação da raiz de 2)
            double lado = diagonal / 1.41;

            // Calcula a área do quadrado (lado vezes lado)
            double area = lado * lado;

            // Mostra o resultado da área na tela
            Console.WriteLine("A área do quadrado é: " + area);


        }
    }
}
