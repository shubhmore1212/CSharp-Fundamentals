namespace Gradebook
{
    public class Statistics
    {
        public double Average; 
        public double Low; 
        public double High;

        public Statistics(double Average,double Low,double High)
        {
            this.Average = Average;
            this.Low = Low;
            this.High = High;
        }
    }
}