using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusExecicios.EstruturasCondicionais
{
    internal class EstruturaCondicionalEncadeada
    {
        static void Main5()
        {
            // FAZER UM PROGRAMA PARA LER UM NÚMERO INTEIRO , E DEPOIS DIZER SE ESTE NÚMERO É NEGATIVO OU NÃO

            Console.Write(" digite um número : ");

            int numero = int.Parse(Console.ReadLine());

            if (numero == - 20)
            {
                Console.WriteLine("NEGATIVO");
            } else if (numero == 20)
            {
                Console.WriteLine("NÃO NEGATIVO ");
            }
           
        }
    }
}
