//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExecutiveRefreshment.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class qblog_customer
    {
        public long QBCLogId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Successful { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
        public string Errors { get; set; }
        public string Response { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string Mode { get; set; }
    }
}
