using System;

namespace Двумерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int y = 0;
            int a = 0;
            int [,] vfccbd = new int [7, 8];
            var hfyljv = new Random();
            for (i = 0; i < 7; i++)
            {
                for (y = 0; y < 8; y++)
                {
                    vfccbd[i, y] = hfyljv.Next(0,100);
                    a = vfccbd[i, y] % 2;
                    if (a == 1)
                    {
                        Console.WriteLine(vfccbd[i, y] + ", ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
