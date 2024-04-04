using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha desta conta: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha incorreta");
                Console.WriteLine("Digite a senha desta conta: ");
                 senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta!");


        }
    }
}