using CSharpObjectIntro.Classes.BankAccount;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_design
{
    internal class Receipt
    {
        //Fields
        Listing listing;
        DateTime dateBought;
        string address;

        //Constructor
        public Receipt()
        {
            listing = new Listing();
            timeBought = DateTime.Now;
            address = string.Empty;
        }

        //Properties
        public Listing ListingBought
        {
            get { return listing; }
            set { listing = value; }
        }

        public DateTime DateBought
        {
            get { return dateBought; }
            set { dateBought = value; }
        }
        private string Address
        {
            get { return address; }
            set { address = value; }
        }

        //Methods
        public void PrintReceipt()
        {
            //Prints a formatted receipt
        }
    }
}
