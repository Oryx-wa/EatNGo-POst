// 
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EatNGoPost.Models.Mapping
{
    public class Products2Map : EntityTypeConfiguration<Products2>
    {
        public Products2Map()
        {
            // Primary Key
            this.HasKey(t => t.ProductCode);

            // Properties
            this.Property(t => t.ProductCode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ProductUpdateUserCode)
                .HasMaxLength(8);

            this.Property(t => t.ProdCatCode)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ProdSizeCode)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ProdFlavorCode)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ProdOsgCode)
                .HasMaxLength(8);

            this.Property(t => t.PrPrcTblCode)
                .HasMaxLength(8);

            this.Property(t => t.TaxCatCode)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ProductDescText)
                .HasMaxLength(32);

            this.Property(t => t.ProductShortDescText)
                .HasMaxLength(16);

            this.Property(t => t.ProductPosDescText)
                .HasMaxLength(32);

            this.Property(t => t.ProductLegacyCode)
                .HasMaxLength(4);

            this.Property(t => t.ProductSurchargeDescText)
                .HasMaxLength(32);

            this.Property(t => t.PrPrcTblCode2)
                .HasMaxLength(8);

            this.Property(t => t.Created)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Products2");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.ProductUpdateUserCode).HasColumnName("ProductUpdateUserCode");
            this.Property(t => t.ProductUpdateDate).HasColumnName("ProductUpdateDate");
            this.Property(t => t.ProdCatCode).HasColumnName("ProdCatCode");
            this.Property(t => t.ProdSizeCode).HasColumnName("ProdSizeCode");
            this.Property(t => t.ProdFlavorCode).HasColumnName("ProdFlavorCode");
            this.Property(t => t.ProdOsgCode).HasColumnName("ProdOsgCode");
            this.Property(t => t.PrPrcTblCode).HasColumnName("PrPrcTblCode");
            this.Property(t => t.TaxCatCode).HasColumnName("TaxCatCode");
            this.Property(t => t.MakeLineId).HasColumnName("MakeLineId");
            this.Property(t => t.ProductIsActive).HasColumnName("ProductIsActive");
            this.Property(t => t.ProductEffectiveDate).HasColumnName("ProductEffectiveDate");
            this.Property(t => t.ProductExpirationDate).HasColumnName("ProductExpirationDate");
            this.Property(t => t.ProductDescText).HasColumnName("ProductDescText");
            this.Property(t => t.ProductShortDescText).HasColumnName("ProductShortDescText");
            this.Property(t => t.ProductPosDescText).HasColumnName("ProductPosDescText");
            this.Property(t => t.ProductBasePrice).HasColumnName("ProductBasePrice");
            this.Property(t => t.ProductSurchargeAmt).HasColumnName("ProductSurchargeAmt");
            this.Property(t => t.ProductIsSurchargeOnlyOnProd1).HasColumnName("ProductIsSurchargeOnlyOnProd1");
            this.Property(t => t.ProductBottleDepositAmt).HasColumnName("ProductBottleDepositAmt");
            this.Property(t => t.ProductMaxPrice).HasColumnName("ProductMaxPrice");
            this.Property(t => t.ProductIsIncludedInRoyaltySales).HasColumnName("ProductIsIncludedInRoyaltySales");
            this.Property(t => t.ProductIsTrackEmployeeSales).HasColumnName("ProductIsTrackEmployeeSales");
            this.Property(t => t.ProductIsPrintLabel).HasColumnName("ProductIsPrintLabel");
            this.Property(t => t.ProductWeightedEffort).HasColumnName("ProductWeightedEffort");
            this.Property(t => t.ProductLegacyCode).HasColumnName("ProductLegacyCode");
            this.Property(t => t.ProductAdditionalWeight).HasColumnName("ProductAdditionalWeight");
            this.Property(t => t.ProductSurchargeDescText).HasColumnName("ProductSurchargeDescText");
            this.Property(t => t.PrPrcTblCode2).HasColumnName("PrPrcTblCode2");
            this.Property(t => t.ProductIsShortcut).HasColumnName("ProductIsShortcut");
            this.Property(t => t.ProductShortcutDisplaySeq).HasColumnName("ProductShortcutDisplaySeq");
            this.Property(t => t.Created).HasColumnName("Created");
        }
    }
}
