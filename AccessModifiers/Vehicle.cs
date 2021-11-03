namespace LearningC_.AccessModifiers
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle()
        {
            System.Console.WriteLine("Vechicle is being initalized.");

        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            System.Console.WriteLine("Vechicle is being initialized. {0}", registrationNumber);
        }
    }

    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            System.Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }

        // public static void Main(string[] args)
        // {
        //     var car = new Car("s;akfjd;a");
        // }
    }


}