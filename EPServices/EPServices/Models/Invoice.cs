using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    
    public class Invoices
    {
      
        public int InvoiceID { get; set; }
        public int NoticeId { get; set; }
        public string InvoiceNumber { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public string Frequency { get; set; }
        public DateTime DueDate { get; set; }
        public int PropertyID { get; set; }

        public string PropertyName { get; set; }
        public int UnitID { get; set; }
        public string UnitNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public int? PaymentID { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal? TotalPaidAmount { get; set; }
        public int PaymentStatusId { get; set; }
        public string PaymentStatus { get; set; }

        public string InvoiceStatus { get; set; }

        public int InvoiceStatusId { get; set; }

        public int UserServiceItems { get; set; }

       
        public DateTime Create_on { get; set; }

        public int Created_by { get; set; }
        public int OwnerID { get; set; }
        public string OwnerName { get; set; }
        public int InvoiceYear { get; set; }

        
        public DateTime Updated_on { get; set; }
        public int? Updated_by { get; set; }
     
        public decimal UnitArea { get; set; }

   
        public string TransactionNumber { get; set; }

        public string LineItemGroupId { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxAmount { get; set; }
        public int eMailStatus { get; set; } = 0;

        public DateTime? PaidOn { get; set; }
    }
}
