using Interfaces2.Entities;
using System;
using System.Globalization;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, value);

            Console.Write("Enter the number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            contract.Installments(installments);

            Console.WriteLine("Installments:");
            foreach (Installment x in contract._installment)
            {
                Console.WriteLine(x);
            }
        }
    }
}
