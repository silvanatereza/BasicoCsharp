using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusExecicios.EstruturasCondicionais
{
    internal class ECEncadeada
    {
        static void Main5()
        {
            // FAZER UM PROGRANMA PARA LER UM NÚMERO INTEIRO E DIZER SE ESTE NÚMERO É PAR OU IMPAR  

            Console.Write("Digite o número : ");

            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(" PAR  ");
            }
            else
            {
                Console.WriteLine(" IMPAR  ");
            }
        }

    }
}
