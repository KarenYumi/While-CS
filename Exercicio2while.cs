using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Exercicio2while
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Digite duas cordenadas: (x e y)");
             string[] numeros = Console.ReadLine().Split(' ');
             int num1 = int.Parse(numeros[0]);
             int num2 = int.Parse(numeros[1]);


             while (num1 != 0 && num2 != 0)
             {
             if (num1 >= 0 && num2 >= 0)
             {
                 Console.WriteLine("Primeiro quadrante");
             }
             else if (num1 >= 0 && num2 <= 0)
             {
                 Console.WriteLine("Quarto quadrante");
             }
                 else if (num1 <= 0 && num2 <= 0)
             {
                 Console.WriteLine("Terceiro quadrante");
             }
             else
             {
                 Console.WriteLine("Segundo quadrante");
             }
             numeros = Console.ReadLine().Split(' ');
             num1 = int.Parse(numeros[0]);
             num2 = int.Parse(numeros[1]);
             }
             Console.WriteLine("Não foi possivel consultar qual quadrante suas cordenadas estão");
            
        }
    }
}
