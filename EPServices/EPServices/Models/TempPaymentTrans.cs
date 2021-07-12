using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
   
    public class TempPaymentTrans
    {
        

        public int id { get; set; }

        public int NoticeID { get; set; }
        public int BillYear { get; set; }

        public int PSID { get; set; }

        public string DueDate { get; set; }

        public decimal TotalAmount { get; set; }
        public int NOM { get; set; }

        public string PaymentRef { get; set; }
        public DateTime createdon { get; set; }
        public bool FullYear { get; set; }
        public bool Q1 { get; set; }
        public bool Q2 { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TobePay { get; set; }

        public decimal MinAmount { get; set; }

        public decimal OtherAmount { get; set; }
        public string InvoiceNumber { get; set; }

        public int Year { get; set; }

        public int PID { get; set; }
        public string PropertyName { get; set; }

        public int UnitId { get; set; }

        public string UnitName { get; set; }

        public decimal UnitArea { get; set; }
        public decimal TobePayWithTax { get; set; }
        public string OwnerName { get; set; }

        public int OwnerId { get; set; }
        public int OnlinePaymentId { get; set; }
        public decimal TotalPaidAmount { get; set; }

       
        public decimal CurAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal taxAmount { get; set; }
        public string PaymentStatus { get; set; }

        public string NGroupID { get; set; }

    }
    public class PaymentMaster
    {
       
        public TempPaymentTrans tempPayment { get; set; }

        public List<NoticeLineItem> NoticeLineItems { get; set; }

        public Invoices invoices { get; set; }

        public InvoicePaidAmount invoicePaidAmount { get; set; }
    }
}
