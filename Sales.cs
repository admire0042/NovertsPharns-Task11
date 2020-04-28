using System;

namespace NovertisPharms
{
    public class Sales
    {
        public string MedCode { get; set; }
        private int quantSold;
        private decimal plannedSales;
        private decimal actualSales;
        public string Region { get; set; }

        public Sales(string medcode, int quantSo, decimal planS, decimal actualS, string region)
        {
            MedCode = medcode;
            QuantSold = quantSo;
            PlannedSales = planS;
            ActualSales = actualS;
            Region = region;
        }

        public int QuantSold
        {
            get{ return quantSold; }

            private set{
                if(value > 0)
                {
                    quantSold = value;
                }
            }
        }

         public decimal PlannedSales
        {
            get{ return plannedSales; }

            private set{
                if(value > 0)
                {
                    plannedSales = value;
                }
            }
        }

         public decimal ActualSales
        {
            get{ return actualSales; }

            private set{
                if(value > 0)
                {
                    actualSales = value;
                }
            }
        }


        

        public string Display()
        {
            return $"Medicine code: {MedCode}\nQuantity Sold: {QuantSold}\nPlanned Sales: {PlannedSales}\nActual Sales: {ActualSales}\nRegion: {Region}";
        }

        public string Display(string code)
        {
            decimal variance = ActualSales - PlannedSales;
            if(ActualSales > PlannedSales)
            {
                    
                 Console.WriteLine($"The pharmaceutical company sells above plan, the variance is:");

            }else if(PlannedSales > ActualSales)
            {
                
                 Console.WriteLine($"The Pharmaceutical company could not meet up with expectation in sales, the variance is:");

            }else if(ActualSales == PlannedSales)
            {
                 Console.WriteLine($"The Pharmaceutical company breaks even, the variance is:");
            }
            return $"{variance}";
        }
    }
}