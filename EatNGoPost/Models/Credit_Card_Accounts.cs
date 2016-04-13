// 
using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class Credit_Card_Accounts
    {
        public string Location_Code { get; set; }
        public byte Credit_Card_ID { get; set; }
        public string Account_Code { get; set; }
        public string Refund_Account_Code { get; set; }
        public string Added_by { get; set; }
        public System.DateTime Added { get; set; }
        public string GiftCardPurchaseAccount { get; set; }
    }
}
