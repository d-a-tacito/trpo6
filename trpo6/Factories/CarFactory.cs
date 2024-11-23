using trpo6.Cars;

namespace trpo6.Factories;
public class CarFactory
{
    public ICar CreateCar(string carType)
    {
        switch (carType.ToLower())
        {
            case "sedan":
                return new Sedan();
            case "suv":
                return new SUV();
            case "truck":
                return new Truck();
            default:
                return null;
        }
    }
}
