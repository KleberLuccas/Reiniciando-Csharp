using System;

namespace Inverter_nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome, segundoNome, terceiroNome, quartoNome, auxiliar;

            Console.WriteLine("Digite o primeiro nome");
            primeiroNome = Console.ReadLine();
            Console.WriteLine("Digite o segundo nome");
            segundoNome = Console.ReadLine();
            Console.WriteLine("Digite o terceiro nome");
            terceiroNome = Console.ReadLine();
            Console.WriteLine("Digite o quarto nome");
            quartoNome = Console.ReadLine();

            //Mecanismo para inverter os nomes
            auxiliar = primeiroNome;
            primeiroNome = quartoNome;
            quartoNome = auxiliar;
            auxiliar = segundoNome;
            segundoNome = terceiroNome;
            terceiroNome = auxiliar;

            Console.WriteLine();
            Console.WriteLine("Nomes inseridos em ordem invertida");
            Console.WriteLine(primeiroNome);
            Console.WriteLine(segundoNome);
            Console.WriteLine(terceiroNome);
            Console.WriteLine(quartoNome);
            Console.ReadKey();
        }
    }
}
