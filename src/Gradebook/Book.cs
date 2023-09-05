using System;

namespace Gradebook
{
    public class Book
    {
        private List<double> grades;
        public string Name;
        
        public Book(string name)
        {
            grades=new List<double>();
            this.Name=name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
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

        public Statistics GetStatistics()
        {
            return new Statistics(Average:GetAverageGrades(),
                Low: GetMinGrade(),
                High: GetMaxGrade());
        }

        public void ShowStatistics()
        {
            var result=GetStatistics();
            Console.WriteLine($"Highest Grade: {result.High} \nLowest Grade: {result.Low}");
            Console.WriteLine($"Average of Gardes is {result.Average}");
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