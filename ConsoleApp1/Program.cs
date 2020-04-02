using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 2;
            int[] vetor;

            vetor = new int[n];
            /*
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vetor[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            foreach (int element in vetor)
            {
                    Console.WriteLine(element);
            }

            Console.WriteLine();

            int[,] matriz;
            matriz = new int[m, m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Matriz[" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            foreach (int conteudo in matriz)
            {
                Console.WriteLine(conteudo);
            } */

            int[] vetor2;
            vetor2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Vetor2[" + i + "]: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            int maior = 0;
            foreach (int example in vetor2)
            {
                if (example > maior)
                    maior = example;
            }

            Console.WriteLine();
            Console.WriteLine(maior);

            int menor = 0;
            foreach (int exampleMenor in  vetor2)
            {
                if (menor == 0)
                    menor = exampleMenor;

                if (exampleMenor < menor)
                   menor = exampleMenor;
            }

            Console.WriteLine(menor);







        }
    }
}
