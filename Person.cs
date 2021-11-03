using System;
using static LearningC_.ClassBasics;

namespace LearningC_
{
    public class ClassBasics
    {
        public class Person
        {
            public string Name { get; set; }
            //private byte Age;
            private float Height;
            private byte Weight;

            public int Age
            {
                get{ 
                    var timeSpan = DateTime.Today - Birthdate;
                    var years = timeSpan.Days/365;

                    return years;
                }
            }           
            
            //private DateTime _birthdate;

            //public byte getSetAge { get => Age; set => Age = value; }
            //public DateTime Birthdate { get => _birthdate; set => _birthdate = value; }
            //compiles assuming private field with getter and setter.
            public DateTime Birthdate {get; private set;}

            Person(string name,
                   float height,
                   byte weight)
            {
                this.Name = name;
                //this.Age = age;
                this.Height = height;
                this.Weight = weight;
            }

            public Person()
            {

            }

            public Person(DateTime birthdate){

                Birthdate = birthdate;
            }


            public void walk()
            {
                System.Console.WriteLine("{0} is walking.", Name);
            }



        }
    }


    class Program2
    {
        // public static void Main(string[] args)
        // {
        //     //var p = new Person("Sean", 42, 232, 6);
        //     var p = new Person( new DateTime(1982, 1, 1));
        //     System.Console.WriteLine(p.Age);
            
        //     //p.walk();
        // }
    }
}