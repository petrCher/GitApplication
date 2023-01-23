using System;

namespace GitApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void MatrixA(int w, int h)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Random random = new Random();
            int[,] array = new int[w, h];
            for (int i = 0; i < h; i++)
            {
                for(int j = 0; j < w; j++)
                {
                    array[i, j] = random.Next(0, 2);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
