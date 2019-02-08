using System;

namespace exceptions6
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCar("Audi", 50, 120);
            CreateCar("BMW", 45, 150);
            CreateCar("Mazda", 300, 140);
            CreateCar("Volkswagen", -20, 200);

            Console.ReadKey();
        }

        static void CreateCar(string model, int speed, int maxSpeed)
        {
            try
            {
                var car = new Car(model, speed, maxSpeed);
                Console.WriteLine($"New {car.Model} created!");
            }
            catch (NegativeSpeedException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (GoingTooFastException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine($"Read more at: {exception.HelpLink}");
            }
        }
    }
}
