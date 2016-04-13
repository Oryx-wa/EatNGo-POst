// 
using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class Order
    {
        public Order()
        {
            this.Order_Lines = new List<Order_Lines>();
            this.OrderPayments2 = new List<OrderPayments2>();
        }

        public string Location_Code { get; set; }
        public int Order_Number { get; set; }
        public System.DateTime Order_Date { get; set; }
        public int Old_Order_Number { get; set; }
        public Nullable<bool> Being_Modified { get; set; }
        public string Modifying { get; set; }
        public int Customer_Code { get; set; }
        public string Customer_Room { get; set; }
        public string Customer_Name { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> Actual_Order_Date { get; set; }
        public short Order_Status_Code { get; set; }
        public string Order_Type_Code { get; set; }
        public Nullable<System.DateTime> Order_Saved { get; set; }
        public short Order_Time { get; set; }
        public Nullable<decimal> Sales_Tax1 { get; set; }
        public Nullable<decimal> Sales_Tax2 { get; set; }
        public decimal Coupon_Total { get; set; }
        public decimal SubTotal { get; set; }
        public Nullable<System.DateTime> Route_Time { get; set; }
        public string Driver_ID { get; set; }
        public string Driver_Shift { get; set; }
        public Nullable<System.DateTime> Return_Time { get; set; }
        public Nullable<System.DateTime> Delivery_Time { get; set; }
        public decimal Delivery_Fee { get; set; }
        public decimal Taxable_Sales1 { get; set; }
        public decimal Taxable_Sales2 { get; set; }
        public decimal Non_Taxable_Sales { get; set; }
        public string Computer_Name { get; set; }
        public string Added_By { get; set; }
        public Nullable<System.DateTime> Added { get; set; }
        public string Cancel_Reason { get; set; }
        public string Added_By_Location_Code { get; set; }
        public string Source_Code { get; set; }
        public Nullable<decimal> BottleDepTotal { get; set; }
        public Nullable<decimal> Discount_Amount { get; set; }
        public string Void_Canc_Auth_Code { get; set; }
        public short OrderRevNbr { get; set; }
        public Nullable<System.DateTime> OrderTakeCompleteTime { get; set; }
        public Nullable<int> OrderLoadTimeSecs { get; set; }
        public Nullable<int> OrderRackTimeSecs { get; set; }
        public Nullable<int> OrderDispatchTimeSecs { get; set; }
        public Nullable<int> OrderDeliveryTimeSecs { get; set; }
        public decimal OrderListPrice { get; set; }
        public decimal OrderMenuDiscountAmt { get; set; }
        public decimal OrderLineDiscountAmt { get; set; }
        public decimal OrderDiscountAmt { get; set; }
        public decimal OrderFinalPrice { get; set; }
        public decimal OrderRoyaltySales { get; set; }
        public Nullable<decimal> OrderIdealFoodCost { get; set; }
        public short OrderEditCount { get; set; }
        public string EditEmployeeCode { get; set; }
        public Nullable<System.DateTime> OrderEditDate { get; set; }
        public short OrderReprintCount { get; set; }
        public string ReprintEmployeeCode { get; set; }
        public Nullable<System.DateTime> OrderReprintDate { get; set; }
        public Nullable<short> OrderRunStopSeq { get; set; }
        public Nullable<short> OrderRunStopCount { get; set; }
        public string UpdateEmployeeCode { get; set; }
        public System.DateTime OrderUpdateDate { get; set; }
        public bool OrderIsTaxExempt { get; set; }
        public string OrderTaxExemptCode { get; set; }
        public bool OrderIsTaxExempt2 { get; set; }
        public string OrderTaxExemptCode2 { get; set; }
        public Nullable<bool> OrderIsPersonalCar { get; set; }
        public Nullable<bool> OrderHasLabelPrinted { get; set; }
        public Nullable<bool> OrderHasReceiptPrinted { get; set; }
        public Nullable<decimal> OrderPaymentDueAmt { get; set; }
        public string OrderPhoneNumber { get; set; }
        public string OrderPhoneExt { get; set; }
        public string OrderCompanyName { get; set; }
        public string OrderStreetNumber { get; set; }
        public string OrderStreetName { get; set; }
        public string OrderAddressLine2 { get; set; }
        public string OrderAddressLine3 { get; set; }
        public string OrderAddressLine4 { get; set; }
        public string OrderPostalCode { get; set; }
        public string OrderCityName { get; set; }
        public string OrderRegionName { get; set; }
        public string OrderAddressType { get; set; }
        public Nullable<System.DateTime> OrderCompletedTime { get; set; }
        public Nullable<double> OutboundMileage { get; set; }
        public Nullable<double> ReturnMileage { get; set; }
        public string MileageSource { get; set; }
        public string AuthorizeEmployeeCode { get; set; }
        public string VehicleCode { get; set; }
        public Nullable<System.DateTime> OrderSavedBusinessDate { get; set; }
        public Nullable<System.DateTime> CalculatedDeliveryTime { get; set; }
        public Nullable<int> CalculatedDeliveryTimeSecs { get; set; }
        public Nullable<int> OutboundDriveTimeSecs { get; set; }
        public Nullable<int> ReturnDriveTimeSecs { get; set; }
        public string DriveTimeSource { get; set; }
        public Nullable<System.DateTime> CalculatedReturnTime { get; set; }
        public Nullable<bool> IsLockedAfterCheckout { get; set; }
        public Nullable<bool> IsVerifyCallback { get; set; }
        public Nullable<System.DateTime> QuotedTime { get; set; }
        public Nullable<System.DateTime> OrderExpediteTime { get; set; }
        public int id { get; set; }
        public Nullable<int> DocNum { get; set; }
        public virtual ICollection<Order_Lines> Order_Lines { get; set; }
        public virtual ICollection<OrderPayments2> OrderPayments2 { get; set; }
    }
}
