using System;
using System.Diagnostics.Eventing.Reader;
namespace DZ_4
{
    internal class Program
    {
        static int Fibanachi(int number_2)
        {
            if (number_2 <= 2)
            {
                return 1;
            }
            else
            {
                return Fibanachi(number_2 - 2) + Fibanachi(number_2 - 1);
            }
        }
        static int NOD(int dgt, int dgt_1)
        {
            int maxi = Math.Max(dgt, dgt_1);
            int mini = Math.Min(dgt, dgt_1);
            int result = Math.Min(dgt, dgt_1);
            while (maxi % mini != 0)
            {
                result = maxi % mini;
                int temp = mini;
                mini = maxi % mini;
                maxi = temp;

            }
            return result;
        }
        static int Factorial_1(int digit)
        {

            if (digit == 0)
            {
                return 1;
            }
            else
            {
                return checked(digit * Factorial_1(digit - 1));
            }

        }
        static bool Factorial(int digit, out int factorial)
        {
            factorial = 1;
            try
            {
                for (int i = 1; i <= digit; i++)
                {
                    checked
                    {
                        factorial *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        static void SwapPlace(ref double var_1, ref double var_2)
        {
            double temp = var_1;
            var_1 = var_2;
            var_2 = temp;
        }
        static double Max(double first, double second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1 Наибольшее из двух чисел.");
            Console.Write("Введите первое число: ");
            bool isNum = double.TryParse(Console.ReadLine(), out double first);
            Console.Write("Введите второе число: ");
            bool isNum_1 = double.TryParse(Console.ReadLine(), out double second);
            if (isNum && isNum_1)
            {
                Console.WriteLine(Max(first, second));
            }
            else 
            {
                Console.WriteLine("Нужно ввести числа");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Упражнение 5.2 Меняет местами значения двух передаваемых параметров.");
            Console.Write("Введите первую переменную: ");
            bool isNum_11 = double.TryParse(Console.ReadLine(), out double var_1);
            Console.Write("Введите вторую переменную: ");
            bool isNum_00 = double.TryParse(Console.ReadLine(), out double var_2);
            if (isNum_11 && isNum_00)
            {
                SwapPlace(ref var_1,ref var_2);
                Console.WriteLine($"Значение первой переменной - {var_1}, второй - {var_2}");
            }
            else
            {
                Console.WriteLine("Нужно ввести числа");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Упражнение 5.3  Написать метод вычисления факториала числа");
            Console.WriteLine("Введите число: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int digit);
            if (isNumber && digit > 0)
            {
                if (Factorial(digit, out int factorial))
                {
                    Console.WriteLine($"Факториал {digit} равен - {factorial}");
                }
                else
                {
                    Console.WriteLine("Возникто переполнение");
                }
            }
            else
            {
                Console.WriteLine("Нужно ввести число");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа");
            Console.WriteLine("Введите число: ");
            bool isNumber_1 = int.TryParse(Console.ReadLine(), out int digit_1);
            if (isNumber_1 && digit_1 > 0)
            {
                try 
                {
                    Console.WriteLine($"Факториал числа равен - {Factorial_1(digit_1)}");
                }
                catch (OverflowException) 
                {
                    Console.WriteLine("Возникло переволнение!");
                }
                
            }
            else
            {
                Console.WriteLine("Нужно ввести число");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 5.1 Написать метод, который вычисляет НОД");
            Console.WriteLine("Введите первое число:");
            bool num_11 = int.TryParse(Console.ReadLine(), out int dgt);
            Console.WriteLine("Введите второе число:");
            bool num_12 = int.TryParse(Console.ReadLine(), out int dgt_1);
            if (num_11 && num_12)
            {
                Console.WriteLine($"Наибольший общий делитель - {NOD(dgt, dgt_1)}");
            }
            else
            {
                Console.WriteLine("Нужно ввести числа");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 5.2 вычислить значение n-го числа ряда Фибоначчи.");
            Console.WriteLine("Введите номер числа: ");
            bool isNum_3 = int.TryParse(Console.ReadLine(), out int number_2);
            if (isNum_3)
            {
                Console.WriteLine(Fibanachi(number_2)); ;
            }
            else 
            {
                Console.WriteLine("Нужно ввести число!");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();
        }   
    }
}