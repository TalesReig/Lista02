using System;

namespace Exercício02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numA, numB, numC;

            Console.Write("Digite o primeiro número: ");
            numA = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.Write("Digite o Segundo número: ");
                numB = Convert.ToDouble(Console.ReadLine());
            } while (numA == numB);

            do
            {
                Console.Write("Digite o terceiro número: ");
                numC = Convert.ToDouble(Console.ReadLine());
            } while (numA == numC && numC == numB);


            if (numA > numB && numB > numC)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + numA + "-" + numB + "-" + numC + ".");
            }
            else if (numA > numC && numC > numB)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + numA + "-" + numC + "-" + numB + ".");
            }
            else if (numB > numA && numA > numC)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + numB + "-" + numA+ "-" + numC + ".");
            }
            else if (numB > numC && numC > numA)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + numB + "-" + numC + "-" + numA + ".");
            }
            else if (numC > numA && numA > numB)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + numC + "-" + numA + "-" + numB + ".");
            }
            else if (numC > numB && numB > numA)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + numC + "-" + numB + "-" + numA + ".");
            }

            Console.ReadLine();
        }
    }
}
