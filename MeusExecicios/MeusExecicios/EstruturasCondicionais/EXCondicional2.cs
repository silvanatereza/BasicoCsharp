using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusExecicios.EstruturasCondicionais
{
    internal class EXCondicional2
    {
        static void  Main5()
        {
            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
              seguir, calcule e mostre o valor da conta a pagar.

                 CODIGO - ESPECIFICAÇÃO     - PREÇO 
                  1      - CACHORRO QUENTE - R$ 4,00
                  2      - X-SALADA        - R$ 4,50
                  3      - X-BACON         - R$ 5,00
                  4      - TORADDA SIMPLES - R$ 2,00
                  5      - REFRIGERANTE    - R$ 1,50 */

            Console.Write(" DIGITE O CÓDIGO DO PRODUTO : ");
            double codigo = double.Parse(Console.ReadLine());
            
            Console.Write(" QUANDOTIDADE DO PRODUTO :");
            double quantidade = double.Parse(Console.ReadLine());

             double total  ;

            if (codigo ==  1)
            {
                total = quantidade * 4.0; 
            }else if (codigo == 2)
            {
                total = quantidade * 4.5;
            } else if (codigo == 3)
            {
                total =  quantidade *  5.0;
            } else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }else
            {
                total = quantidade * 1.5;
            }
            Console.WriteLine(" TOTAL : R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
