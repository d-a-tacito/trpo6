using trpo6.Cars;
using trpo6.Factories;

namespace trpo6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carFactory = new CarFactory();

            Console.WriteLine("Choose a car type to create (Sedan, SUV, Truck):");
            var carType = Console.ReadLine();

            var car = carFactory.CreateCar(carType);

            if (car != null)
            {
                Console.WriteLine($"Car created: {car.GetDescription()}");
            }
            else
            {
                Console.WriteLine("Unknown car type.");
            }
        }
    }
}