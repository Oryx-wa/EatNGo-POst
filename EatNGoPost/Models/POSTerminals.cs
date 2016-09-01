using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class POSTerminals
    {
        public System.Byte Credit_Card_ID  {get; set;}
        public string Description { get; set; }
        public string Terminal_No { get; set; }
        public int ID { get; set; }
        public string Location_Code { get; set; }
        public string GLCode { get; set; }
        public string Bank { get; set; }
    }
}
