// 
using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class InvoiceNumber
    {
        public int DocNum { get; set; }
        public string Location_Code { get; set; }
        public int Order_Number { get; set; }
        public System.DateTime Order_Date { get; set; }
        public int ReceiptDocNum { get; set; }
    }
}
