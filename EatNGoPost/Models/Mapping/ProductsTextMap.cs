// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class ProductsTextMap : EntityTypeConfiguration<ProductsText>
    {
        public ProductsTextMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Language_Code, t.ProductCode });

            // Properties
            this.Property(t => t.Language_Code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductCode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ProdTextProductDesc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProdTextDisplayCode)
                .HasMaxLength(10);

            this.Property(t => t.ProdTextSizeDesc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProdTextFlavorDesc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProdTextOptSelectGrpDesc)
                .HasMaxLength(50);

            this.Property(t => t.ProdTextCategoryDesc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProdTextSizeShortDesc)
                .HasMaxLength(8);

            this.Property(t => t.ProdTextFlavorShortDesc)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ProductsText");
            this.Property(t => t.Language_Code).HasColumnName("Language_Code");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.ProdTextProductDesc).HasColumnName("ProdTextProductDesc");
            this.Property(t => t.ProdTextDisplayCode).HasColumnName("ProdTextDisplayCode");
            this.Property(t => t.ProdTextSizeDesc).HasColumnName("ProdTextSizeDesc");
            this.Property(t => t.ProdTextFlavorDesc).HasColumnName("ProdTextFlavorDesc");
            this.Property(t => t.ProdTextOptSelectGrpDesc).HasColumnName("ProdTextOptSelectGrpDesc");
            this.Property(t => t.ProdTextCategoryDesc).HasColumnName("ProdTextCategoryDesc");
            this.Property(t => t.ProdTextSizeShortDesc).HasColumnName("ProdTextSizeShortDesc");
            this.Property(t => t.ProdTextFlavorShortDesc).HasColumnName("ProdTextFlavorShortDesc");
        }
    }
}
