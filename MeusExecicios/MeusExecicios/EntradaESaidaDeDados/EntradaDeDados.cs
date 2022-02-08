using System;
using System.Globalization;


namespace MeusExecicios.NovaPasta
{
    internal class EntradaDeDados
    {

        static void Main2()
        {
            {
                // FAZER UM PROGRAMA PARA EXECUTAR OS DADOS QUE O USUÁRIO DIGITAR ! 


                Console.WriteLine(" ENTRE COM O SEU NOME COMPLETO  ");
                string nome = Console.ReadLine();

                Console.WriteLine("QUANTOS QUARTOS TEM NA SUA CASA ? ");
                int quartos = int.Parse(Console.ReadLine());

                Console.WriteLine("ENTRE COM UM PREÇO DE UM PRODUTO ");
                double preco = double.Parse(Console.ReadLine());

                Console.WriteLine("ENTRE SEU ÚTIMO NOME , IDADE E ALTURA (NA MESMA LINHA )");

                string[] vet = Console.ReadLine().Split(' ');
                string unome = vet[0];
                int idade = int.Parse(vet[1]);
                double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


                Console.WriteLine("--------- SAÍDA ---------");

                // SAÍDA ESPERADA (NÚMEROS REAIS COM DUAS CASAS DECIMAIS



                Console.WriteLine(nome);
                Console.WriteLine(quartos);
                Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(unome);
                Console.WriteLine(idade);
                Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
