using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    
    public class PaymentTransDetails
    {
        

        public int ptid { get; set; }

        public string MerchantOrderNo { get; set; }
        public decimal amount { get; set; }
        public string Currency { get; set; }
        public string PayMode { get; set; }
        public string ReferenceNumber { get; set; }
        public string outletId { get; set; }
        public string CreateDateTime { get; set; }
        public string InvoiceNumber { get; set; }
        public string cardholderName { get; set; }
        public string expiry { get; set; }
        public string name { get; set; }
        public string pan { get; set; }
        public string invoiceId { get; set; }
        public string authorizationCode { get; set; }
        public bool success { get; set; }
        public string resultCode { get; set; }
        public string resultMessage { get; set; }

        public string Status { get; set; }

        public DateTime createdOn { get; set; }



    }
}
