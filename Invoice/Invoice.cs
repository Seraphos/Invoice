using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Invoice
    {
        private string partNumber, partDescription;
        private decimal pricePerItem;
        private int itemQuantity;

        //constructor
        public Invoice(string constructorPartDescription, int constructorItemQuantity, decimal constructorPricePerItem, string constructorPartNumber)
        {
            partDescription = constructorPartDescription;
            itemQuantity = constructorItemQuantity;
            pricePerItem = constructorPricePerItem;
            partNumber = constructorPartNumber;
        }//end constructor


        public string PartNumber
        {
            get { return partNumber; }//end part number get
            set { partNumber = value; }//end part number set
        }//end part number property
        public string PartDescription
        {
            get { return partDescription; }//end partDesc Property
            set { partDescription = value; }//end partDesc Property 
        }//end PartDesc property
        public decimal PricePerItem
        {
            get { return pricePerItem; }//end PPI get
            set
            {
                if (pricePerItem > 0) pricePerItem = value;
                if (pricePerItem <= 0) throw new ArgumentOutOfRangeException("Only non-zero positive numbers are allowed.");
            }//end PPI set
        }//end PPI property
        public int ItemQuantity
        {
            get { return itemQuantity; }//end IQ get
            set
            {
                if (itemQuantity > 0) itemQuantity = value;
                if (itemQuantity <= 0) throw new ArgumentOutOfRangeException("Only non-zero positive numbers are allowed.");
            }//end IQ set
        }//end IQ property

        public decimal GetInvoiceAmount(decimal pricePerItem, int itemQuantity)
        {
            decimal product;
            product = pricePerItem * Convert.ToDecimal(itemQuantity);
            return product;
        }//end get invoice amount method


    }//end class
}//end namespace
