using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Chester's Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(66.5);
            book.ShowStatistics();
            
            if(args.Length > 0)
            {
              Console.WriteLine($"Hello {args[0]}! Welcome to the world of C#.");
              
            }
            else 
            {
              Console.WriteLine("Hello, hacker! Welcome to dotnet!");
            }
            
        }
    }
}
