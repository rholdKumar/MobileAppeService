using System;
namespace EPServices.Models
{
    public class PropertyModel
    {
        public int PTID { get; set; }
        public int ParentPropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PlotNumber { get; set; }
        public string PropertyNumber { get; set; }
        public string PropertyType { get; set; }
        public string State { get; set; }
        public string FullAddress { get; set; }
        public string PostalCode { get; set; }
        public string VatNumber { get; set; }
        public string BillCode { get; set; }
        public string CompanyName { get; set; }
        public object CompanyID { get; set; }
        public DateTime Created_on { get; set; }
        public int Created_by { get; set; }
        public bool WaterBill { get; set; }
        public bool AcBill { get; set; }
        public bool RentalsAvailableAcess { get; set; }
        public bool SetUtilityBill { get; set; }
        public bool SetUtilityBillForOwner { get; set; }
        public bool SetServiceCharges { get; set; }
        public bool Status { get; set; }
        public object ErrorMessage { get; set; }
        public string merchantKey { get; set; }
        public string outletRef { get; set; }
        public string merchantid { get; set; }
        public object PaymentServiceName { get; set; }
        public string BillingCompanyName { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public object BillingAddress3 { get; set; }
        public string BillingState { get; set; }
        public object EmployeeLogin { get; set; }
        public object UserAccess { get; set; }
        public object userPageAccesses { get; set; }

    }
}
