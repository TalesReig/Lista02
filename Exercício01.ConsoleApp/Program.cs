using System;

namespace Exercício01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numA, numB, numC;

            Console.Write("Digite o valor A: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor A: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor A: ");
            numC = Convert.ToDouble(Console.ReadLine());

            if( numA + numB < numC){
                Console.WriteLine("Sim, A + B é menor do que C !!!");
            } else
            {
                Console.WriteLine("É MINTIRA !!!");
            }

            Console.ReadLine();
        }
    }
}
