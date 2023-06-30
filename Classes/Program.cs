namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
            car.Make = "Toyota";
            car.Model = "Camy";
            car.Year = 2023;

            Console.WriteLine($"My car is {car.Make}");
            Console.WriteLine($" My car model is {car.Model}");
            Console.WriteLine($"My car year is {car.Year}");

        }
    }
}
