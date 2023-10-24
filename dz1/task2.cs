using System;

namespace dz1
{
    internal class task2
    {
        public static void Main(string[] args)
        {
            Console.Write("введите 2 числа: ");
            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            int c3 = 0;
            int c5 = 0;
            int c9 = 0;
            //введенные числа входят в диапазон поиска
            for (int a = i1; a <= i2; a++)
            {
                if (a % 3 == 0)
                {
                    c3 = c3 + 1;
                }

                if (a % 5 == 0)
                {
                    c5 = c5 + 1;
                }

                if (a % 9 == 0)
                {
                    c9 = c9 + 1;
                }
            }

            Console.Write("диапазон {0} - {1}", i1, i2);
            Console.Write("\nделятся на 3, кол-во: {0}", c3);
            Console.Write("\nделятся на 5, кол-во:{0}", c5);
            Console.Write("\nделятся на 9, кол-во:{0}", c9);
        }
    }
}