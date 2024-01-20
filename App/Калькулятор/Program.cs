using System;
using System.Text;
using Калькулятор;

namespace App
{
    public class App
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("1.Сложить 2 числа\n" +
                    "2.Вычеслить первое из второго\n" +
                    "3.Перемножить 2 числа\n" +
                    "4.Разделить первое на второе\n" +
                    "5.Возвести в степень N\n" +
                    "6.Найти квадратный корень из числа\n" +
                    "7.Найти 1 процент от числа\n" +
                    "8.Найти факториал из числа\n" +
                    "9.Выйти");

                int d = Convert.ToInt32(Console.ReadLine());
                SelectCase(d);
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
        }

        public static void SelectCase(int d)
        {
            switch (d)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ответ: {methods.MenhodsPlus(a, b)}");
                    Main();
                    break;
                case 2:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ответ: {methods.MethodsMinus(a, b)}");
                    Main();
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ответ: {methods.MethodsUmnojit(a, b)}");
                    Main();
                    break;
                case 4:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ответ: {methods.MthodsDelenie(a, b)}");
                    Main();
                    break;
                case 5:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ответ: {methods.MethodsStepen(a, b)}");
                    Main();
                    break;
                case 6:
                    Console.WriteLine("Введите число для нахождения корня:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ответ: {methods.MethodsKoren(a)}");
                    Main();
                    break;
                case 7:
                    Console.WriteLine("Введите число для нахождения процента:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ответ: {methods.MethodsProcent(a)}");
                    Main();
                    break;
                case 8:
                    Console.WriteLine("Введите число для нахождения факториала:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ответ: {methods.MethodsFact(a)}");
                    Main();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}