namespace Gradebook
{
    public class Statistics
    {
        public double Average 
        { 
            get
            {
                return Sum / Count;
            }  
        }
        public double Low;
        public double High;
        public char Grade
        {
            get
            {
                switch (Average)
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
        }
        public double Sum;
        public int Count;

        public Statistics()
        {
            Low = double.MaxValue;
            High = double.MinValue;
            Sum = 0.0;
            Count = 0;
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low=Math.Min(Low, number);
            High=Math.Max(High, number);
        }
    }
}