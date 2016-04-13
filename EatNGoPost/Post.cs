using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbobsCOM;
using EatNGoPost;
using EatNGoPost.Models;

namespace EatNGoPost
{
   public class Post
    {

       public static SAPbobsCOM.Company oCompany;
       static string errMsg;
       static     int errCode;


        public static bool ConnectToSAP()
        {
            Console.WriteLine("Connecting to SAP.");
            bool ret = true;
            try
            {
                
               
                int lRetCode;


                oCompany = new SAPbobsCOM.Company();

                Properties.Settings setting = new Properties.Settings();

                oCompany.Server = setting.LicenseServer;
                oCompany.CompanyDB = setting.CompanyDB;
                oCompany.CompanyDB = setting.CompanyDB;

                oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2008;

                //db user name
                oCompany.DbUserName = setting.DBUserName;
                oCompany.DbPassword = setting.DBPassword;
                //user name
                oCompany.UserName = setting.SAPUserName;
                //user password
                oCompany.Password = setting.SAPPassword;

                oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English;

                //Use Windows authentication for database server.
                // True for NT server authentication,
                //False for database server authentication.
                oCompany.UseTrusted = false;

                //insert license server and port
                oCompany.LicenseServer = setting.LicenseServer.Trim() + ":30000";
                //Connecting to a company DB
                lRetCode = oCompany.Connect();


                if (lRetCode != 0)
                {

                    oCompany.GetLastError(out errCode, out errMsg);
                    Console.WriteLine(errMsg);
                    oCompany.Disconnect();
                    ret = false;

                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

           
            Console.WriteLine("Connection to SAP ok.");
            //Return True
            return ret;

        }

        public static void CreateProducts()
        {
            try
            {
                using (var context = new POSStagingContext())
                {
                    var Products = context.Products2;
                    SAPbobsCOM.Items oitm = (SAPbobsCOM.Items)oCompany.GetBusinessObject(BoObjectTypes.oItems);

                    foreach (var item in Products)
                    {
                        if (item.Created == "N")
                        {
                            oitm.ItemCode = item.ProductCode;
                            oitm.ItemName = item.ProductDescText;
                            oitm.PurchaseItem = BoYesNoEnum.tNO;
                            oitm.SalesItem = BoYesNoEnum.tYES;
                            oitm.InventoryItem = BoYesNoEnum.tNO;
                            oitm.ItemsGroupCode = 115;

                            if (oitm.Add() != 0)
                            {
                                oCompany.GetLastError(out errCode, out errMsg);
                                Console.WriteLine(errMsg);
                                oCompany.Disconnect();
                            }
                            else
                            {
                                Console.WriteLine(item.ProductCode + "- created successfully ");
                            }
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void CreateOrders()
        {
            try
            {
                
                using (var context = new POSStagingContext())

                {
                    var Orders = context.Orders.Include("Order_Lines").Include("OrderPayments2");
                    foreach (var OINV in Orders)
                    {
                        SAPbobsCOM.Documents Invoice = (SAPbobsCOM.Documents)oCompany.GetBusinessObject(BoObjectTypes.oInvoices);
                        if (OINV.Order_Status_Code != 4)
                        {
                            continue;
                        }
                        Invoice.DocDate = OINV.Order_Date;
                        Invoice.DocDueDate = OINV.Order_Date;
                        Invoice.Project = "DominoPizza";
                        string CardCode = "";
                        string CostCenter = "";
                        switch (OINV.Location_Code)
                        {
                            case "51790":
                                CardCode = "DP-SAKA";
                                CostCenter = "L001";
                                break;
                            case "51792":
                                CardCode = "DP-TOYIN";
                                CostCenter = "L009";
                                break;
                            default:
                                break;
                        }
                        Invoice.CardCode = CardCode;
                        Invoice.UserFields.Fields.Item("U_POSNumber").Value = OINV.Order_Number;
                        Invoice.UserFields.Fields.Item("U_Location_Code").Value = OINV.Location_Code;

                        int i= 0;
                        foreach (var OrderLines in OINV.Order_Lines)
	                    {
		                    if (i != 0)
                            {
                                Invoice.Lines.Add();
                            }
                            Invoice.Lines.SetCurrentLine(i);
                            Invoice.Lines.ItemCode = OrderLines.ProductCode;
                            Invoice.Lines.Quantity = OrderLines.Quantity;
                            Invoice.Lines.Price = (Double)(OrderLines.OrdLineTaxableSales / OrderLines.Quantity);
                            Invoice.Lines.TaxCode = "X2";
                            Invoice.Lines.UserFields.Fields.Item("U_IdealFood").Value = (Double) OrderLines.OrdLineIdealFoodOptionQty;
                            Invoice.Lines.CostingCode5 = "CM0002";
                            Invoice.Lines.CostingCode2 = CostCenter;
                            Invoice.Lines.ProjectCode = "DominoPizza";

                            i++;
	                    }
                        //oCompany.StartTransaction();
                        if (Invoice.Add() != 0)
                        {
                            oCompany.GetLastError(out errCode, out errMsg);
                            Console.WriteLine(errMsg);
                            oCompany.Disconnect();
                            //if (oCompany.InTransaction)
                            //{
                            //    oCompany.EndTransaction(BoWfTransOpt.wf_RollBack);
                            //}
                        }
                        else
                        {
                            Console.WriteLine("Invoice for " + OINV.Location_Code+ " - "+ OINV.Order_Number + " - " +OINV.Order_Date.ToShortDateString()  + " - created successfully ");
                            var invNum = (from c in context.InvoiceNumbers
                                          select c.DocNum).Max();

                            SAPbobsCOM.Payments Receipt = (SAPbobsCOM.Payments)oCompany.GetBusinessObject(BoObjectTypes.oIncomingPayments);

                            foreach (var OrderPayment in OINV.OrderPayments2)
                            {
                                Receipt.CardCode = CardCode;
                                Receipt.DocDate = OrderPayment.Order_Date;
                                //Receipt.Reference1 = OrderPayment.OrdPayEPayRefNumber;
                                Receipt.Invoices.InvoiceType = BoRcptInvTypes.it_Invoice;
                                Receipt.Invoices.DocEntry = invNum;
                                Receipt.Invoices.SumApplied = (Double)OrderPayment.OrdPayAmt;
                                Receipt.ProjectCode = "DominoPizza";

                                switch (OrderPayment.Order_Pay_Type_Code)
                                {
                                    case 1:
                                        Receipt.CashAccount = "124104";
                                        Receipt.CashSum = (Double)OINV.OrderFinalPrice;
                                        break;
                                    case 4:
                                        Receipt.TransferAccount = "124211";
                                        Receipt.TransferDate = OrderPayment.Order_Date;
                                        Receipt.TransferSum = (Double)OrderPayment.OrdPayAmt;
                                        if (OrderPayment.OrdPayEPayRefNumber.Length < 27)
                                        {
                                            Receipt.TransferReference = OrderPayment.OrdPayEPayRefNumber;
                                        }
                                        else
                                        {
                                            Receipt.TransferReference = OrderPayment.OrdPayEPayRefNumber.ToString().Substring(0, 26);
                                        }

                                        
                                        break;
                                    default:
                                        break;
                                }
                                if (Receipt.Add() != 0)
                                {
                                    oCompany.GetLastError(out errCode, out errMsg);
                                    Console.WriteLine(errMsg);
                                    oCompany.Disconnect();
                                    //if (oCompany.InTransaction)
                                    //{
                                    //    oCompany.EndTransaction(BoWfTransOpt.wf_RollBack);
                                    //}
                                }
                                else
                                {
                                    Console.WriteLine("Receipt for " + OrderPayment.Order_Number + " - " + OrderPayment.Location_Code + " - " + OrderPayment.Order_Date.ToShortDateString() + " - created successfully ");
                                }

                                break;
                            }
                        }

                        //if (oCompany.InTransaction)
                        //{
                        //    oCompany.EndTransaction(BoWfTransOpt.wf_Commit);
                        //}

                        Console.WriteLine(OINV.Order_Number.ToString());
                    }                 
                    
                    

                }
            }
            catch (Exception ex)
            {
                //if (oCompany.InTransaction)
                //{
                //    oCompany.EndTransaction(BoWfTransOpt.wf_RollBack);
                //}
                Console.WriteLine(ex.Message);
            }
        }

        public static void PostInventory()
        {
            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
}
    }
    
