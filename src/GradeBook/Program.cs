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
            var stats = book.GetStatistics();
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            System.Console.WriteLine($"The highest grade was {stats.High}");
            System.Console.WriteLine($"The lowest grade was {stats.Low}");
            
        }
    }
}
