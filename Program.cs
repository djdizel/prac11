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
        {//Задача 14. Дан курс рубля России за январь 2023 года. Рассчитать:
            double[] courseRates = {69.2154, 69.3143, 69.3774, 69.2281, 69.1245, 69.1115, 69.2098,
            69.3082, 69.2465, 69.3098, 69.2210};
            double sum = 0;
            double maxRate = courseRates[0];
            double minRate = courseRates[0];
            int maxDay = 0;
            int minDay = 0;
            for (int i = 0; i < courseRates.Length; i++)
            {
                sum += courseRates[i];

                if (courseRates[i] > maxRate)
                {
                    maxRate = courseRates[i];
                    maxDay = i + 1; 
                }

                if (courseRates[i] < minRate)
                {
                    minRate = courseRates[i];
                    minDay = i + 1;
                }
            }
            double averageRate = sum / courseRates.Length;
            Console.WriteLine($"Среднее значение КВ (СКВ): {averageRate:F4}");
            Console.WriteLine($"Максимальное значение КВ (МаксКВ): {maxRate:F4}");
            Console.WriteLine($"Минимальное значение КВ (МинКВ): {minRate:F4}");
            Console.WriteLine($"День с максимальным значением КВ (МаксКВД): {maxDay}");
            Console.WriteLine($"День с минимальным значением КВ (МинКВД): {minDay}");
            Console.ReadLine();
        }
    }
}
