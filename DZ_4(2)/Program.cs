using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_4_2_
{
    enum Swear { Норм, Сред, Высок }
    struct Grandpa
    {
        public string name;
        public Swear swers;
        public string[] phrases;
        public int bruises;

        public int Bruises(string[] phrases,ref int bruises)
        {
            bruises = phrases.Length;
            return bruises;
        }
    }
    internal class Program
    {
        static void Draw(int digit)
        {
            switch (digit)
            {
                case 0:
                    Console.WriteLine(" #### ");
                    Console.WriteLine("#    #\n#    #\n#    #\n#    #");
                    Console.WriteLine(" #### ");
                    break;
                case 1:
                    Console.WriteLine("#\n#\n#\n#");
                    break;
                case 2:
                    Console.WriteLine(" ## \n#  #\n  # \n #  \n####");
                    break;
                case 3:
                    Console.WriteLine("####\n   #\n  ##\n   #\n####");
                    break;
                case 4:
                    Console.WriteLine("#  #\n#  #\n#  #\n####\n   #\n   #\n   #");
                    break;
                case 5:
                    Console.WriteLine("####\n#   \n####\n   #\n####");
                    break;
                case 6:
                    Console.WriteLine("####\n#   \n####\n#  #\n####");
                    break;
                case 7:
                    Console.WriteLine("####\n   #\n  ##\n   #\n   #");
                    break;
                case 8:
                    Console.WriteLine(" ## \n#  #\n#  #\n ## \n#  #\n#  #\n ## ");
                    break;
                case 9:
                    Console.WriteLine(" ## \n#  #\n#  #\n ###\n   #\n   #\n####");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("НУЖНО ВВЕСТИ ЦИФРУ ОТ 0 ДО 9");
                    Thread.Sleep(3000);
                    Console.BackgroundColor= ConsoleColor.Black;
                    break;
            }

        }
        static int Array_1(ref int composition, out double sr, params int[] numbers)
        {
            
            for (int i = 0; i < numbers.Length; i++)
            {
                composition *= numbers[i];
            }
            sr = numbers.Sum() / numbers.Length;
            return numbers.Sum();
        }
        static bool Swap(int digit_1, int digit_2, ref int[] array) 
        {
            int index_1 = Array.IndexOf(array, digit_1);
            int index_2 = Array.IndexOf(array, digit_2);
            bool flag = true;
            if (index_1 != -1 && index_2 != -1)
            {
                int temp = array[index_1];
                array[index_1] = array[index_2];
                array[index_2] = temp;
                return flag;
            }
            else
            {
                Console.WriteLine("В массиве нет таких элементов!");
                flag = false;
                return flag;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1  Поменять два чила в массиве!");
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < 20; i++) 
            {
                array[i] = rand.Next(100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите первое число:");
            bool isNum_1 = int.TryParse(Console.ReadLine(), out int digit_1);

            Console.WriteLine("Введите второе число:");
            bool isNum_2 = int.TryParse(Console.ReadLine(), out int digit_2);
            if (isNum_1 && isNum_2)
            {
                if (Swap(digit_1, digit_2, ref array))
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Нужно вводить числа!");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Задание 2  Написать метод, где в качества аргумента будет передан массив");
            int composition = 1;
            double sr;
            Console.WriteLine($"Сумма массива - {Array_1(ref composition, out sr, 1, 2, 3, 4, 5)}");
            Console.WriteLine($"Произведение массива - {composition}");
            Console.WriteLine($"Ср.знач. массива - {sr}");

            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();

            Console.WriteLine("Задание 3 консоли нарисовать изображение цифры в виде символа #");
            while (true)
            {
                Console.WriteLine("Введите число от 0 до 9, exit или закрыть");
                string word = Console.ReadLine().ToLower();
                bool isNumberr_2 = int.TryParse(word, out int digit);
                if (isNumberr_2)
                {
                    Draw(digit);
                }
                else if (word == "exit" || word == "закрыть")
                {
                    break;
                }
                else
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Нужно ввести число от 0 до 9, exit или закрыть");
                    }
                    
                }
            

            }
            Environment.Exit(0);

            Console.WriteLine("Задание 4  Создать структуры Дедов");
            Grandpa pa_1 = new Grandpa();
            pa_1.name = "Петя";
            pa_1.swers = Swear.Норм;
            pa_1.bruises = 0;
            pa_1.phrases = new string[] {"Гады"};

            Grandpa pa_2 = new Grandpa();
            pa_2.name = "Аркадий";
            pa_2.swers = Swear.Норм;
            pa_2.bruises = 0;
            pa_2.phrases = new string[] { "Гады", "Проститутки"};

            Grandpa pa_3 = new Grandpa();
            pa_3.name = "Иван";
            pa_3.swers = Swear.Сред;
            pa_3.bruises = 0;
            pa_3.phrases = new string[] {"Гады", "Проститутки", "Суки"};

            Grandpa pa_4 = new Grandpa();
            pa_4.name = "Святослав";
            pa_4.swers = Swear.Сред;
            pa_4.bruises = 0;
            pa_4.phrases = new string[] { "Гады", "Проститутки", "Суки", "Черти"};

            Grandpa pa_5 = new Grandpa();
            pa_5.name = "Иван";
            pa_5.swers = Swear.Высок;
            pa_5.bruises = 0;
            pa_5.phrases = new string[] { "Гады", "Проститутки", "Суки", "Черти", "Уроды"};

            Console.WriteLine($"Дед {pa_1.name} получил {pa_1.Bruises(pa_1.phrases,ref pa_1.bruises)} фингалов от бабки");
            Console.WriteLine($"Дед {pa_2.name} получил {pa_2.Bruises(pa_2.phrases, ref pa_2.bruises)} фингалов от бабки");
            Console.WriteLine($"Дед {pa_3.name} получил {pa_3.Bruises(pa_3.phrases, ref pa_3.bruises)} фингалов от бабки");
            Console.WriteLine($"Дед {pa_4.name} получил {pa_4.Bruises(pa_4.phrases, ref pa_4.bruises)} фингалов от бабки");
            Console.WriteLine($"Дед {pa_5.name} получил {pa_5.Bruises(pa_5.phrases, ref pa_5.bruises)} фингалов от бабки");

            Console.WriteLine("Нажмите любую клавишу, чтобы закрыть приложение");
            Console.ReadKey();
        }
    }
}
