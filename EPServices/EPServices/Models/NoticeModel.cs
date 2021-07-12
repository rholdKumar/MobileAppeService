using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    
    public class NoticeInfoModel
    {
       
        public int NoticeId { get; set; }

        public int UnitId { get; set; }
        public int PID { get; set; }

        public int Status { get; set; }

        
        public string UnitName { get; set; }

        
        public string UnitAreaType { get; set; }

        
        public string UnitType { get; set; }
      
        public decimal UnitArea { get; set; }

       
        public string PropertyName { get; set; }
        public int Created_by { get; set; }
        public DateTime Created_on { get; set; }

        public int OwnerId { get; set; }

        
        public string OwnerName { get; set; }

        public decimal PSAmount { get; set; }

        public decimal TotalAmount { get; set; }

        public int Year { get; set; }

        public decimal PaidAmount { get; set; }
        public decimal? TotalPaidAmount { get; set; }
        public string NoticeNumber { get; set; }

        public DateTime DueDate { get; set; }
        public string NGroupID { get; set; }

        public string InvoiceNumber { get; set; }
       
        public bool Selected { get; set; }
        public int eMailStatus { get; set; } = 0;
    }
}
