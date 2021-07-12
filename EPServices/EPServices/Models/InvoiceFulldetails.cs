using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    public class InvoiceFulldetails
    {
        public int IPAID { get; set; }

        public int InvoiceID { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal PaidAmount { get; set; }

        public DateTime PaidDate { get; set; }

        public DateTime Created_On { get; set; }

        public int Created_by { get; set; }

        public string PaymentMothed { get; set; }

        public string PaymentStatus { get; set; }

        public int PaymentStatusId { get; set; }

        public int PropertyID { get; set; }

        public int UnitID { get; set; }

        public int InvoiceYear { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public string ChequeNumber { get; set; }
        public string BankName { get; set; }
        public string TransactionNumber { get; set; }
       
      
        public string InvoiceNumber { get; set; }
        public string LineItemGroupId { get; set; }
        public string ShortDate { get; set; }
       
        public string ShortTime { get; set; }
       
        public string PropertyName { get; set; }
       
        public string UnitName { get; set; }
    }
}
