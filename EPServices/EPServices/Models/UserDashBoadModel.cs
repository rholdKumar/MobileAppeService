using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    public class UserDashBoadModel
    {
        public UserDueDetails userDueDetails { get; set; }

        public List<InvoiceFulldetails> paidAmountDetails { get; set; }

        public List<mUnitDetails> userUnits { get; set; }
        public List<mUnitDetails> newUnits { get; set; }
        public List<mServicesType> Services { get; set; }

       

    }
    public class UserDueDetails
    {
        public decimal? DueAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PaidAmount { get; set; }
    }
}
