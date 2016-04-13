// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class InvoiceNumberMap : EntityTypeConfiguration<InvoiceNumber>
    {
        public InvoiceNumberMap()
        {
            // Primary Key
            this.HasKey(t => t.DocNum);

            // Properties
            this.Property(t => t.DocNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Location_Code)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("InvoiceNumber");
            this.Property(t => t.DocNum).HasColumnName("DocNum");
            this.Property(t => t.Location_Code).HasColumnName("Location_Code");
            this.Property(t => t.Order_Number).HasColumnName("Order_Number");
            this.Property(t => t.Order_Date).HasColumnName("Order_Date");
        }
    }
}
