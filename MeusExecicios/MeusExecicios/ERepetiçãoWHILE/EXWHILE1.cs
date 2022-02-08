using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusExecicios.ERepetiçãoWHILE
{
    internal class EXWHILE1
    {
        static void Main5()
        {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
             incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
             impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            Exemplo:
                        */



            Console.Write("DIGITE A SENHA : ");

            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("SENHA INVALIDA ! ");

                Console.WriteLine("DIGITE OUTRA SENHA !");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" SENHA VÁLIDA ");

        }
    }
}
