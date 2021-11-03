using System;

namespace LearningC_
{
    public class Calculator
    {
        // public static int add(int[] values){
        //     int sum = 0; 
        //     for(int i = 0; i < values.Length; i++)
        //     {
        //         sum += values[i];
        //     }
        //     return sum;

        // }

         public static int add(params int[] values){
            int sum = 0; 
            foreach(var value in values)
            {
                sum += value;
            }
            return sum;

        }


        // public static void Main(string[] args){
        //     int[] nums = {1,2,3};
        //     Console.WriteLine(add(1,2,3,4,54));
        // }
    }
}