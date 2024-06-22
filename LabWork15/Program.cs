namespace LabWork15
{
    delegate int Operation(int x);

    internal class Program
    {
        static int Square(int x)
        {
            return x * x;
        }

        static int Factorial(int x)
        {
            int a = 1;
            if (x == 0) 
                return 1;
            for (int i = 1; i <= x; i++)
            {
                a *= i;
            }
            return a;
        }

        static int Absolute(int x)
        {
            if (x<0)
                return -x;
            return x;
        }

        static void Main(string[] args)
        {
            int number = -5;

            Operation Operation = Square;
            Console.WriteLine("Квадрат: {1}", number, Operation(number));

            Operation = Factorial;
            Console.WriteLine("Факториал: {1}", number, Operation(number));

            Operation = Absolute;
            Console.WriteLine("Модуль: {1}", number, Operation(number));
        }
    }
}
