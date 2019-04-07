using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblRefVatRates
    {
        public TblRefVatRates()
        {
            TblClient = new HashSet<TblClient>();
        }

        public string VatRatesId { get; set; }
        public decimal VatRatesValue { get; set; }
        public string VatRatesDescription { get; set; }
        public bool VatRatesDeleted { get; set; }

        public ICollection<TblClient> TblClient { get; set; }
    }
}
