using System;

namespace exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divide A by B");

            do
            {
                // TODO: Write try-catch-finally for Run();

                Run();
                
                Console.WriteLine("Do you want to try again? [Enter]");

            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        static void Run()
        {
            Console.WriteLine("--------------");
            // Input
            Console.Write("Enter A: ");
            var numberA = int.Parse(Console.ReadLine());

            Console.Write("Enter B: ");
            var numberB = int.Parse(Console.ReadLine());

            // Calculate
            var result = Divide(numberA, numberB);

            // Output result
            Console.WriteLine();
            Console.WriteLine($"Result: {numberA} / {numberB} = {result}");
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
