using System;

namespace ConsoleApp
{
    class Operation
    {
        public string Sign()
        {
            string sign;

            do
            {
                Console.WriteLine("Введите знак операции(+, -, *, /):");
                sign = Console.ReadLine();

                if (sign != "+" && sign != "-" && sign != "*" && sign != "/")
                {
                    Console.WriteLine("Unknown sumbol(s) :(");
                }
                else
                {
                    Console.WriteLine("You entered: " + sign);
                    break;
                }
            } while (sign != "+" || sign != "-" || sign != "*" || sign != "/");  //Проверка верности введенного знака

            return sign;
        }

        public void Plus(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("------------------");
            Console.WriteLine("A + B = " + result);

        }

        public void Minus(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("------------------");
            Console.WriteLine("A - B = " + result);
        }

        public void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("------------------");
            Console.WriteLine("A * B = " + result);
        }

        public void Division(int a, int b)
        {
            float result = a / b;
            Console.WriteLine("------------------");
            Console.WriteLine("A / B = " + result);
        }
    }
}
