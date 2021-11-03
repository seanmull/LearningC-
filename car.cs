using System;

namespace LearningC_
{
    public class car
    {
        public String Make;
        public String Model;
        public int Year;

        public car(String make, String model, int year){
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public void drive(){
           Console.WriteLine("This make is driving fast");
        }

        // public static void Main(string[] args)
        // {
        //     car Car = new car("Volvo", "Golf", 2007);
        //     Console.WriteLine(Car.Year);
        //     Car.drive();
        //     Console.WriteLine(Car);
        // }

        public void toString(){
            Console.WriteLine(Make);
        }
    }
}