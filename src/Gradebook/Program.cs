using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("John Grade Book");

            EnterGrades(book);

            var result = book.GetStatistics();
            Console.WriteLine($"Highest Grade: {result.High} \nLowest Grade: {result.Low}");
            Console.WriteLine($"Average of Grades is {result.Average}");
            Console.WriteLine($"The Grade is {result.Grade}");
            Console.ReadLine();
        }

        private static void EnterGrades(IBook book)
        {
            do
            {
                Console.WriteLine("Enter Grade or 'q' to quit: ");
                string? grade = Console.ReadLine();

                if (grade == "q" || string.IsNullOrEmpty(grade))
                {
                    break;
                }

                try
                {
                    book.AddGrade(double.Parse(grade));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }
    }
}
