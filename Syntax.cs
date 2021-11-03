using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningC_
{
    public class Syntax
    {
        public List<int> list
        {
            get;
            set;
        }
        // public static void Main(string[] args)
        // {
        //     //string methods
        //     string str = " Roses are red, violets are blues, YOU SUCK!!";

        //     System.Console.WriteLine($"String is currently the following: {str}");

        //     System.Console.WriteLine($"String is now uppercase: {str.ToUpper()}");

        //     System.Console.WriteLine($"String is now lowercase: {str.ToLower()}");

        //     System.Console.WriteLine($"Does string contain d? {str.Contains('d')}");

        //     System.Console.WriteLine($"Replace Roses with Lilies: {str.Replace("Roses", "Lilies")}");

        //     System.Console.WriteLine($"Grab just Roses in the string: {str.Substring(1, 5)}");

        //     System.Console.WriteLine($"String has the following length: {str.Length}");

        //     System.Console.WriteLine($"String is now trimmed of whitespace on both sides: {str.Trim()}");

        //     System.Console.WriteLine($"Give me the first index occurance of a: {str.IndexOf('a')}");

        //     System.Console.WriteLine($"Does string start with _Roses? : {str.StartsWith(" Roses")}");

        //     System.Console.WriteLine($"Give me the second index value of the string: {str[2]}");

        //     var stringBuilder = new StringBuilder();

        //     stringBuilder.Append("init the string builder");

        //     System.Console.WriteLine($"StringBuilder is the following lenght: {stringBuilder.Length}");

        //     System.Console.WriteLine($"StringBuilder has the following capacity: {stringBuilder.Capacity}");

        //     //array methods

        //     var arr = new int[0];

        //     var arr1 = new int[1] { 1 };

        //     var charArrayFromStr = str.ToCharArray();

        //     System.Console.WriteLine("The new array from string converted to chars is: ");

        //     foreach (char c in charArrayFromStr) System.Console.Write(c + " ");

        //     System.Console.WriteLine();

        //     System.Console.WriteLine("The new array from string converted to integers is:");

        //     byte[] ASCIIValues = Encoding.ASCII.GetBytes(str);

        //     foreach (byte b in ASCIIValues) System.Console.Write(b + " ");

        //     System.Console.WriteLine($"Is the value 101 in the array? : {Array.Exists(ASCIIValues, val => val == 101)}");

        //     System.Console.WriteLine($"Where is the index position of 101? : {Array.IndexOf(ASCIIValues, 101)}");

        //     //Collections

        //     //Lists

        //     var list = new List<int>() { 1, 16, 3, 8, 4, 5, 6, 7, 34 };

        //     System.Console.WriteLine($"Print the current list: {printList(list)}");

        //     System.Console.WriteLine($"Show the first index value: {list.First()}");

        //     System.Console.WriteLine($"Use aggregate function to add all values: {list.Aggregate((x, y) => x + y)}");

        //     System.Console.WriteLine($"Print just the numbers that greater then 4: {printList(list.Where(n => n > 4))}");

        //     System.Console.WriteLine($"Select all numbers with index less then 2: {printbool(list.Select(n => n < 2))}");

        //     System.Console.WriteLine($"Double all numbers: {printList(list.Select(n => n * 2))}");

        //     System.Console.WriteLine($"Order the numbers in ascending order: {printList(list.OrderBy(x => x))}");

        //     list.Reverse();

        //     System.Console.WriteLine($"Show the reversed printed order of list {printList(list)}");

        //     System.Console.WriteLine($"Are all numbers less then 50?: {list.TrueForAll(n => n < 50)}");

        //     //Dictionarys

        //     var dictionary = new Dictionary<int, StudentName>()
        //     {
        //         { 111, new StudentName { FirstName="Sachin", LastName="Karnik", ID=211 } },
        //         { 112, new StudentName { FirstName="Dina", LastName="Salimzianova", ID=317 } },
        //         { 113, new StudentName { FirstName="Andy", LastName="Ruth", ID=198 } }
        //     };

        //     System.Console.WriteLine("Current Dictionary");

        //     System.Console.WriteLine(printDictionary(dictionary)); 

        //     dictionary.Add( 131, new StudentName { FirstName="Sean", LastName="Mull", ID=342  });

        //     System.Console.WriteLine("Updated Dictionary");

        //     System.Console.WriteLine(printDictionary(dictionary)); 

        //     dictionary.Remove(111);

        //     System.Console.WriteLine("Update after Dictionary after remove");

        //     System.Console.WriteLine(printDictionary(dictionary)); 

        //     System.Console.WriteLine($"Is the item with 111 still in the dictionary? :{dictionary.ContainsKey(111)}");

        //     System.Console.WriteLine($"What is the average of the keys? : {dictionary.Average(n => n.Key) }"); 

        //     var dict2 = dictionary.OrderBy(n => n.Value.FirstName);
            
        //     //Stacks

        //     var stack = new Stack<int>();

        //     stack.Append(1);
        //     stack.Append(22);
        //     stack.Append(3);

        //     System.Console.WriteLine("Prints the current stack:");

        //     System.Console.WriteLine(stack.Pop());

        //     //Queues

        //     //Heaps

        //     //Trees


        // }

        public static string printList(IEnumerable<int> list)
        {
            string s = "";
            foreach (int item in list)
            {
                s += item + " ";
            }

            return s;

        }
        public static string printbool(IEnumerable<bool> list)
        {
            string s = "";
            foreach (bool item in list)
            {
                s += item + " ";
            }

            return s;

        }

        public static string printDictionary(Dictionary<int, StudentName> dict)
        {
           string s = "";
           foreach(var index in dict)
           {
               s += $"Key: {index.Key} First Name: {index.Value.FirstName} \n";
           } 
           return s;
        }

        
        public class StudentName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
        }
    }


}