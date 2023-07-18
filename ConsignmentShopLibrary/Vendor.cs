using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        //Adding set of properties (shortcut prop + tab twice)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }

        public decimal PaymentDue { get; set; }

        public string DisplayVendor
        {
            get
            {
                return string.Format("{0} {1} - {2}",FirstName, LastName, PaymentDue);
            }
        }

        //default commission using a constructor(ctor + tab twice)
        public Vendor()
        {
            Commission = 0.5;
        }
        
       
    }

}
