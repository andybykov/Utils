/*Лабораторная работа 4.  Упражнение 1,2, 3 */
namespace Utils
{
    using System;

    public class Utils
    {

        //Метод сравнения двух чисел и вывод бОльшего
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        //Метод обмена двух переменных
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Метод рассчета факториала
        // возвращает резульат

        public static bool Factorial(int n, out int answer)
        {
            int k; // Loop counter 
            int f; // Working value 
            bool ok = true; // True if okay, false if not 

            // Проверям положительное ли входное значение 
            if (n < 0)
                ok = false;

            // Вычисляет факториал как
            // произведение всех чисел от 2 до n

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception) // Проверка на переполнение переменной
            {
                f = 0;
                ok = false;
            }
            answer = f;

            return ok;
        }
    }
    }
