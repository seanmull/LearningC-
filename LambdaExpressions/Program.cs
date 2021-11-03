using System;

namespace LearningC_.LambdaExpressions
{
    public class Program
    {
        // static void Main(string[] args)
        // {
        //     var books  = new BookRepository().GetBooks();


        //     var cheapBooks = books.FindAll(book => book.Price < 10);
            
        //     // var cheapbooks = 
        //     // books.findall(ischeaperthen10dollars);
        //     foreach(var book in books)
        //     {
        //         System.Console.WriteLine(book.Title);
        //     }
        //     // // System.Console.WriteLine(number => number * number);
        //     // // Func<int, int> square = number => number * number;

        //     // // () => ....
        //     // // x => ...
        //     // //(x,y,...) => ..
            
        //     // // System.Console.WriteLine(square(4));
        //     // const int factor = 5;

        //     // Func<int, int> mulitiplier = n => n * factor;
            
        //     // System.Console.WriteLine(mulitiplier(10));
        // }

        static bool IsCheaperThen10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}