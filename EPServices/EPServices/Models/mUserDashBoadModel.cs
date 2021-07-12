using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    public class mUserDashBoadModel
    {
        public UserDueDetails userDueDetails { get; set; }
        public List<InvoiceFulldetails> paidAmountDetails { get; set; }
        public List<mUnitDetails> userUnits { get; set; }
        public List<mUnitDetails> newUnits { get; set; }
        public List<mServicesType> Services { get; set; }

    }
}
