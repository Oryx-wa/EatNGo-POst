// 
using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class InventoryUsageSummary
    {
        public string Location_Code { get; set; }
        public string Inventory_Code { get; set; }
        public System.DateTime Order_Date { get; set; }
        public int Hour { get; set; }
        public float PortionUsage { get; set; }
        public int id { get; set; }
    }
}
