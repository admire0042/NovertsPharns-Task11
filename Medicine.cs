using System;

namespace NovertisPharms
{
    public class Medicine
    {
        public string MedCode {get; set;}
        private string MedName {get; set;}
        private string ManuName {get; set;}
        private decimal price;
        private int quantity;
        public Date Manufacture {get; set;}
        public Date Expiry { get; set; }
        private string BatchNo { get; set; }


        public Medicine(string medCo, string medNa, string manuNa, decimal pric, int quant, Date manuDa, Date expDat, string batchN)
        {
            MedCode = medCo;
            MedName = medNa;
            ManuName = manuNa;
            Price = pric;
            Quantity = quant;
            Manufacture = manuDa;
            Expiry = expDat;
            BatchNo = batchN;
        }

        public decimal Price
        {
            get{ return price; }
            
            private set
            {
                if(value > 0)
                {
                    price = value;
                }
            }

        }

         public int Quantity
        {
            get{ return quantity; }
            
            private set
            {
                if(value > 0)
                {
                    quantity = value;
                }
            }

        }

        public string Print()
        {
            return $"Name of Medicine: {MedName}\nMedicine Code: {MedCode}\nManufacturer Name: {ManuName}\nPrice: {Price}\nQuantity: {Quantity}\nManufacturer Date: {Manufacture}\nExpiry Date: {Expiry}\nBatch Number: {BatchNo}";
        }

        public string Print(string Code)
        {
            return $"The quantity in stock for code {Code} is: {Quantity}";
        }

        public string Print(string code, string name)
        {
            return $"For medicine with code {code} and with name {name} :\nThe Expiry date is {Expiry} and the Manufacturing date is {Manufacture} ";
        }

        public string Increement()
        {
            int order = 0;
            if(Quantity == 0)
            {
                order += Quantity + 50;
            }
            return $"{order}";
        }
    }
}