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
            var book=new Book("");
            book.AddGrade(89.1);
            book.AddGrade(25.5);
            book.AddGrade(50.6);

            //act
            var result=book.GetStatistics();

            //assert
            Assert.Equal(55.1,result.Average,1);
            Assert.Equal(25.5,result.Low,1);
            Assert.Equal(89.1,result.High,1);
        }
    }
}
