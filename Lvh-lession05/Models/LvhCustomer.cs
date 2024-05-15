using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lvh_lession05.Models
{
    public class LvhCustomer
    {
        public int CustomerId { get; set; }
        public String FirtName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public int YearOfBỉth { get; set; }
        public int YearOfBirth { get; internal set; }
    }
}