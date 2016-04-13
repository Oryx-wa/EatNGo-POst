// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class OrderPayments2Map : EntityTypeConfiguration<OrderPayments2>
    {
        public OrderPayments2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Location_Code, t.Order_Date, t.Order_Number, t.OrdPaySeq });

            // Properties
            this.Property(t => t.Location_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Order_Number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrdPaySeq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Currency_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.OrdPayUpdateUserCode)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.OrdPayInfo)
                .IsRequired();

            this.Property(t => t.OrdPayCSRCode)
                .HasMaxLength(8);

            this.Property(t => t.OrdPayCardNumber)
                .HasMaxLength(255);

            this.Property(t => t.OrdPayCardExpiration)
                .HasMaxLength(255);

            this.Property(t => t.OrdPayCardHolderName)
                .HasMaxLength(50);

            this.Property(t => t.OrdPayCardHash)
                .HasMaxLength(255);

            this.Property(t => t.OrdPayCardShortNumber)
                .HasMaxLength(10);

            this.Property(t => t.OrdPayAuthCode)
                .HasMaxLength(40);

            this.Property(t => t.OrdPayReferenceNumber)
                .HasMaxLength(25);

            this.Property(t => t.OrdPaySettlementBatchNumber)
                .HasMaxLength(16);

            this.Property(t => t.OrdPayTroutd)
                .HasMaxLength(40);

            this.Property(t => t.OrdPayTillCode)
                .HasMaxLength(8);

            this.Property(t => t.OrdPayRefundReason)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrdPayEPayRefNumber)
                .HasMaxLength(255);

            this.Property(t => t.OrdPayWalletType)
                .HasMaxLength(8);

            this.Property(t => t.OrdPayWalletInfo1)
                .HasMaxLength(255);

            this.Property(t => t.OrdPayWalletInfo2)
                .HasMaxLength(255);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("OrderPayments2");
            this.Property(t => t.Location_Code).HasColumnName("Location_Code");
            this.Property(t => t.Order_Date).HasColumnName("Order_Date");
            this.Property(t => t.Order_Number).HasColumnName("Order_Number");
            this.Property(t => t.OrdPaySeq).HasColumnName("OrdPaySeq");
            this.Property(t => t.Order_Pay_Type_Code).HasColumnName("Order_Pay_Type_Code");
            this.Property(t => t.Currency_Code).HasColumnName("Currency_Code");
            this.Property(t => t.Credit_Card_ID).HasColumnName("Credit_Card_ID");
            this.Property(t => t.OrdPayRevNbr).HasColumnName("OrdPayRevNbr");
            this.Property(t => t.OrdPayUpdateUserCode).HasColumnName("OrdPayUpdateUserCode");
            this.Property(t => t.OrdPayUpdateDate).HasColumnName("OrdPayUpdateDate");
            this.Property(t => t.OrdPayCurrencyAmt).HasColumnName("OrdPayCurrencyAmt");
            this.Property(t => t.OrdPayAmt).HasColumnName("OrdPayAmt");
            this.Property(t => t.OrdPayInfo).HasColumnName("OrdPayInfo");
            this.Property(t => t.OrdPayReceipt).HasColumnName("OrdPayReceipt");
            this.Property(t => t.OrdPayIsLater).HasColumnName("OrdPayIsLater");
            this.Property(t => t.OrdPayStatusCode).HasColumnName("OrdPayStatusCode");
            this.Property(t => t.OrdPayCSRCode).HasColumnName("OrdPayCSRCode");
            this.Property(t => t.OrdPayCardNumber).HasColumnName("OrdPayCardNumber");
            this.Property(t => t.OrdPayCardNumberLength).HasColumnName("OrdPayCardNumberLength");
            this.Property(t => t.OrdPayCardExpiration).HasColumnName("OrdPayCardExpiration");
            this.Property(t => t.OrdPayCardHolderName).HasColumnName("OrdPayCardHolderName");
            this.Property(t => t.OrdPayCardHash).HasColumnName("OrdPayCardHash");
            this.Property(t => t.OrdPayCardShortNumber).HasColumnName("OrdPayCardShortNumber");
            this.Property(t => t.OrdPayCardBalanceAmt).HasColumnName("OrdPayCardBalanceAmt");
            this.Property(t => t.OrdPayAuthCode).HasColumnName("OrdPayAuthCode");
            this.Property(t => t.OrdPayReferenceNumber).HasColumnName("OrdPayReferenceNumber");
            this.Property(t => t.OrdPayIsSettled).HasColumnName("OrdPayIsSettled");
            this.Property(t => t.OrdPaySettlementDate).HasColumnName("OrdPaySettlementDate");
            this.Property(t => t.OrdPaySettlementBatchNumber).HasColumnName("OrdPaySettlementBatchNumber");
            this.Property(t => t.OrdPayTipAmt).HasColumnName("OrdPayTipAmt");
            this.Property(t => t.OrdPayTroutd).HasColumnName("OrdPayTroutd");
            this.Property(t => t.OrdPayTillCode).HasColumnName("OrdPayTillCode");
            this.Property(t => t.OrdPayTillShift).HasColumnName("OrdPayTillShift");
            this.Property(t => t.OrdPayIsPaid).HasColumnName("OrdPayIsPaid");
            this.Property(t => t.OrdPayIsReceiptPrinted).HasColumnName("OrdPayIsReceiptPrinted");
            this.Property(t => t.OrdPayIsTillCheckedOut).HasColumnName("OrdPayIsTillCheckedOut");
            this.Property(t => t.OrdPayIsTillAssignedAtDispatch).HasColumnName("OrdPayIsTillAssignedAtDispatch");
            this.Property(t => t.OrdPayProcessingDate).HasColumnName("OrdPayProcessingDate");
            this.Property(t => t.OrdPayRefundReason).HasColumnName("OrdPayRefundReason");
            this.Property(t => t.OrdPayHasReceiptPrinted).HasColumnName("OrdPayHasReceiptPrinted");
            this.Property(t => t.OrdPayRefSeq).HasColumnName("OrdPayRefSeq");
            this.Property(t => t.OrdPayCheckoutAmt).HasColumnName("OrdPayCheckoutAmt");
            this.Property(t => t.OrdPayProcessedDateTime).HasColumnName("OrdPayProcessedDateTime");
            this.Property(t => t.OrdPayProcessedOrderAmt).HasColumnName("OrdPayProcessedOrderAmt");
            this.Property(t => t.OrdPayFailedTipAmt).HasColumnName("OrdPayFailedTipAmt");
            this.Property(t => t.OrdPayTenderedAmount).HasColumnName("OrdPayTenderedAmount");
            this.Property(t => t.OrdPayChangeGiven).HasColumnName("OrdPayChangeGiven");
            this.Property(t => t.OrdPayCaptured).HasColumnName("OrdPayCaptured");
            this.Property(t => t.OrdPayEPayRefNumber).HasColumnName("OrdPayEPayRefNumber");
            this.Property(t => t.OrdPayEpayProcessingType).HasColumnName("OrdPayEpayProcessingType");
            this.Property(t => t.OrdPayWalletType).HasColumnName("OrdPayWalletType");
            this.Property(t => t.OrdPayWalletInfo1).HasColumnName("OrdPayWalletInfo1");
            this.Property(t => t.OrdPayWalletInfo2).HasColumnName("OrdPayWalletInfo2");
            this.Property(t => t.CustomerSignature).HasColumnName("CustomerSignature");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasRequired(t => t.Order)
                .WithMany(t => t.OrderPayments2)
                .HasForeignKey(d => new { d.Location_Code, d.Order_Number, d.Order_Date });

        }
    }
}
