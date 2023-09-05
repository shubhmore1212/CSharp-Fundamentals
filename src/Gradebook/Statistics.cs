namespace Gradebook
{
    public class Statistics
    {
        public double Average; 
        public double Low; 
        public double High;
        public char Grade;

        public Statistics(double Average,double Low,double High,char Grade)
        {
            this.Average = Average;
            this.Low = Low;
            this.High = High;
            this.Grade = Grade;
        }
    }
}