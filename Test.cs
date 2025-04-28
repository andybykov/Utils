namespace Utils
{
    using System;

    public class Test
    {
        public static void Main()
        {
            // Вводим числа
            Console.WriteLine("Enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = int.Parse(Console.ReadLine());

            // Проверка метода Greater( ) 
            int greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " +
            greater);


            // Проверка метода Swap 
            Console.WriteLine("Before swap: " + x + ", " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + ", " + y);

            {

                int factorizeResult; // Factorial result 
                bool ok; // Factorial success or failure 

                Console.WriteLine("Number for factorial:");
                int number = int.Parse(Console.ReadLine());


                // Проверка метода Factorial()
                ok = Utils.Factorial(number, out factorizeResult);
                // Вывод результатов
                if (ok)
                    Console.WriteLine("Factorial(" + number + ") = " + factorizeResult);
                else
                    Console.WriteLine("Cannot compute this factorial");
            }

        }

            
    }
}
