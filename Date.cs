namespace NovertisPharms
{
    public class Date
    {
        private int day;
        private int month;
        private int Year { get; set; }

        public Date(int theDay,int theMonth,int theYear)
        {
            Day = theDay;
            Month = theMonth;
            Year = theYear;
           
        }

        public int Month
        {
            get { return month; }
            private set
            {
                if((value > 0) && (value <= 12))
                {
                    month = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Out of range");
                }
            }
        }

        public int Day
        {
            get { return day; }
            set
            {
                day = value;
            }
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}