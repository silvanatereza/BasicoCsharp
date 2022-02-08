using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusExecicios.EstruturasCondicionais
{
    internal class EstruturaCondicionalComposta
    {
        static void Main4()
        {
            Console.Write("Digite Um Número :  ");

            int b = int.Parse(Console.ReadLine());

            if (b <= 12)
            {
                Console.WriteLine("Bom dia !");
            }else
            {
                Console.WriteLine(" Boa Tarde !");
            }
        }
    }
}
