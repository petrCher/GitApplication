using System;

namespace GitApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixA(2, 4);
        }
        static void MatrixA(int w, int h)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Random random = new Random();
            int[,] array = new int[w, h];
            for (int i = 0; i < w; i++)
            {
                for(int j = 0; j < h; j++)
                {
                    array[i, j] = random.Next(0, 2);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Black;
            
        }
        public static void MatrixB(int w,int h)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Random r = new Random();
            int[,] array = new int[w,h];
           for(int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    array[i, j] = r.Next(0, 2);
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static void PrintMyName()
        {
            Console.WriteLine("Митяев Антон Андреевич");
            Console.WriteLine("10.3");
            Console.WriteLine("12.10");
        }
    }
}
