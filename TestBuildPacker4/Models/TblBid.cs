using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblBid
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BidId { get; set; }
        public int AuctionId { get; set; }
        public long LotId { get; set; }
        public int BuyerId { get; set; }
        public DateTime BidDate { get; set; }
        public decimal? BidValue { get; set; }
        public bool CommisionBid { get; set; }
        public bool? Deleted { get; set; }
        public string DeletedReason { get; set; }
        public bool Active { get; set; }
        public bool? Winning { get; set; }
        public string BidIpaddress { get; set; }

        public TblAuction Auction { get; set; }
        public TblClient Buyer { get; set; }
        public TblLot Lot { get; set; }
    }
}
