using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblLot
    {
        public TblLot()
        {
            TblBid = new HashSet<TblBid>();
        }

        public long LotId { get; set; }
        public int AuctionId { get; set; }
        public int? CatAuxId { get; set; }
        public bool? ImportedToMain { get; set; }
        public int? DayNo { get; set; }
        public int CatSectionId { get; set; }
        public short? LotNumber { get; set; }
        public string Description { get; set; }
        public decimal? Reserve { get; set; }
        public decimal BottomPrice { get; set; }
        public decimal TopPrice { get; set; }
        public decimal? StartingPrice { get; set; }
        public int CollectionId { get; set; }
        public int? BuyerId { get; set; }
        public decimal? HammerPrice { get; set; }
        public int? WinningBuyer { get; set; }
        public int? NextBuyer { get; set; }
        public decimal? AbsMinPrice { get; set; }
        public DateTime? DateLastAmended { get; set; }
        public string LastAmendedWho { get; set; }
        public long ParentLotId { get; set; }
        public int? SaleType { get; set; }
        public bool Checked { get; set; }
        public string UnsoldRef { get; set; }
        public int BuyerPaddleId { get; set; }
        public int BuyerPaddleNo { get; set; }
        public decimal? WinningBid { get; set; }
        public decimal? NextBid { get; set; }
        public string VectisCode { get; set; }
        public int? BuyerInvoiceId { get; set; }
        public int? VendorInvoiceId { get; set; }
        public bool? Withdrawn { get; set; }
        public bool BidEnteredWhileBookOpen { get; set; }
        public string WebLotTitle { get; set; }
        public string Keywords { get; set; }

        public TblAuction Auction { get; set; }
        public TblCatAux CatAux { get; set; }
        public TblCatSection CatSection { get; set; }
        public TblCollection Collection { get; set; }
        public ICollection<TblBid> TblBid { get; set; }
    }
}
