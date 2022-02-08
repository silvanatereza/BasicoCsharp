using System;
using System.Globalization;


namespace MeusExecicios.EstruturasCondicionais
{
    internal class ExCondicional4
    {
        static void Main5()
        {
            /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
              começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas*/

            Console.WriteLine(" HORA INICIAL DO JOGO ");
            int horaInicial = int.Parse(Console.ReadLine());


            Console.WriteLine("HORA FINLA DO JOGO ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine($" O JOGO DUROU {duracao} HORAS ");










        }
    }
}
