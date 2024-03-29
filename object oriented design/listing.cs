﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_design
{
    public abstract class Listing
    {
        // As you complete each task make sure you test your code carefully
        // Choose some combination of manual testing, Debug.Assert and unit tests

        // Task One        
        // The bank account should have a balance property        
        // It should have a constructor that sets the initial balance (default zero) and the opening date (default today)
        // It should have methods to deposit and withdraw/make payments from the account. 

        //Fields
        int productID;
        string productName;
        double price;
        string description;
        int quantity;
        double discount;
        bool activeStatus;
        DateTime? dateSold;

        //Constructor
        public Listing(bool activestatus, DateTime? datesold)
        {
            productID = 0;
            productName = string.Empty; 
            price = 0;
            description = string.Empty;
            quantity = 0;
            discount = 0;
            activeStatus = activestatus;
            if (!activeStatus)
            {
                dateSold = datesold;
            }
        }

        //Properties
        private int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        //Methods
        public void Bought()
        {
            quantity--;
        }
        private double ApplyDiscount()
        {
            price *= 1 - discount;
            return price;
        }
        public abstract bool CanShowListing();
    }
}
