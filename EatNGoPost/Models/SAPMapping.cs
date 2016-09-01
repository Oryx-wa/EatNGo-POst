// 
using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class SAPMapping
    {
        public string Location_Code { get; set; }
        public string Store_Name { get; set; }
        public string WhsCode { get; set; }
        public string PrcCode { get; set; }
        public string BPCode { get; set; }
        public string CashGL { get; set; }
        public string BankGL { get; set; }
        public bool ConsumptionTax { get; set; }
    }
}
