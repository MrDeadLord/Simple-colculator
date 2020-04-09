using System;

namespace ConsoleApp
{
    class ConsoleApp
    {
        static void Main()
        {
            var op = new Operation();

            while (true)
            {
                var sign = op.Sign();

                string input;   //Вводимое поьзователем число
                int a;      //Для определения является ли введенное число числом.

                do
                {
                    Console.WriteLine("Введите число А:");
                    input = (Console.ReadLine());
                    if (int.TryParse(input, out a))
                    {
                        break;
                    }
                } while (!int.TryParse(input, out a));     //Ввод чила А, пока оно не будет числом

                int b;    //Для определения является ли введенное число числом.
                do
                {
                    Console.WriteLine("Введите число B:");
                    input = (Console.ReadLine());
                    if (int.TryParse(input, out b))
                    {
                        break;
                    }
                } while (!int.TryParse(input, out b));     //Ввод чила В, пока оно не будет числом

                switch (sign)
                {
                    case "+":
                        op.Plus(a, b);
                        break;
                    case "-":
                        op.Minus(a, b);
                        break;
                    case "*":
                        op.Multiply(a, b);
                        break;
                    default:
                        op.Division(a, b);
                        break;
                }

                Console.WriteLine("Exit? y/n...");
                input = Console.ReadLine();
                if (input == "y")
                {
                    Console.ReadKey();
                    break;
                }

                Console.Clear();
            }
        }
    }
}
