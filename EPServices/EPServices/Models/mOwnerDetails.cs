using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
    public class mOwnerDetails
    {
       
        public int OwnerID { get; set; }



        public string OwnerName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string EmailID { get; set; }

        public string Password { get; set; }

        public string ContactNumber { get; set; }
        public string EmiratesNumber { get; set; }

        public string PassportNumber { get; set; }

        public string EmiratesIdFilePath { get; set; }
        public int AddressId { get; set; }
       
        public DateTime Created_on { get; set; }

        public int Created_by { get; set; }

        public int Updated_by { get; set; }

        public int RoleId { get; set; }

        public string Role { get; set; }

        // [Display(Name = "EmiratesId Copy")]

        // [Required(ErrorMessage = "Please upload emiratesId copy")]
        // [FileSize(10240)]
        // [FileTypes("jpg,jpeg,png")]
        //  [NotMapped]
        //  public HttpPostedFileBase emiratesIdPostedFile { get; set; }

        public bool Status { get; set; }

        //public string Address1 { get; set; }

        //public string Address2 { get; set; }

        //public string City { get; set; }
        //public string State { get; set; }

        //public string Country { get; set; }
        //public string PostalCode { get; set; }
    }
}
