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
    
    public partial class SagePayToken
    {
        public int SagePayTokenID { get; set; }
        public Nullable<int> LinkID { get; set; }
        public string VPSProtocol { get; set; }
        public string TxType { get; set; }
        public string Vendor { get; set; }
        public string Currency { get; set; }
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string StartDate { get; set; }
        public string ExpiryDate { get; set; }
        public string IssueNumber { get; set; }
        public string CV2 { get; set; }
        public string CardType { get; set; }
        public string Status { get; set; }
        public string StatusDetail { get; set; }
        public string Token { get; set; }
        public string CustomerRef { get; set; }
        public int WorkflowStatus { get; set; }
        public bool IsRemoved { get; set; }
        public Nullable<System.DateTime> RemovalDate { get; set; }
        public string RemovedBy { get; set; }
        public string RemoveTxType { get; set; }
        public string RemoveStatusDetail { get; set; }
        public string RemoveStatus { get; set; }
    }
}