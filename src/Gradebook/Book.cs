using System;

namespace Gradebook
{
    public class Book
    {
        private List<double> grades;
        public string Name { get; set; }

        public Book(string name)
        {
            grades=new List<double>();
            this.Name=name;
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(90);
                    break;

                case 'C':
                    AddGrade(90);
                    break;

                default:
                    Console.WriteLine("Grade must be between A to C");
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if(grade>=0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        private double GetAverageGrades()
        {
            return this.grades.Average();
        }

        private double GetMaxGrade()
        {
            double highGrade = double.MinValue;
            foreach(var grade in this.grades)
            {
                highGrade=Math.Max(highGrade, grade);
            }
            return highGrade;
        }

        private double GetMinGrade()
        {
            double lowGrade = double.MaxValue;
            foreach (var grade in this.grades)
            {
                lowGrade = Math.Min(lowGrade, grade);
            }
            return lowGrade;
        }

        private char GetGrade(double TotalMarks)
        {
            switch (TotalMarks)
            {
                case var m when m >= 90.0:
                    return 'A';

                case var m when m >= 80.0:
                    return 'B';

                case var m when m >= 70.0:
                    return 'C';

                case var m when m > 60.0:
                    return 'D';

                default:
                    return 'F';
            }
        }

        public Statistics GetStatistics()
        {
            return new Statistics(Average:GetAverageGrades(),
                Low: GetMinGrade(),
                High: GetMaxGrade(),
                Grade: GetGrade(GetAverageGrades()));
        }

        public void ShowStatistics()
        {
            var result=GetStatistics();
            Console.WriteLine($"Highest Grade: {result.High} \nLowest Grade: {result.Low}");
            Console.WriteLine($"Average of Grades is {result.Average}");
            Console.WriteLine($"The Grade is {result.Grade}");
        }

        public void PrintGrades()
        {
            foreach(var grade in grades)
            {
               Console.WriteLine(grade);
            }
        }
    }
}