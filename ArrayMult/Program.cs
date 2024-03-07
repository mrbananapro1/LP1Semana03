using System;

namespace MatrixVectorMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verifica se foram passados os argumentos necessários
            if (args.Length != 4)
            {
                Console.WriteLine("Por favor, forneça 4 argumentos: a11 a12 a21 a22");
                return;
            }

            // Lê os elementos da matriz A
            float[,] A = new float[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i, j] = float.Parse(args[i * 2 + j]);
                }
            }

            // Lê os elementos do vetor b
            float[] b = new float[2];
            Console.WriteLine("Por favor, forneça os elementos do vetor b (2 números):");
            for (int i = 0; i < 2; i++)
            {
                b[i] = float.Parse(Console.ReadLine());
            }

            // Realiza a multiplicação da matriz A pelo vetor b
            float[] result = new float[2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * b[j];
                }
            }

            // Exibe o resultado
            Console.WriteLine("O resultado da multiplicação é:");
            Console.WriteLine($"[{result[0]}]");
            Console.WriteLine($"[{result[1]}]");
        }
    }
}
