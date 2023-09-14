using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Сыркин_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Вычисление факториала");
                Console.WriteLine("2 - Вычисление функции");
                Console.WriteLine("3 - Вычисление Фибоначчи");
                Console.WriteLine("4 - Вычисление Ряда тейлора по формуле е^x");
                Console.Write("Выберите действие: ");
                int d = int.Parse(Console.ReadLine());

                switch (d)
                {
                    case 1:
                        Fact();
                        break;

                    case 2:
                        Func();
                        break;

                    case 3:
                        Fibb();
                        break;

                    case 4:
                        Rad();
                        break;

                    default:
                        Console.WriteLine("Действие не найдено");
                        break;
                }
            }
        }


            public static void Fact()
            {
                while (true)
                {
                Found:
                    Console.Write("\nВведите число для подсчета факториала - ");  //long - юольше int, иначе считает только до 13!   Found - метка, к которой возвращается goto
                    long number = long.Parse(Console.ReadLine());
                    long i = 0;
                    long fact = 1;

                    if (number < 0)
                    {
                        Console.WriteLine("Число отрицательное");
                        goto Found;
                    }

                    while (i < number)
                    {
                        i += 1;
                        fact *= i;
                    }
                    Console.WriteLine(fact + "\n");

                    Console.ReadKey();
                    return;
                }
            }

            public static void Func()
            {

                Console.Write("Введите x - ");
                double x = double.Parse(Console.ReadLine());

                double A = Math.Sqrt(Math.Cos(x - 32) * ((x - 3) / (x + 3))) - Math.Exp(Math.Log(x, 5));

                Console.WriteLine(A + "\n");

                Console.ReadKey();
            }

            public static void Fibb()
            {
                Console.Write("Введите количесиво последовательности: ");
                int number = int.Parse(Console.ReadLine());

                int ferst = 0;
                int second = 1;
                Console.Write("Последовательность чисел Фибоначчи: ");
                Console.Write(" | " + ferst + " | " );



                for (int f = 1; f < number; f++)
                {
                    Console.Write(second + " | ");

                    int temp = ferst;
                    ferst = second;
                    second = temp + second;

                }
                Console.ReadKey();
            }

            public static void Rad()
            {

                Console.Write("Введите x - " );
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите количество членов ряда Тейлора: ");
                double rad = double.Parse(Console.ReadLine());
                double exp = 1;
                for (int n = 1; n <= rad; n++)
                {
                    exp += Math.Pow(x, n) / Factorial(n); //реализация формулы

                    Console.WriteLine(Math.Round(exp,7) + " ");
                }


                Console.ReadLine();
            }


            // функция вычисления факториала
            static int Factorial(int n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i; //или fact *= i;
                }
                return fact;

            }
        
    }


}
