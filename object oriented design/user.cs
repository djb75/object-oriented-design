using CSharpObjectIntro.Classes.BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_design
{
    public class User   //Association
    {
        // As you complete each task make sure you test your code carefully
        // Choose some combination of manual testing, Debug.Assert and unit tests

        // Task One        
        // The bank account should have a balance property        
        // It should have a constructor that sets the initial balance (default zero) and the opening date (default today)
        // It should have methods to deposit and withdraw/make payments from the account. 

        //Fields
        string username;
        string password;
        int cardNum;
        int cardCVV;
        DateOnly cardExp;
        DateTime dateOpened;
        int numOrders;
        List<Listing> orders;

        //Constructor
        public User()
        {
            username = string.Empty;
            password = string.Empty;
            cardNum = 0;
            cardCVV = 0;
            cardExp = new DateOnly();
            dateOpened = new DateTime();
            numOrders = 0;
            orders = new List<Listing>();
        }

        //Properties

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        private string Password
        {
            get { return password; }
            set { password = value; }
        }
        private int CardNum
        {
            get { return cardNum; }
            set { CardNum = value; }
        }
        private int CardCVV
        {
            get { return cardCVV; }
            set { CardCVV = value; }
        }
        private DateTime DateOpened
        {
            get { return dateOpened; }
            set { dateOpened = value; }
        }

        public int NumOrders
        {
            get { return numOrders; }
            set { numOrders = value; }
        }

        private List<Listing> Orders 
        { 
            get { return orders; } 
            set { orders = value; }
        }

        //Methods
        public void AddOrder(Listing order)
        {
            numOrders++;
            orders.Add(order);
        }
        public void ChangePassword(string newPassword)
        {
            password = newPassword;
        }
    }
}
