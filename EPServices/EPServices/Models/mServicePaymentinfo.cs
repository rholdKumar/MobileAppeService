using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    public class mServicePaymentinfo
    {
        public decimal CurAmountwithtax { get; set; }

        public decimal CurAmount { get; set; }

        public decimal taxAmount { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailID { get; set; }

        public int NoticeId { get; set; }

        public int BillYear { get; set; }

        public int PSID { get; set; }

        public DateTime DueDate { get; set; }

        public decimal TotalAmount { get; set; }

        public int NOM { get; set; }

        public decimal TaxRate { get; set; }

        public string InvoiceNumber { get; set; }

        public int PID { get; set; }

        public string PropertyName { get; set; }

        public int UnitId { get; set; }

        public string UnitName { get; set; }

        public decimal UnitArea { get; set; }

        public decimal TobePayWithTax { get; set; }

        public string OwnerName { get; set; }

        public int OwnerId { get; set; }

        public decimal PaidAmount { get; set; }

        public string NGroupID { get; set; }

        public string DeviceType { get; set; }

        public string DeviceOSType { get; set; }

        public string DeviceModel { get; set; }


    }
}
