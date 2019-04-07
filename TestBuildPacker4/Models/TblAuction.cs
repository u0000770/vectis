using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBuildPacker4.Models
{
    public class TblAuction
    {
        public TblAuction()
        {
            TblBid = new HashSet<TblBid>();
            TblLot = new HashSet<TblLot>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuctionId { get; set; }
        public int AuctionType { get; set; }
        public DateTime AuctionDate { get; set; }
        public int AuctionDays { get; set; }
        public string AuctionTitle { get; set; }
        public bool CatalogueComplete { get; set; }
        public string MarkedCompleteBy { get; set; }
        public DateTime? MarkedCompleteDate { get; set; }
        public bool CatalogueExported { get; set; }
        public string ExportedBy { get; set; }
        public DateTime? ExportedDate { get; set; }
        public bool CatalogueUploaded { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? UploadedDate { get; set; }
        public bool LettersProduced { get; set; }
        public string LettersBy { get; set; }
        public DateTime? LettersDate { get; set; }
        public string ViewingText { get; set; }
        public string ImageFolder { get; set; }
        public decimal? CataloguePrice { get; set; }
        public string CatalogueThumb { get; set; }
        public string CatalogueImage { get; set; }
        public bool SubsUpdated { get; set; }

        public TblRefAuctionType AuctionTypeNavigation { get; set; }
        public ICollection<TblBid> TblBid { get; set; }
        public ICollection<TblLot> TblLot { get; set; }
    }
}
