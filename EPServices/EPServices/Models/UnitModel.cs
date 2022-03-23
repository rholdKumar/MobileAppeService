using System;
namespace EPServices.Models
{
    public class UnitModel
    {
        public int UID { get; set; }
        public string UnitName { get; set; }
        public string BloackName { get; set; }
        public string UnitAreaType { get; set; }
        public string UnitNumber { get; set; }
        public int UnitTypeID { get; set; }
        public string UnitType { get; set; }
        public double UnitArea { get; set; }
        public int? Floor { get; set; }
        public string UnitCategory { get; set; }
        public bool RentalAvailable { get; set; }
        public int? NO_BadRooms { get; set; }
        public int? NO_LivingRoom { get; set; }
        public int? Balcony { get; set; }
        public int PTID { get; set; }
        public string PropertyName { get; set; }
        public int Created_by { get; set; }
        public DateTime Created_on { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string UnitDescription { get; set; }
        public bool Status { get; set; }
        public string AcMeterNumber { get; set; }
        public int? TenantUserId { get; set; }
        public string TenantName { get; set; }
        public int? TenantContractId { get; set; }
     
        public DateTime? DatePurchased { get; set; }
      
      

    }
}
