using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPServices.Models
{
    public class mOwnerData
    {
        public mOwnerDetails ownerDetails { get; set; }
        public List<mUnitDetails> UnitDetails { get; set; }
    }
}
