using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
          // arrange
          var book = new Book("");
          book.AddGrade(89.1);
          book.AddGrade(90.5);
          book.AddGrade(77.3);

          // act
          var result = book.GetStatistics();

          // assert
          Assert.Equal(85.6, result.Average, 1); // The 1 indicates the degree
          Assert.Equal(90.5, result.High, 1);    // of accuracy our test needs to
          Assert.Equal(77.3, result.Low, 1);     // hit. This indicates 1 decimal point.
        }
    }
}
