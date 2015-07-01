using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payg_property_portal_master.Models
{
    public class Properties
    {

        public int id { get; set; }
        public string mls_id { get; set; }
        public string title { get; set; }
        public int type { get; set; }
        public int s_type { get; set; }
        public string s_type_freq { get; set; }
        public int listing_branch { get; set; }
        public string name_number { get; set; }
        public string block_building { get; set; }
        public string street { get; set; }
        public string area { get; set; }
        public string district { get; set; }
        public string town_city { get; set; }
        public string province { get; set; }
        public string post_code { get; set; }
        public string country { get; set; }
        public bool show_address { get; set; }
        public string locastate { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string gbase_address { get; set; }
        public string concat_address { get; set; }
        public string short_description { get; set; }
        public string full_description { get; set; }
        public decimal sale_price { get; set; }
        public decimal rental_price { get; set; }
        public string rental_frequency { get; set; }
        public bool call_for_price { get; set; }
        public int bedrooms { get; set; }
        public decimal bathrooms { get; set; }
        public decimal plot_sqft { get; set; }
        public decimal build_sqft { get; set; }
        public bool  year_built { get; set; }
        public bool heating { get; set; }
        public bool air_con { get; set; }
        public decimal garage { get; set; }
    }
}

