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
    
    public partial class revised_invoice
    {
        public long id { get; set; }
        public string invoice_no_old { get; set; }
        public string invoice_no_new { get; set; }
        public System.DateTime date_time { get; set; }
    }
}