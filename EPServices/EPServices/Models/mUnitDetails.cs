using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    public class mUnitDetails
    {
        public int UID { get; set; }
        public string UnitName { get; set; }
        public string BloackName { get; set; }
        public string UnitAreaType { get; set; }

        public string UnitNumber { get; set; }
        public int UnitTypeID { get; set; }
        public string UnitType { get; set; }
        public decimal UnitArea { get; set; }
        public int NO_BadRooms { get; set; }
        public int NO_LivingRoom { get; set; }

       
        public int Balcony { get; set; }

      
        public int PTID { get; set; }

      
        public string PropertyName { get; set; }

        public int Created_by { get; set; }
     
        public DateTime Created_on { get; set; }

      
        public int OwnerId { get; set; }


        public string OwnerName { get; set; }
       
        public string UnitDescription { get; set; }

        public bool Status { get; set; }
    }
}
