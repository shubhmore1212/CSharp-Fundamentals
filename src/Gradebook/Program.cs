using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book=new Book("John Grade Book");
            book.AddGrade(20.2);
            book.AddGrade(12.2);
            book.AddGrade(30.2);
            book.AddGrade(40.2);

            book.PrintGrades();
            book.ShowStatistics();
            //Console.ReadLine();
        }
    }
}
