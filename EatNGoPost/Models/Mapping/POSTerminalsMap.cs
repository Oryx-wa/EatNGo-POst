using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    class POSTerminalsMap : EntityTypeConfiguration<POSTerminals>
    {
        public POSTerminalsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Location_Code)
               .IsRequired()
               .HasMaxLength(20);

            this.Property(t => t.GLCode)
               .IsRequired()
               .HasMaxLength(20);

            this.Property(t => t.Credit_Card_ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Bank)
               .IsRequired()
               .HasMaxLength(30);

            this.Property(t => t.Description)
               .IsRequired()
               .HasMaxLength(20);

            this.Property(t => t.Terminal_No)
               .IsRequired()
               .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("POSTerminals");
            this.Property(t => t.Location_Code).HasColumnName("Location_Code");
            this.Property(t => t.Terminal_No).HasColumnName("Terminal_No");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GLCode).HasColumnName("GLCode");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.Credit_Card_ID).HasColumnName("Credit_Card_ID");
        }
    }
}
