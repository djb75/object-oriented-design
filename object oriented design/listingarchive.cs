﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_design
{
    public class ListingArchive : Listing //Inheritance
    {
        public ListingArchive() : base(false, DateTime.Now) { }
        //Methods
        public override bool CanShowListing()
        {
            return false;
        }
    }
}
