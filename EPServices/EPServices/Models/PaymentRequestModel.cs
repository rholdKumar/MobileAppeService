using System;
namespace EPServices.Models
{
    public class PaymentRequestModel
    {
        public string CurAmountwithtax { get; set; }
        public string CurAmount { get; set; }
        public string taxAmount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public int NoticeId { get; set; }
        public int BillYear { get; set; }
        public int PSID { get; set; }
        public string DueDate { get; set; }
        public string TotalAmount { get; set; }
        public int NOM { get; set; }
        public string TaxRate { get; set; }
        public string InvoiceNumber { get; set; }
        public int PID { get; set; }
        public string PropertyName { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public string UnitArea { get; set; }
        public string TobePayWithTax { get; set; }
        public string OwnerName { get; set; }
        public int OwnerId { get; set; }
        public string PaidAmount { get; set; }
        public string NGroupID { get; set; }
        public string DeviceType { get; set; }
        public string DeviceOSType { get; set; }
        public string DeviceModel { get; set; }
    }
}
