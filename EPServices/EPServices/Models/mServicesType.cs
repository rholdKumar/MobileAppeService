using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    public class mServicesType
    {
        public int SID { get; set; }
      
        public string ServiceGroupName { get; set; }

       
        public string ServiceName { get; set; }
      
        public decimal Amount { get; set; }
      
        public int Duration { get; set; }
      
        public DateTime Created_on { get; set; }

        public int Created_by { get; set; }
      
        public int PID { get; set; }
       
        public string PropertyName { get; set; }
       
        public string PropertyType { get; set; }
      
        public int PropertyTypeId { get; set; }
        
        // public decimal PerYearAmount { get; set; }
        private decimal _PerYearAmount;
       
        public decimal PerYearAmount
        {
            get
            {
                return Amount * 12;
            }
            set
            {
                _PerYearAmount = value;
            }
        }
    }
}
