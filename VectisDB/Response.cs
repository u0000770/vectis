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
    
    public partial class Response
    {
        public int ResponseID { get; set; }
        public string ResponseGUID { get; set; }
        public Nullable<int> QNRID { get; set; }
        public Nullable<int> RecipientID { get; set; }
        public Nullable<bool> Responded { get; set; }
        public Nullable<System.DateTime> RespondedDate { get; set; }
        public string Type { get; set; }
    }
}
