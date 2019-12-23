using System;

namespace TestInvoice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Invoice invoice = new Invoice("A1234", "Keyboard", 10, 39.99m);
            invoice.pricePerItem = 110;

            Console.WriteLine($"" +
                $"Quantity: {invoice.Quantity}, " +
                $"Part Number: {invoice.PartNumber}, " +
                $"Description: {invoice.Description}. " +
                $"Total: ${invoice.GetInvoiceAmount()}");

        }
    }
}
