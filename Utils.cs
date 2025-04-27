/*Лабораторная работа 4.  Упражнение 1,2 */
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
    }
}
