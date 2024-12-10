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
            //Задача 11. Сумма всех элементов массива.
            int[] nums = {1,2,3,4,5,6,7,8};
            int sum = 0;
            foreach(var el in nums)
            {
                sum += el;
            }
            Console.WriteLine($"Сумма {sum}");
            Console.ReadLine();
        }
    }
}
