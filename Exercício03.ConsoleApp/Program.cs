using System;

namespace Exercício03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Banha !!!");

            char teste='s';
            double peso, altura, imc;



            while(teste == 's')
            {
                Console.Write("Digite seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite sua altura (EX: 1,8 = 1 metro e 80cm: ");
                altura = Convert.ToDouble(Console.ReadLine());

                imc = peso/(altura*altura);
                Console.Write("Seu percentual de gordura é de: "+imc);
                if (imc < 18.5)
                {
                    Console.Write("E você esta considerado abaixo do peso !!!");
                }
                else if (imc > 18.5 && imc < 25)
                {
                    Console.Write("E você está no peso ideal !!! ");
                }
                else if (imc > 25 && imc < 30)
                {
                    Console.Write("E você esta acima do peso !!! ");
                }
                else if (imc > 25 && imc < 30)
                {
                    Console.Write("E você esta com sobrepeso !!! ");
                }

                do
                {
                    Console.WriteLine("Deseja fazer mais alguma avaliação ? ");
                    Console.Write("Digite s para repetir e n para sair: ");
                    teste = Convert.ToChar(Console.ReadLine());
                } while (teste != 's' && teste != 'n');
                
                Console.Clear();

            }

        }
    }
}
