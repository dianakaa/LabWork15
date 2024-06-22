namespace Task_2
{
    delegate void Operation(int a, int b);
    internal class Program
    {
        static void Sum(int a, int b)
        {
            Console.WriteLine($"Сумма {a + b}");
        }

        static void Difference(int a, int b)
        {
            Console.WriteLine($"Разность {a - b}");
        }

        static void Multiplication(int a, int b)
        {
            Console.WriteLine($"Произведение {a * b}");
        }

        static void Division(int a, int b)
        {
            if (b != 0)
                Console.WriteLine($"Частное {a / b}");
            else
                Console.WriteLine("На 0 делить нельзя");
        }

        static void Main(string[] args)
        {
            Operation operation = new Operation(Sum);
            operation += Difference;
            operation += Multiplication;
            operation += Division;
            operation(10, 0);
        }
    }
}
