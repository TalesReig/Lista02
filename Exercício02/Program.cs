using System;

namespace Exercício2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA, numB, numC;
            Console.Write("Digite o primeiro número:");
            numA = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Digite o primeiro número:");
                numB = Convert.ToInt32(Console.ReadLine());
            } while (numA == numB);

            do
            {
                Console.Write("Digite o primeiro número:");
                numC = Convert.ToInt32(Console.ReadLine());
            } while (numA == numC && numC == numB);

            if(numA > numB && numB > numC)
            {
                Console.WriteLine("Os números em ordem decrescente é: " + numA +" "+ numB + " "+ numC);
            }else if(numA > numC && numC > numB)
            {
                Console.WriteLine("Os números em ordem decrescente é: " + numA + " " + numC + " " + numB);
            }else if(numB > numA && numA > numC){
                Console.WriteLine("Os números em ordem decrescente é: " + numB + " " + numA + " " + numC);
            }else if (numB > numC && numC > numA)
            {
                Console.WriteLine("Os números em ordem decrescente é: " + numB + " " + numC + " " + numA);
            }else if (numC > numA && numA > numB)
            {
                Console.WriteLine("Os números em ordem decrescente é: " + numC + " " + numA + " " + numB);
            }else if (numC > numB && numB > numA)
            {
                Console.WriteLine("Os números em ordem decrescente é: " + numC + " " + numB + " " + numA);
            }
            Console.ReadLine();
        }
    }
}
