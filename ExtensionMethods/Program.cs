using System;
using System.Linq;

namespace LearningC_.ExtensionMethods
{
    // public class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         string post = "sadfsa sdff sdfasdf sdfadf  asdfsa  asdfsaf  sdfsaf asdfsdaf";
    //         var shortenedPost = post.Shorten(5);

    //         System.Console.WriteLine(shortenedPost);
    //     }


    // }

    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of word should be greater then 0");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}