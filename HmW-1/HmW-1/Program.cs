using System;

namespace HmW_1
{
    class Program
    {
        /*Написать программу-калькулятор, вычисляющую выражения вида
        a + b, a - b, a / b, a * b,
        введенные из командной строки, и выводящую результат выполнения на
        экран*/
        static void Main(string[] args)
        {
            double a,b,total;
            char oper;

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }
            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }
            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
            }
            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }
        }
    }
}
