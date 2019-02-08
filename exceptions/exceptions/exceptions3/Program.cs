using System;

namespace exceptions3
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Foo();
            } catch (Exception ex) {
                Console.WriteLine("Caught in Main");
            }

            Console.ReadKey();
        }

        static void Foo()
        {
            try {
                Bar();
            } catch (Exception ex) {
                Console.WriteLine("Caught in Foo");
            }
        }

        static void Bar()
        {
            Divide(10, 0);
        }


        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
