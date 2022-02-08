using System;

namespace Exercício05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC;

            Console.Write("Digite o primeiro Valor: ");
            valorA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o primeiro Valor: ");
            valorB = Convert.ToInt32(Console.ReadLine());

            if(valorA == valorB)
            {
                valorC = valorA + valorB;
            } else { 
                valorC = valorA * valorB;
            }

            Console.Write("O Conteudo da variael C é: "+ valorC);
            Console.ReadLine();
        }
    }
}
