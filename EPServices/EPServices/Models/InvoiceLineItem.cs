using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
   
    public class InvoiceLineItem
    {
        
        public int LineItemID { get; set; }

        public int ServicesTypeID { get; set; }


        public decimal Amount { get; set; }

        public int Duration { get; set; }

        public string ServiceName { get; set; }
        public int InvoiceID { get; set; }

        public decimal TotalAmount { get; set; }

      
        public int PID { get; set; }
        public string PropertyName { get; set; }

        public int UID { get; set; }
        public string UnitName { get; set; }

        public int Created_by { get; set; }
       
        public DateTime? Created_on { get; set; }

        public int Year { get; set; }

        public string LineItemGroupId { get; set; }

       
    }
}
