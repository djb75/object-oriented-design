using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_design
{
    public class SiteInventory    //Aggregation
    {
        // As you complete each task make sure you test your code carefully
        // Choose some combination of manual testing, Debug.Assert and unit tests

        // Task One        
        // The bank account should have a balance property        
        // It should have a constructor that sets the initial balance (default zero) and the opening date (default today)
        // It should have methods to deposit and withdraw/make payments from the account. 

        //Fields
        List<Listing> activelistings;
        List<ListingArchive> pastlistings;
        int numactivelistings;
        int numpastlistings;

        //Constructor
        public SiteInventory()
        {
            activelistings = new List<Listing>();
            pastlistings = new List<ListingArchive>();
            numpastlistings = 0;
            numactivelistings = 0;
        }

        //Properties
        public List<Listing> Listings 
        { 
            get { return activelistings; }
            set { activelistings = value; }
        }
        private List<ListingArchive> PastListings
        {
            get { return pastlistings; }
            set { pastlistings = value; }
        }
        public int NumActiveListings
        {
            get { return numactivelistings; }
            set { numactivelistings = value;}
        }

        public int NumPastListings
        {
            get { return numpastlistings; }
            set { numpastlistings = value;}
        }

        //Methods
        public void Bought(Listing item)
        {
            throw new NotImplementedException();
            //Takes attributes from active Listing and creates a new ListingArchive adding DateTime.Now() as the date bought and the user
            //Removes the Listing from activelistings and adds the archive to pastlistings
        }

        public void AddListing(Listing item)
        {
            throw new NotImplementedException();
            //Adds Listing to activelistings
        }

        public void DisplayListings()
        {
            throw new NotImplementedException();
            //Displays all listings
        }
    }
}
