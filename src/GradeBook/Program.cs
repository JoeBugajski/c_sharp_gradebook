using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
    {
        static void Main(string[] args)
        {

            var book2 = new Book("Scooter's Book");
            book2.AddGrade(90.1);

            var book = new Book("Chester's Book");
            book.AddGrade(89.1);

            var grades = new List<double>() { 12.3, 44.6, 83.456, 44, 623.444, 9.0000002343 };
            grades.Add(69);

            var result = 0.0;            
            foreach(var number in grades){
              result += number;
            }
            
            if(args.Length > 0)
            {
              Console.WriteLine($"Hello {args[0]}! Welcome to the world of C#. The average grade is {result / grades.Count:N2}");
              
            }
            else 
            {
              Console.WriteLine("Hello, hacker! Welcome to dotnet!");
            }
            
        }
    }
}
