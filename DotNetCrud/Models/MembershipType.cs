using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetCrud.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public double SignupFee { get; set; }
        public int DurationInMonths { get; set; }
        public decimal DiscountRate { get; set; }
    }
}