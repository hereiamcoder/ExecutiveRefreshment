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
    
    public partial class shipping_address
    {
        public long id { get; set; }
        public long cart_id { get; set; }
        public long user_id { get; set; }
        public string session_id { get; set; }
        public string fname_ship { get; set; }
        public string lname_ship { get; set; }
        public string address1_ship { get; set; }
        public string address2_ship { get; set; }
        public string city_ship { get; set; }
        public string state_ship { get; set; }
        public string phone_ship { get; set; }
        public string pin_ship { get; set; }
        public string country_ship { get; set; }
        public string name_sender { get; set; }
        public string email_sender { get; set; }
        public string address1_sender { get; set; }
        public string address2_sender { get; set; }
        public string city_sender { get; set; }
        public string state_sender { get; set; }
        public string pin_sender { get; set; }
        public string phone_sender { get; set; }
        public string country_sender { get; set; }
    }
}