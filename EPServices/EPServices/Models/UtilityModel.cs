using System;
namespace EPServices.Models
{
    public class UtilityModel
    {
        public int id { get; set; }
        public string TenantName { get; set; }
        public string TenantAccountNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string ContactNo { get; set; }
        public int CustomerId { get; set; }
        public string UserType { get; set; }
        public string PropertyName { get; set; }
        public int PropertyId { get; set; }
        public string UnitName { get; set; }
        public int Unitid { get; set; }
        public string UnitType { get; set; }
        public int UnitTypeId { get; set; }
        public string FloorNo { get; set; }
        public string Ele_MeterNumber { get; set; }
        public DateTime? Ele_CurrentMeterReadingDate { get; set; }
        public DateTime? Ele_PreviousMeterReadingDate { get; set; }
        public double Ele_CurrentMeterReading { get; set; }
        public double Ele_PreviousMeterReading { get; set; }
        public string Water_MeterNumber { get; set; }
        public DateTime? Water_CurrentMeterReadingDate { get; set; }
        public DateTime? Water_PreviousMeterReadingDate { get; set; }
        public double Water_CurrentMeterReading { get; set; }
        public double Water_PreviousMeterReading { get; set; }
        public string Cooling_MeterNumber { get; set; }
        public DateTime? Cooling_CurrentMeterReadingDate { get; set; }
        public DateTime? Cooling_PreviousMeterReadingDate { get; set; }
        public double Cooling_CurrentMeterReading { get; set; }
        public double Cooling_PreviousMeterReading { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime BilledDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int PaymentStatusID { get; set; }
        public string PaymentStatus { get; set; }
        public int InvoiceStatusID { get; set; }
        public string InvoiceStatus { get; set; }
        public bool Status { get; set; }
        public double TotalAmount { get; set; }
        public double PayableAmount { get; set; }
        public double PaidAmount { get; set; }
        public bool EmailSent { get; set; }
        public string UserSystem { get; set; }
        public int BillMonth { get; set; }
        public int BillYear { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedNote { get; set; }
        public string EmpDeletedId { get; set; }
        public string EmpDeletedEmail { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int UploadedBillMonth { get; set; }
        public int UploadedBillYear { get; set; }
        public string BillPeriod { get; set; }
        public string reference { get; set; }
        public string chequeNo { get; set; }
        public string PaymentType { get; set; }
        public int TenancyContractId { get; set; }
        public string Note { get; set; }
        public bool IsApproved { get; set; }
        public int ApprovedById { get; set; }
        public string IsApprovedByName { get; set; }
        public int Sewage { get; set; }
        public bool IsSewage { get; set; }
        public bool WaterSlabWise { get; set; }
        public DateTime MinDate { get; set; }
        public DateTime MaxDate { get; set; }
        public int UploadType { get; set; }
        public string CreaditType { get; set; }
        public decimal? CreaditAmount { get; set; }
        public bool Selected { get; set; }
        public string UnitSize { get; set; }
        public string UnitAreaType { get; set; }
        public DateTime ChequeDate { get; set; }
        public string TrnferdBankDetails { get; set; }
        public int OwnerId { get; set; }
        public string DiscountAmount { get; set; }
        public string EmployeeLogin { get; set; }
       
        public decimal PayAmount { get {
                return Convert.ToDecimal(TotalAmount)-(Convert.ToDecimal(PaidAmount)+ Convert.ToDecimal(CreaditAmount)+ Convert.ToDecimal(DiscountAmount));
            } }
      //  public string UserAccess { get; set; }
       // public string userPageAccesses { get; set; }

    }
}
