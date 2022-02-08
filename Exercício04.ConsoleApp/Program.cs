using System;

namespace Exercício04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int testpar = 2;
            
            double numero,resto;
            char teste;

            do
            {
                Console.Write("Digite o número o qual deseja testar: ");
                numero = Convert.ToDouble(Console.ReadLine());
                resto = numero % 2;

                if(resto == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Este número é par !!!");
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Este número não é par !!!");
                }
                    Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    Console.WriteLine("\nDeseja fazer mais alguma avaliação ? ");
                    Console.Write("Digite s para repetir e n para sair: ");
                    teste = Convert.ToChar(Console.ReadLine());
                } while (teste != 's' && teste != 'n');
            } while (teste == 's');
        }
    }
}
