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
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades){
              highGrade = Math.Max(number, highGrade);
              lowGrade = Math.Min(number, lowGrade);
              result += number;
            }
            Console.WriteLine($"The average grade is { result / grades.Count:N2}");
            System.Console.WriteLine($"The highest grade was {highGrade}");
            System.Console.WriteLine($"The lowest grade was {lowGrade}");
            
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
