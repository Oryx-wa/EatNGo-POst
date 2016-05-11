// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class SAPMappingMap : EntityTypeConfiguration<SAPMapping>
    {
        public SAPMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.Location_Code);

            // Properties
            this.Property(t => t.Location_Code)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Store_Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.WhsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PrcCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BPCode)
                .HasMaxLength(50);

            this.Property(t => t.CashGL)
                .HasMaxLength(20);

            this.Property(t => t.BankGL)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SAPMapping");
            this.Property(t => t.Location_Code).HasColumnName("Location_Code");
            this.Property(t => t.Store_Name).HasColumnName("Store_Name");
            this.Property(t => t.WhsCode).HasColumnName("WhsCode");
            this.Property(t => t.PrcCode).HasColumnName("PrcCode");
            this.Property(t => t.BPCode).HasColumnName("BPCode");
            this.Property(t => t.CashGL).HasColumnName("CashGL");
            this.Property(t => t.BankGL).HasColumnName("BankGL");
        }
    }
}
