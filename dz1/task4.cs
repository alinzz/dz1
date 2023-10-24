using System;

namespace dz1
{
    public class task4
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("подбрасываем монету 100 раз!");
            int p = 0;
            int o = 0;
            int r = 0;
            Random rnd = new Random(DateTime.Now.Millisecond);

            while (p < 100)
            {
                int m = rnd.Next(2);
                p += 1;
                if (m == 0) o += 1;
                if (m == 1) r += 1;
            }

            Console.WriteLine("\nорел: {0} раз", o);
            Console.WriteLine("\nрешка: {0} раз", r);

        }
    }
}