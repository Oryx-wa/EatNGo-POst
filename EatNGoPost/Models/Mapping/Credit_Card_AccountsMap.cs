// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class Credit_Card_AccountsMap : EntityTypeConfiguration<Credit_Card_Accounts>
    {
        public Credit_Card_AccountsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Location_Code, t.Credit_Card_ID });

            // Properties
            this.Property(t => t.Location_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Account_Code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Refund_Account_Code)
                .HasMaxLength(10);

            this.Property(t => t.Added_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.GiftCardPurchaseAccount)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Credit_Card_Accounts");
            this.Property(t => t.Location_Code).HasColumnName("Location_Code");
            this.Property(t => t.Credit_Card_ID).HasColumnName("Credit_Card_ID");
            this.Property(t => t.Account_Code).HasColumnName("Account_Code");
            this.Property(t => t.Refund_Account_Code).HasColumnName("Refund_Account_Code");
            this.Property(t => t.Added_by).HasColumnName("Added_by");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.GiftCardPurchaseAccount).HasColumnName("GiftCardPurchaseAccount");
        }
    }
}
