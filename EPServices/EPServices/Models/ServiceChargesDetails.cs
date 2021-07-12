using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    public class ServiceChargesDetails
    {
       
      
        public int NoticeID { get; set; }
        public mUnitDetails unitDetails { get; set; }
        public NoticeInfoModel noticeInfo { get; set; }

        public List<mServicesType> servicesTypes { get; set; }
        public List<NoticeLineItem> NoticeLineItems { get; set; }
        public int BillYear { get; set; }
        public int PSID { get; set; }
        public string DueDate { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxTotal { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal TobePay { get; set; }
        public decimal TobePayWithTax { get; set; }
        public decimal OtherAmount { get; set; }
        public decimal MinAmount { get; set; }
        public decimal SubTotal { get; set; }

     
        public int NOM { get; set; }

     
        public bool FullYear { get; set; }

      
        public bool Q1 { get; set; }
       
        public bool Q2 { get; set; }
       
        public bool Q3 { get; set; }
      
        public bool Q4 { get; set; }
    }
    public class InvoiceDetails
    {
        public Invoices Invoices { get; set; }
        public List<InvoiceLineItem> InvoiceLineItem { get; set; }
        public List<InvoicePaidAmount> PaidHistory { get; set; }
        public int BillYear { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal OtherAmount { get; set; }

        public decimal chaDiscountAmount { get; set; }
        public string ChequeNumber { get; set; }
        public string ChequeDate { get; set; }
       
        public decimal ChequeAmount { get; set; }
        public string ChequeDesc { get; set; }
        public decimal cheDiscountAmount { get; set; }
        //Trans
        public decimal TransDiscountAmount { get; set; }
        public string BankName { get; set; }
        public string PaymentType { get; set; }
        public decimal MinAmount { get; set; } = 100;
        public string DueDate { get; set; }
        public decimal TotalDueAmount { get; set; }
       
        public bool DueAmount { get; set; }
        public bool IsMinAmount { get; set; }
      
        public bool IsOtherAmount { get; set; }
    
        public decimal FinalAmount { get; set; }

        public decimal DiscountAmount { get; set; }
        //DiscountAmount
        public string TransactionNumber { get; set; }

        public string TransactionDate { get; set; }
      
        public decimal TransactionAmount { get; set; }

        
    }
 }
