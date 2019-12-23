using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInvoice
{
    public class Invoice
    {
        // Auto implemented properties 
        public string PartNumber { get; set; }
        public string Description { get; set; }

        // Instance variables 
        public int quantity;
        public decimal pricePerItem; 

        // Constructor 
        public Invoice(string p, string d, int q, decimal ppi) {
            PartNumber = p;
            Description = d;
            Quantity = q;
            PricePerItem = ppi; 
        }

        // long form properties 
        public int Quantity
        {
            // Returns quantity for getter 
            get
            {
                return quantity; 
            }
            // If the passed value is negative ignore it 
            set
            {
                if (value > 0)
                {
                    quantity = value; 
                }
            }
        }

        public decimal PricePerItem
        {
            get
            {
                return pricePerItem; 
            }
            set
            {
                if (value > 0)
                {
                    pricePerItem = value; 
                }
            }

        }

        // Method to calculate invoice amount
        public decimal GetInvoiceAmount()
        {
            return Quantity * PricePerItem; 

        }
    }
}
