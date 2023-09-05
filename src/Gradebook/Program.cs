using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book=new Book("John Grade Book");
            
            do
            {
                Console.WriteLine("Enter Grade or 'q' to quit: ");
                string grade = Console.ReadLine();

                if (grade == "q")
                {
                    break;
                }

                book.AddGrade(double.Parse(grade));
            } while (true);

            book.ShowStatistics();
            //Console.ReadLine();
        }
    }
}
