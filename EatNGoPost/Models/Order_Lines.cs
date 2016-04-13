// 
using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class Order_Lines
    {
        public string Location_Code { get; set; }
        public int Order_Number { get; set; }
        public System.DateTime Order_Date { get; set; }
        public short Line_Number { get; set; }
        public short Sequence { get; set; }
        public short Order_Line_Status_Code { get; set; }
        public Nullable<System.DateTime> Oven_Time { get; set; }
        public int Quantity { get; set; }
        public string Instructions { get; set; }
        public decimal Discount_Amount { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> Actual_Price_Before_Coupons { get; set; }
        public Nullable<decimal> Actual_Price_After_Coupons { get; set; }
        public decimal Bottle_Deposit { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string Topping_Codes { get; set; }
        public string Topping_Descriptions { get; set; }
        public Nullable<decimal> IFC { get; set; }
        public string Added_By { get; set; }
        public System.DateTime Added { get; set; }
        public int OrdLineRevNbr { get; set; }
        public string ProductCode { get; set; }
        public Nullable<int> OrdLineLoadTimeSecs { get; set; }
        public decimal OrdLineOrderDiscountAmt { get; set; }
        public decimal OrdLineTaxAmt { get; set; }
        public decimal OrdLineFinalPrice { get; set; }
        public decimal OrdLineRoyaltySales { get; set; }
        public decimal OrdLineTaxableSales { get; set; }
        public decimal OrdLineIdealFoodOptionQty { get; set; }
        public Nullable<float> TotalWeight { get; set; }
        public string PricingDetails { get; set; }
        public string PreplineToppingCodes { get; set; }
        public string PreplineToppingDescriptions { get; set; }
        public string UpdateEmployeeCode { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string MakelineToppingCodes { get; set; }
        public string MakelineToppingDescriptions { get; set; }
        public decimal OrdLineTaxAmt1 { get; set; }
        public decimal OrdLineTaxAmt2 { get; set; }
        public decimal OrdLineTaxableSales2 { get; set; }
        public Nullable<decimal> TaxableBottleDeposits { get; set; }
        public Nullable<decimal> OrdLineTaxAmt3 { get; set; }
        public Nullable<decimal> OrdLineTaxAmt4 { get; set; }
        public Nullable<decimal> OrdLineTaxAmt5 { get; set; }
        public Nullable<decimal> OrdLineTaxableSales3 { get; set; }
        public Nullable<decimal> OrdLineTaxableSales4 { get; set; }
        public Nullable<decimal> OrdLineTaxableSales5 { get; set; }
        public Nullable<int> OrdLineRemakeQty { get; set; }
        public int Id { get; set; }
        public virtual Order Order { get; set; }
    }
}
