using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Models
{
   
    public class TaxDetails
    {
        
        public int TaxId { get; set; }
        public int TaxYear { get; set; }
        public decimal TaxPercentage { get; set; }
    }
}
