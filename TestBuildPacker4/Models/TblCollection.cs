using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblCollection
    {
        public TblCollection()
        {
            TblLot = new HashSet<TblLot>();
        }

        public int CollectionId { get; set; }
        public int ClientId { get; set; }
        public DateTime? DateReceived { get; set; }
        public string ForAuction { get; set; }
        public string Comments { get; set; }
        public string InhouseComments { get; set; }
        public int? CommisionRateId { get; set; }
        public decimal? CommisionRate { get; set; }
        public decimal? InsuranceRate { get; set; }
        public decimal? MiscCost { get; set; }
        public string StoragePoint { get; set; }
        public int? LogBookNumber { get; set; }
        public DateTime? ReceiptPrinted { get; set; }
        public DateTime? LetterPrinted { get; set; }
        public decimal? UnsoldItemCharge { get; set; }
        public decimal? MinimumVendorCommision { get; set; }
        public decimal? CatalogueCharge { get; set; }

        public TblClient Client { get; set; }
        public ICollection<TblLot> TblLot { get; set; }

    }

}
