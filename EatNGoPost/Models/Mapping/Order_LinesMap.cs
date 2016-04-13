// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class Order_LinesMap : EntityTypeConfiguration<Order_Lines>
    {
        public Order_LinesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Location_Code, t.Order_Number, t.Order_Date, t.Line_Number, t.Sequence });

            // Properties
            this.Property(t => t.Location_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Order_Number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Line_Number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sequence)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Instructions)
                .HasMaxLength(255);

            this.Property(t => t.Added_By)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ProductCode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.UpdateEmployeeCode)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("Order_Lines");
            this.Property(t => t.Location_Code).HasColumnName("Location_Code");
            this.Property(t => t.Order_Number).HasColumnName("Order_Number");
            this.Property(t => t.Order_Date).HasColumnName("Order_Date");
            this.Property(t => t.Line_Number).HasColumnName("Line_Number");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.Order_Line_Status_Code).HasColumnName("Order_Line_Status_Code");
            this.Property(t => t.Oven_Time).HasColumnName("Oven_Time");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Instructions).HasColumnName("Instructions");
            this.Property(t => t.Discount_Amount).HasColumnName("Discount_Amount");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Actual_Price_Before_Coupons).HasColumnName("Actual_Price_Before_Coupons");
            this.Property(t => t.Actual_Price_After_Coupons).HasColumnName("Actual_Price_After_Coupons");
            this.Property(t => t.Bottle_Deposit).HasColumnName("Bottle_Deposit");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.Topping_Codes).HasColumnName("Topping_Codes");
            this.Property(t => t.Topping_Descriptions).HasColumnName("Topping_Descriptions");
            this.Property(t => t.IFC).HasColumnName("IFC");
            this.Property(t => t.Added_By).HasColumnName("Added_By");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.OrdLineRevNbr).HasColumnName("OrdLineRevNbr");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.OrdLineLoadTimeSecs).HasColumnName("OrdLineLoadTimeSecs");
            this.Property(t => t.OrdLineOrderDiscountAmt).HasColumnName("OrdLineOrderDiscountAmt");
            this.Property(t => t.OrdLineTaxAmt).HasColumnName("OrdLineTaxAmt");
            this.Property(t => t.OrdLineFinalPrice).HasColumnName("OrdLineFinalPrice");
            this.Property(t => t.OrdLineRoyaltySales).HasColumnName("OrdLineRoyaltySales");
            this.Property(t => t.OrdLineTaxableSales).HasColumnName("OrdLineTaxableSales");
            this.Property(t => t.OrdLineIdealFoodOptionQty).HasColumnName("OrdLineIdealFoodOptionQty");
            this.Property(t => t.TotalWeight).HasColumnName("TotalWeight");
            this.Property(t => t.PricingDetails).HasColumnName("PricingDetails");
            this.Property(t => t.PreplineToppingCodes).HasColumnName("PreplineToppingCodes");
            this.Property(t => t.PreplineToppingDescriptions).HasColumnName("PreplineToppingDescriptions");
            this.Property(t => t.UpdateEmployeeCode).HasColumnName("UpdateEmployeeCode");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.MakelineToppingCodes).HasColumnName("MakelineToppingCodes");
            this.Property(t => t.MakelineToppingDescriptions).HasColumnName("MakelineToppingDescriptions");
            this.Property(t => t.OrdLineTaxAmt1).HasColumnName("OrdLineTaxAmt1");
            this.Property(t => t.OrdLineTaxAmt2).HasColumnName("OrdLineTaxAmt2");
            this.Property(t => t.OrdLineTaxableSales2).HasColumnName("OrdLineTaxableSales2");
            this.Property(t => t.TaxableBottleDeposits).HasColumnName("TaxableBottleDeposits");
            this.Property(t => t.OrdLineTaxAmt3).HasColumnName("OrdLineTaxAmt3");
            this.Property(t => t.OrdLineTaxAmt4).HasColumnName("OrdLineTaxAmt4");
            this.Property(t => t.OrdLineTaxAmt5).HasColumnName("OrdLineTaxAmt5");
            this.Property(t => t.OrdLineTaxableSales3).HasColumnName("OrdLineTaxableSales3");
            this.Property(t => t.OrdLineTaxableSales4).HasColumnName("OrdLineTaxableSales4");
            this.Property(t => t.OrdLineTaxableSales5).HasColumnName("OrdLineTaxableSales5");
            this.Property(t => t.OrdLineRemakeQty).HasColumnName("OrdLineRemakeQty");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasRequired(t => t.Order)
                .WithMany(t => t.Order_Lines)
                .HasForeignKey(d => new { d.Location_Code, d.Order_Number, d.Order_Date });

        }
    }
}
