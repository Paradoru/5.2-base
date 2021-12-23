using System;
using Lib;

namespace _5._2_base
    // базовый уровень 9 вариант
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random r = new Random();
                int[,] Mass = new int[6, 6];
                int i, j;
                string byf;
                Console.Write("1 - Ввод вручную, 2 - Рандомный ввод: ");
                byf = Console.ReadLine();
                switch (byf)
                {
                    case "1":
                        for (i = 0; i < Mass.GetLength(0); ++i)
                            for (j = 0; j < Mass.GetLength(1); ++j)
                            {
                                Console.Write("Введите " + i + " " + j + " элемент: ");
                                Mass[i, j] = int.Parse(Console.ReadLine());
                            }
                        break;

                    case "2":
                        for (i = 0; i < Mass.GetLength(0); i++)
                            for (j = 0; j < Mass.GetLength(1); j++)
                                Mass[i, j] = r.Next(-100, 100);
                        break;
                    default:
                        Console.WriteLine();
                        Console.ReadKey();
                        return;
                }
                int res = Lib.Class1.Sum(Mass);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


