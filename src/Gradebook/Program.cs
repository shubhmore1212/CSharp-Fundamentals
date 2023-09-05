using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("John Grade Book");
            
            do
            {
                Console.WriteLine("Enter Grade or 'q' to quit: ");
                string? grade = Console.ReadLine();

                if (grade == "q")
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

            book.ShowStatistics();
            //Console.ReadLine();
        }
    }
}
