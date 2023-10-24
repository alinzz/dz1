using System;

namespace dz1
{
    public class task3
    {
        public static void Main(string[] args)
        {
            double avg = 0;
            int max = 0;
            int sum = 0;
            Console.Write("введите 10 чисел: ");
            string[] nums_strings = Console.ReadLine().Split();
            int[] nums = new int[nums_strings.Length];
            for (int i = 0; i < nums_strings.Length; i++)
                nums[i] = Convert.ToInt32(nums_strings[i]);
            for (int I = 0; I < nums.Length; I += 1)
                avg += nums[I];
            avg /= nums.Length;
            for (int I = 0; I < nums.Length; I += 1)
                if (nums[I] > max)
                    max = nums[I];
            Console.Write("среднее: {0:F1}", avg);
            Console.Write("\nмаксимальное: {0}", max);
        }
    }
}