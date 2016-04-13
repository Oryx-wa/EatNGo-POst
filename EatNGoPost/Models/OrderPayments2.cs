// 
using System;
using System.Collections.Generic;

namespace EatNGoPost.Models
{
    public partial class OrderPayments2
    {
        public string Location_Code { get; set; }
        public System.DateTime Order_Date { get; set; }
        public int Order_Number { get; set; }
        public int OrdPaySeq { get; set; }
        public short Order_Pay_Type_Code { get; set; }
        public string Currency_Code { get; set; }
        public Nullable<byte> Credit_Card_ID { get; set; }
        public int OrdPayRevNbr { get; set; }
        public string OrdPayUpdateUserCode { get; set; }
        public System.DateTime OrdPayUpdateDate { get; set; }
        public decimal OrdPayCurrencyAmt { get; set; }
        public decimal OrdPayAmt { get; set; }
        public string OrdPayInfo { get; set; }
        public string OrdPayReceipt { get; set; }
        public bool OrdPayIsLater { get; set; }
        public short OrdPayStatusCode { get; set; }
        public string OrdPayCSRCode { get; set; }
        public string OrdPayCardNumber { get; set; }
        public Nullable<int> OrdPayCardNumberLength { get; set; }
        public string OrdPayCardExpiration { get; set; }
        public string OrdPayCardHolderName { get; set; }
        public string OrdPayCardHash { get; set; }
        public string OrdPayCardShortNumber { get; set; }
        public Nullable<decimal> OrdPayCardBalanceAmt { get; set; }
        public string OrdPayAuthCode { get; set; }
        public string OrdPayReferenceNumber { get; set; }
        public bool OrdPayIsSettled { get; set; }
        public Nullable<System.DateTime> OrdPaySettlementDate { get; set; }
        public string OrdPaySettlementBatchNumber { get; set; }
        public decimal OrdPayTipAmt { get; set; }
        public string OrdPayTroutd { get; set; }
        public string OrdPayTillCode { get; set; }
        public byte OrdPayTillShift { get; set; }
        public bool OrdPayIsPaid { get; set; }
        public bool OrdPayIsReceiptPrinted { get; set; }
        public bool OrdPayIsTillCheckedOut { get; set; }
        public bool OrdPayIsTillAssignedAtDispatch { get; set; }
        public System.DateTime OrdPayProcessingDate { get; set; }
        public string OrdPayRefundReason { get; set; }
        public bool OrdPayHasReceiptPrinted { get; set; }
        public int OrdPayRefSeq { get; set; }
        public decimal OrdPayCheckoutAmt { get; set; }
        public Nullable<System.DateTime> OrdPayProcessedDateTime { get; set; }
        public Nullable<decimal> OrdPayProcessedOrderAmt { get; set; }
        public Nullable<decimal> OrdPayFailedTipAmt { get; set; }
        public Nullable<decimal> OrdPayTenderedAmount { get; set; }
        public Nullable<decimal> OrdPayChangeGiven { get; set; }
        public Nullable<bool> OrdPayCaptured { get; set; }
        public string OrdPayEPayRefNumber { get; set; }
        public Nullable<int> OrdPayEpayProcessingType { get; set; }
        public string OrdPayWalletType { get; set; }
        public string OrdPayWalletInfo1 { get; set; }
        public string OrdPayWalletInfo2 { get; set; }
        public string CustomerSignature { get; set; }
        public int Id { get; set; }
        public virtual Order Order { get; set; }
    }
}
