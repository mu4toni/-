using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перепиакак
{
    internal class Program
    {
        static int AddNumber()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            return sum;
        }
        static void ChekEven()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число нечетное");
        }
        static void CalculateDiscount()
            {
            Console.WriteLine("Введите цену товара");
            Console.WriteLine("Введите процент скидки");
            doublw discountAmount = price*Discount
            Console.WriteLine($"Начальная цена{price}");
            Console.WriteLine($"Финальная цена {Finalprice}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма чисел");
            AddNumber();
            AddNumber();
            AddNumber();

            Console.WriteLine("Проверка четности");
            ChekEven();
            ChekEven();
            ChekEven();

            Console.WriteLine("Расчет финальной стоимости");
        }
    }
}
