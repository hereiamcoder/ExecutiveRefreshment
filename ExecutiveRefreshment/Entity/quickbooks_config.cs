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
    
    public partial class quickbooks_config
    {
        public long quickbooks_config_id { get; set; }
        public string qb_username { get; set; }
        public string module { get; set; }
        public string cfgkey { get; set; }
        public string cfgval { get; set; }
        public string cfgtype { get; set; }
        public string cfgopts { get; set; }
        public System.DateTime write_datetime { get; set; }
        public System.DateTime mod_datetime { get; set; }
    }
}