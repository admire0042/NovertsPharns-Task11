using System;

namespace NovertisPharms
{
    class Program
    {
        static void Main(string[] args)
        {
            Date manufacturing = new Date(10,3,2019);
            Date expiry = new Date(10,3,2020);

            Medicine medicine = new Medicine("2345","Paracetamol","Paracetamol Company", 25.0m, 50, manufacturing, expiry, "765");

            Sales sales = new Sales("5789",25, 405.0m, 206.0m, "Egbeda");

            Console.WriteLine($"\nDetails For Medicine:\n\n{medicine.Print()}\n");

            Console.WriteLine($"{medicine.Print("2345")}");

            Console.WriteLine($"{medicine.Print("2345", "Paracetamol")}\n");

            Console.WriteLine($"Details For Sales:\n\n{sales.Display()}\n");

            Console.WriteLine(sales.Display("2345"));
        }
    }
}
