using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblClient
    { 
         public TblClient()
        {
            TblBid = new HashSet<TblBid>();
            TblCollection = new HashSet<TblCollection>();
            TblPaddle = new HashSet<TblPaddle>();
            TblSaleBuyer = new HashSet<TblSaleBuyer>();
            TblSaleVendor = new HashSet<TblSaleVendor>();
            WebsiteSubscription = new HashSet<WebsiteSubscription>();
        }

        public int ClientId { get; set; }
        public string TitleId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int? PrimaryAddId { get; set; }
        public int? DeliveryAddId { get; set; }
        public int? BillingAddId { get; set; }
        public string TelephoneOther { get; set; }
        public string TelephoneMobile { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Comments { get; set; }
        public bool FreeCatalogue { get; set; }
        public string SageBuyerId { get; set; }
        public string SageVendorId { get; set; }
        public string OnlineVectisId { get; set; }
        public string OnlineEbayId { get; set; }
        public bool? ContactEmail { get; set; }
        public bool? ContactPost { get; set; }
        public bool? ContactTelephone { get; set; }
        public bool? ContactSms { get; set; }
        public decimal? DefaultCommBuyer { get; set; }
        public decimal? DefaultCommVendor { get; set; }
        public string DefaultVatRate { get; set; }
        public bool? UsePrimaryForBilling { get; set; }
        public bool? UsePrimaryForDelivery { get; set; }
        public bool Deleted { get; set; }
        public bool Sendnewsletter { get; set; }
        public bool BidLiveChecked { get; set; }
        public bool BidProxyChecked { get; set; }

        public TblRefVatRates DefaultVatRateNavigation { get; set; }
        public TblPayment TblPayment { get; set; }
        public ICollection<TblBid> TblBid { get; set; }
        public ICollection<TblCollection> TblCollection { get; set; }
        public ICollection<TblPaddle> TblPaddle { get; set; }
        public ICollection<TblSaleBuyer> TblSaleBuyer { get; set; }
        public ICollection<TblSaleVendor> TblSaleVendor { get; set; }
        public ICollection<WebsiteSubscription> WebsiteSubscription { get; set; }
    }
}
