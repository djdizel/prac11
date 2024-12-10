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
            //Задача 10.Удаление всех четных элементов из массива.
            int[] nums = {1,2,3,4,5,6,7,8};
            Console.WriteLine("Нечетные элементы:");
            foreach(var el in nums)
            {
                if(el % 2 != 0)
                {
                    Console.WriteLine(el);
                }
            }
            Console.ReadLine();
        }
    }
}
