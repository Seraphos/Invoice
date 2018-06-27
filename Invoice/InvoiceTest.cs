using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {

            decimal pricePerItem, invoiceAmount;
            int quantity;

            Console.WriteLine("Please enter the price per item: ");
            pricePerItem = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the quantity requested by the customer: ");
            quantity = Convert.ToInt32(Console.ReadLine());


            //instantiate invoice object
            Invoice myInvoice = new Invoice("Super Charged Cog", quantity, pricePerItem, "4H12345");
            //use get invoice amount method
            invoiceAmount = myInvoice.GetInvoiceAmount(pricePerItem, quantity);
            Console.WriteLine("The description is: {0}\nThe number ordered is: {1}\nThe price per item is: {2:C}\nThe item part number is: {3}",
                myInvoice.PartDescription, myInvoice.ItemQuantity, myInvoice.PricePerItem, myInvoice.PartNumber);
            Console.WriteLine("The total invoice amount is: {0:C}", invoiceAmount);
            Console.ReadKey();



        }
    }
}
