using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[15];
            Random rng = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rng.Next(-50, 51);
            }
            int count = 0;
            foreach (int num in nums)
            {
                if (num % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Массив:");
            foreach (int num in nums)
            {
                Console.WriteLine($"{num} ");
            }
            Console.WriteLine($"Количество элементов, кратных 3: {count}");
            Console.ReadLine();
        }
    }
}
