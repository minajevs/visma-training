using System;

namespace debug1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = {"green", "red", "yellow", "blue", "black"};

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
