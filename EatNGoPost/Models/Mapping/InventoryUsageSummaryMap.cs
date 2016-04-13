// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class InventoryUsageSummaryMap : EntityTypeConfiguration<InventoryUsageSummary>
    {
        public InventoryUsageSummaryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Location_Code, t.Inventory_Code, t.Order_Date, t.Hour });

            // Properties
            this.Property(t => t.Location_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Inventory_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Hour)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("InventoryUsageSummary");
            this.Property(t => t.Location_Code).HasColumnName("Location_Code");
            this.Property(t => t.Inventory_Code).HasColumnName("Inventory_Code");
            this.Property(t => t.Order_Date).HasColumnName("Order_Date");
            this.Property(t => t.Hour).HasColumnName("Hour");
            this.Property(t => t.PortionUsage).HasColumnName("PortionUsage");
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
