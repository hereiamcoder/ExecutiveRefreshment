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
    
    public partial class driver_final_order
    {
        public long id { get; set; }
        public long user_id { get; set; }
        public decimal tax { get; set; }
        public decimal total_amount { get; set; }
        public string paid_on { get; set; }
        public string delievery_status { get; set; }
        public string payment_status { get; set; }
        public System.DateTime order_date { get; set; }
        public string sign { get; set; }
        public long order_updated { get; set; }
        public int quickbook_invoice_check { get; set; }
        public int quickbook_payment_check { get; set; }
        public string qb_o_id { get; set; }
        public string po { get; set; }
        public string truck_no { get; set; }
    }
}
