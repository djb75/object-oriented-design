using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_design
{
    public class ActiveListing : Listing  //Inheritance
    {
        public ActiveListing() : base(true, null) { }
        //Methods
        public override bool CanShowListing()
        {
            return false;
        }
    }
}
