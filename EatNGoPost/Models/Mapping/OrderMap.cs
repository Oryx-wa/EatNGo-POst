// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Location_Code, t.Order_Number, t.Order_Date });

            // Properties
            this.Property(t => t.Location_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Order_Number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Modifying)
                .HasMaxLength(8);

            this.Property(t => t.Customer_Room)
                .HasMaxLength(15);

            this.Property(t => t.Customer_Name)
                .HasMaxLength(50);

            this.Property(t => t.Comments)
                .HasMaxLength(255);

            this.Property(t => t.Order_Type_Code)
                .HasMaxLength(1);

            this.Property(t => t.Driver_ID)
                .HasMaxLength(8);

            this.Property(t => t.Driver_Shift)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Computer_Name)
                .HasMaxLength(50);

            this.Property(t => t.Added_By)
                .HasMaxLength(8);

            this.Property(t => t.Cancel_Reason)
                .HasMaxLength(50);

            this.Property(t => t.Added_By_Location_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Source_Code)
                .HasMaxLength(8);

            this.Property(t => t.Void_Canc_Auth_Code)
                .HasMaxLength(8);

            this.Property(t => t.EditEmployeeCode)
                .HasMaxLength(8);

            this.Property(t => t.ReprintEmployeeCode)
                .HasMaxLength(8);

            this.Property(t => t.UpdateEmployeeCode)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.OrderTaxExemptCode)
                .HasMaxLength(50);

            this.Property(t => t.OrderTaxExemptCode2)
                .HasMaxLength(50);

            this.Property(t => t.OrderPhoneNumber)
                .HasMaxLength(25);

            this.Property(t => t.OrderPhoneExt)
                .HasMaxLength(6);

            this.Property(t => t.OrderCompanyName)
                .HasMaxLength(50);

            this.Property(t => t.OrderStreetNumber)
                .HasMaxLength(10);

            this.Property(t => t.OrderStreetName)
                .HasMaxLength(50);

            this.Property(t => t.OrderAddressLine2)
                .HasMaxLength(50);

            this.Property(t => t.OrderAddressLine3)
                .HasMaxLength(50);

            this.Property(t => t.OrderAddressLine4)
                .HasMaxLength(50);

            this.Property(t => t.OrderPostalCode)
                .HasMaxLength(10);

            this.Property(t => t.OrderCityName)
                .HasMaxLength(30);

            this.Property(t => t.OrderRegionName)
                .HasMaxLength(30);

            this.Property(t => t.OrderAddressType)
                .HasMaxLength(1);

            this.Property(t => t.MileageSource)
                .HasMaxLength(2);

            this.Property(t => t.AuthorizeEmployeeCode)
                .HasMaxLength(8);

            this.Property(t => t.VehicleCode)
                .HasMaxLength(8);

            this.Property(t => t.DriveTimeSource)
                .HasMaxLength(2);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("Orders");
            this.Property(t => t.Location_Code).HasColumnName("Location_Code");
            this.Property(t => t.Order_Number).HasColumnName("Order_Number");
            this.Property(t => t.Order_Date).HasColumnName("Order_Date");
            this.Property(t => t.Old_Order_Number).HasColumnName("Old_Order_Number");
            this.Property(t => t.Being_Modified).HasColumnName("Being_Modified");
            this.Property(t => t.Modifying).HasColumnName("Modifying");
            this.Property(t => t.Customer_Code).HasColumnName("Customer_Code");
            this.Property(t => t.Customer_Room).HasColumnName("Customer_Room");
            this.Property(t => t.Customer_Name).HasColumnName("Customer_Name");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.Actual_Order_Date).HasColumnName("Actual_Order_Date");
            this.Property(t => t.Order_Status_Code).HasColumnName("Order_Status_Code");
            this.Property(t => t.Order_Type_Code).HasColumnName("Order_Type_Code");
            this.Property(t => t.Order_Saved).HasColumnName("Order_Saved");
            this.Property(t => t.Order_Time).HasColumnName("Order_Time");
            this.Property(t => t.Sales_Tax1).HasColumnName("Sales_Tax1");
            this.Property(t => t.Sales_Tax2).HasColumnName("Sales_Tax2");
            this.Property(t => t.Coupon_Total).HasColumnName("Coupon_Total");
            this.Property(t => t.SubTotal).HasColumnName("SubTotal");
            this.Property(t => t.Route_Time).HasColumnName("Route_Time");
            this.Property(t => t.Driver_ID).HasColumnName("Driver_ID");
            this.Property(t => t.Driver_Shift).HasColumnName("Driver_Shift");
            this.Property(t => t.Return_Time).HasColumnName("Return_Time");
            this.Property(t => t.Delivery_Time).HasColumnName("Delivery_Time");
            this.Property(t => t.Delivery_Fee).HasColumnName("Delivery_Fee");
            this.Property(t => t.Taxable_Sales1).HasColumnName("Taxable_Sales1");
            this.Property(t => t.Taxable_Sales2).HasColumnName("Taxable_Sales2");
            this.Property(t => t.Non_Taxable_Sales).HasColumnName("Non_Taxable_Sales");
            this.Property(t => t.Computer_Name).HasColumnName("Computer_Name");
            this.Property(t => t.Added_By).HasColumnName("Added_By");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.Cancel_Reason).HasColumnName("Cancel_Reason");
            this.Property(t => t.Added_By_Location_Code).HasColumnName("Added_By_Location_Code");
            this.Property(t => t.Source_Code).HasColumnName("Source_Code");
            this.Property(t => t.BottleDepTotal).HasColumnName("BottleDepTotal");
            this.Property(t => t.Discount_Amount).HasColumnName("Discount_Amount");
            this.Property(t => t.Void_Canc_Auth_Code).HasColumnName("Void_Canc_Auth_Code");
            this.Property(t => t.OrderRevNbr).HasColumnName("OrderRevNbr");
            this.Property(t => t.OrderTakeCompleteTime).HasColumnName("OrderTakeCompleteTime");
            this.Property(t => t.OrderLoadTimeSecs).HasColumnName("OrderLoadTimeSecs");
            this.Property(t => t.OrderRackTimeSecs).HasColumnName("OrderRackTimeSecs");
            this.Property(t => t.OrderDispatchTimeSecs).HasColumnName("OrderDispatchTimeSecs");
            this.Property(t => t.OrderDeliveryTimeSecs).HasColumnName("OrderDeliveryTimeSecs");
            this.Property(t => t.OrderListPrice).HasColumnName("OrderListPrice");
            this.Property(t => t.OrderMenuDiscountAmt).HasColumnName("OrderMenuDiscountAmt");
            this.Property(t => t.OrderLineDiscountAmt).HasColumnName("OrderLineDiscountAmt");
            this.Property(t => t.OrderDiscountAmt).HasColumnName("OrderDiscountAmt");
            this.Property(t => t.OrderFinalPrice).HasColumnName("OrderFinalPrice");
            this.Property(t => t.OrderRoyaltySales).HasColumnName("OrderRoyaltySales");
            this.Property(t => t.OrderIdealFoodCost).HasColumnName("OrderIdealFoodCost");
            this.Property(t => t.OrderEditCount).HasColumnName("OrderEditCount");
            this.Property(t => t.EditEmployeeCode).HasColumnName("EditEmployeeCode");
            this.Property(t => t.OrderEditDate).HasColumnName("OrderEditDate");
            this.Property(t => t.OrderReprintCount).HasColumnName("OrderReprintCount");
            this.Property(t => t.ReprintEmployeeCode).HasColumnName("ReprintEmployeeCode");
            this.Property(t => t.OrderReprintDate).HasColumnName("OrderReprintDate");
            this.Property(t => t.OrderRunStopSeq).HasColumnName("OrderRunStopSeq");
            this.Property(t => t.OrderRunStopCount).HasColumnName("OrderRunStopCount");
            this.Property(t => t.UpdateEmployeeCode).HasColumnName("UpdateEmployeeCode");
            this.Property(t => t.OrderUpdateDate).HasColumnName("OrderUpdateDate");
            this.Property(t => t.OrderIsTaxExempt).HasColumnName("OrderIsTaxExempt");
            this.Property(t => t.OrderTaxExemptCode).HasColumnName("OrderTaxExemptCode");
            this.Property(t => t.OrderIsTaxExempt2).HasColumnName("OrderIsTaxExempt2");
            this.Property(t => t.OrderTaxExemptCode2).HasColumnName("OrderTaxExemptCode2");
            this.Property(t => t.OrderIsPersonalCar).HasColumnName("OrderIsPersonalCar");
            this.Property(t => t.OrderHasLabelPrinted).HasColumnName("OrderHasLabelPrinted");
            this.Property(t => t.OrderHasReceiptPrinted).HasColumnName("OrderHasReceiptPrinted");
            this.Property(t => t.OrderPaymentDueAmt).HasColumnName("OrderPaymentDueAmt");
            this.Property(t => t.OrderPhoneNumber).HasColumnName("OrderPhoneNumber");
            this.Property(t => t.OrderPhoneExt).HasColumnName("OrderPhoneExt");
            this.Property(t => t.OrderCompanyName).HasColumnName("OrderCompanyName");
            this.Property(t => t.OrderStreetNumber).HasColumnName("OrderStreetNumber");
            this.Property(t => t.OrderStreetName).HasColumnName("OrderStreetName");
            this.Property(t => t.OrderAddressLine2).HasColumnName("OrderAddressLine2");
            this.Property(t => t.OrderAddressLine3).HasColumnName("OrderAddressLine3");
            this.Property(t => t.OrderAddressLine4).HasColumnName("OrderAddressLine4");
            this.Property(t => t.OrderPostalCode).HasColumnName("OrderPostalCode");
            this.Property(t => t.OrderCityName).HasColumnName("OrderCityName");
            this.Property(t => t.OrderRegionName).HasColumnName("OrderRegionName");
            this.Property(t => t.OrderAddressType).HasColumnName("OrderAddressType");
            this.Property(t => t.OrderCompletedTime).HasColumnName("OrderCompletedTime");
            this.Property(t => t.OutboundMileage).HasColumnName("OutboundMileage");
            this.Property(t => t.ReturnMileage).HasColumnName("ReturnMileage");
            this.Property(t => t.MileageSource).HasColumnName("MileageSource");
            this.Property(t => t.AuthorizeEmployeeCode).HasColumnName("AuthorizeEmployeeCode");
            this.Property(t => t.VehicleCode).HasColumnName("VehicleCode");
            this.Property(t => t.OrderSavedBusinessDate).HasColumnName("OrderSavedBusinessDate");
            this.Property(t => t.CalculatedDeliveryTime).HasColumnName("CalculatedDeliveryTime");
            this.Property(t => t.CalculatedDeliveryTimeSecs).HasColumnName("CalculatedDeliveryTimeSecs");
            this.Property(t => t.OutboundDriveTimeSecs).HasColumnName("OutboundDriveTimeSecs");
            this.Property(t => t.ReturnDriveTimeSecs).HasColumnName("ReturnDriveTimeSecs");
            this.Property(t => t.DriveTimeSource).HasColumnName("DriveTimeSource");
            this.Property(t => t.CalculatedReturnTime).HasColumnName("CalculatedReturnTime");
            this.Property(t => t.IsLockedAfterCheckout).HasColumnName("IsLockedAfterCheckout");
            this.Property(t => t.IsVerifyCallback).HasColumnName("IsVerifyCallback");
            this.Property(t => t.QuotedTime).HasColumnName("QuotedTime");
            this.Property(t => t.OrderExpediteTime).HasColumnName("OrderExpediteTime");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.DocNum).HasColumnName("DocNum");
        }
    }
}
