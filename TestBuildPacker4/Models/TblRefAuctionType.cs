using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblRefAuctionType
    {
        public TblRefAuctionType()
        {
            TblAuction = new HashSet<TblAuction>();
        }

        public int AuctionTypeId { get; set; }
        public string AuctionTypeDescription { get; set; }
        public bool AuctionTypeDeleted { get; set; }
        public bool AuctionTypeDefault { get; set; }

        public ICollection<TblAuction> TblAuction { get; set; }
    }
}
