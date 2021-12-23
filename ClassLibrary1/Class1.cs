using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Class1
    {
        public static int Sum(int[,] Mass)
        {
            int s = 1;
            Console.Write("Массив:");
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    Console.Write(Mass[i, j] + " ");
                    if (i == j) s *= Mass[i, j];
                }
            }
            Console.WriteLine();
            Console.Write("Произведение элементов " + s);
            Console.ReadKey();
            return s;
        }
    }
}
