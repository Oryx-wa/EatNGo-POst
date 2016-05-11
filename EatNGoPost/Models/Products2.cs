// 
using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class Products2
    {
        public string ProductCode { get; set; }
        public string ProductUpdateUserCode { get; set; }
        public Nullable<System.DateTime> ProductUpdateDate { get; set; }
        public string ProdCatCode { get; set; }
        public string ProdSizeCode { get; set; }
        public string ProdFlavorCode { get; set; }
        public string ProdOsgCode { get; set; }
        public string PrPrcTblCode { get; set; }
        public string TaxCatCode { get; set; }
        public int MakeLineId { get; set; }
        public bool ProductIsActive { get; set; }
        public Nullable<System.DateTime> ProductEffectiveDate { get; set; }
        public Nullable<System.DateTime> ProductExpirationDate { get; set; }
        public string ProductDescText { get; set; }
        public string ProductShortDescText { get; set; }
        public string ProductPosDescText { get; set; }
        public decimal ProductBasePrice { get; set; }
        public decimal ProductSurchargeAmt { get; set; }
        public bool ProductIsSurchargeOnlyOnProd1 { get; set; }
        public decimal ProductBottleDepositAmt { get; set; }
        public decimal ProductMaxPrice { get; set; }
        public bool ProductIsIncludedInRoyaltySales { get; set; }
        public bool ProductIsTrackEmployeeSales { get; set; }
        public bool ProductIsPrintLabel { get; set; }
        public Nullable<double> ProductWeightedEffort { get; set; }
        public string ProductLegacyCode { get; set; }
        public Nullable<float> ProductAdditionalWeight { get; set; }
        public string ProductSurchargeDescText { get; set; }
        public string PrPrcTblCode2 { get; set; }
        public Nullable<bool> ProductIsShortcut { get; set; }
        public int ProductShortcutDisplaySeq { get; set; }
        public string Created { get; set; }
        public string errMsg { get; set; }
    }
}
