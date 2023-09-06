using System;
using Xunit;
using Gradebook;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateStatsGrade()
        {
            //arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(95.5);
            book.AddGrade(50.6);

            //act
            var result=book.GetStatistics();

            //assert
            Assert.Equal(78.4,result.Average,1);
            Assert.Equal(50.6,result.Low,1);
            Assert.Equal(95.5,result.High,1);
            Assert.Equal('C', result.Grade);
        }
    }
}
