using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class WebsiteSubscription
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string VendorTxcode { get; set; }
        public int Length { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PaymentMethod { get; set; }
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiryMmyy { get; set; }
        public int? Status { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? CostExVat { get; set; }
        public decimal? VatCost { get; set; }
        public decimal? VatRate { get; set; }
        public bool? IsComplimentary { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public TblClient Client { get; set; }
    }
}
