using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rev___Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int Soma;

            int[,] Matriz=new int[3,3];

            //Entrada dos Dados da Matriz
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Elemento ({0},{1}) da Matriz: ", i + 1, j + 1);
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Soma dos Elementos da Diagonal Principal da Matriz
            Soma=0;
            
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                        Soma += Matriz[i, j];
                }
            }

            Console.WriteLine("\nSoma dos Elementos da Diagonal Principal da Matriz: {0}", Soma);
            Console.ReadKey();

            Console.WriteLine("\n");

            //Soma dos Elementos de cada Linha da Matriz
            Soma = 0;

            for (i = 0; i < 3; i++)
            {
                Soma = 0;       //"Zera" a variável Soma

                for (j = 0; j < 3; j++)
                {
                    Soma += Matriz[i, j];
                }

                Console.WriteLine("Soma dos Elementos da Linha {0} da Matriz: {1}", i+1,Soma);
            }

            Console.ReadKey();

            Console.WriteLine("\n");

            //Soma dos Elementos de cada Coluna da Matriz
            Soma = 0;

            for (i = 0; i < 3; i++)
            {
                Soma = 0;       //"Zera" a variável Soma

                for (j = 0; j < 3; j++)
                {
                    Soma += Matriz[j, i];       //Trocou!
                }

                Console.WriteLine("Soma dos Elementos da Coluna {0} da Matriz: {1}", i+1, Soma);
            }

            Console.ReadKey();
        }
    }
}
