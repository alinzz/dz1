using System;


namespace dz1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("enter number: ");
            int i = int.Parse(Console.ReadLine());
            for (int a = 2; a < 10; a++)
            {
                if (i % a == 0)
                {
                    Console.WriteLine(a);
                }
            }


        }
    }
}

