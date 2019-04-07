//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VectisDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class WebsiteSubscription
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string VendorTXCode { get; set; }
        public int Length { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string PaymentMethod { get; set; }
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiryMMYY { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public Nullable<decimal> CostExVat { get; set; }
        public Nullable<decimal> VatCost { get; set; }
        public Nullable<decimal> VatRate { get; set; }
        public Nullable<bool> IsComplimentary { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
    
        public virtual tblClient tblClient { get; set; }
    }
}
