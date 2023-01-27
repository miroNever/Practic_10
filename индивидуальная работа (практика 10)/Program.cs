using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace индивидуальная_работа__практика_10_
{
    internal class Program
    {
        static int[,] Input()
        {
            int[,] mas = new int[1, 1];
            try
            {
                Console.Write("Введите кол-во строк: ");
                int m = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (m > 0) break;
                    else
                    {
                        Console.Write("Введите кол-во строк: ");
                        m = int.Parse(Console.ReadLine());
                    }
                }
                Console.Write("Введите кол-во столбцов: ");
                int n = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (n > 0) break;
                    else
                    {
                        Console.Write("Введите кол-во столбцов: ");
                        n = int.Parse(Console.ReadLine());
                    }
                }
                mas = new int[m, n];
            }
            catch 
            {
                Console.WriteLine("Возникла ошибка!");

            } 
            return mas;
        }
        static void Output(int[,] mas)
        { 
            Random r = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = r.Next(-20, 20);
                    Console.Write($"{mas[i,j],3}  ");
                }
                Console.WriteLine();
            }
        }
        static void Zad_1(int[,] mas)
        {

            try
            {
                Console.Write("Введите число А: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите число Б: ");
                int b = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i, j] >= a && mas[i, j] <= b)
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine($"Кол-во эле-тов которые поподают в диапозон от {a} до {b}: {count}");
            }
            catch
            {
                Console.WriteLine("Возникла ошибка!");
            }
        }
        static void Zad_2(int[,] mas)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i, j] % 2 != 0) sum += mas[i, j];
                    }
                }
                Console.WriteLine($"Сумма нечётных чисел = {sum}");
            }
            catch
            {
                Console.WriteLine("Возникла ошибка!");
            }
        }
        static void Main(string[] args)
        {
            int[,] mas = Input();
            Output(mas);
            Zad_1(mas);
            Zad_2(mas);
        }
    }
}
