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

            if (ret)
            {
                Console.WriteLine("Connection to SAP ok.");   
            }
            
            //Return True
            return ret;

        }

        public static void CreateProducts()
        {
            try
            {
                using (var context = new POSStagingContext())
                {
                    var Products = context.Products2.Where(P => P.Created == "N");
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
                            oitm.SalesVATGroup = "X0";

                            if (oitm.Add() != 0)
                            {
                                oCompany.GetLastError(out errCode, out errMsg);
                                Console.WriteLine(errMsg);


                                //oCompany.Disconnect();
                            }
                            else
                            {
                                item.Created = "Y";
                                
                                Console.WriteLine(item.ProductCode + "- created successfully ");
                            }
                        }
                        
                    }
                    context.SaveChanges();
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
                    var loc = context.SAPMappings.ToList();
                    var Orders = context.Orders.Include("Order_Lines").Include("OrderPayments2").Where(o => o.DocNum == 0 && o.Order_Status_Code  == 4).OrderBy(o => o.Location_Code).ThenBy(o=> o.Order_Date).ThenBy(o => o.Order_Number);
                    int count;
                    int x = 0;

                    var countNum = (from c in context.Orders
                                    where c.DocNum == 0 && c.Order_Status_Code == 4
                                          select c.id).Count();

                    count = countNum;

                    //context.
                    foreach (var OINV in Orders.ToList())
                    {
                        //count = Orders.Count();
                        Console.WriteLine("Creating doc." + x.ToString() + " of "  + count.ToString());
                        x++;
                        SAPbobsCOM.Documents Invoice = (SAPbobsCOM.Documents)oCompany.GetBusinessObject(BoObjectTypes.oInvoices);
                        if (OINV.Order_Status_Code != 4)
                        {
                            continue;
                        }
                        OINV.ErrMsg = "";
                        Invoice.DocDate = OINV.Order_Date;
                        Invoice.DocDueDate = OINV.Order_Date;
                        Invoice.Project = "DominoPizza";
                        string CardCode = "";
                        string CostCenter = "";
                        string cashGL = "";
                        string BankGL = "";

                        foreach (var Location in loc)
                        {
                            if (Location.Location_Code == OINV.Location_Code)
                            {
                                CardCode = Location.BPCode;
                                CostCenter = Location.PrcCode;
                                cashGL = Location.CashGL;
                                BankGL = Location.BankGL;
                            }
                            else
                            {
                                continue;
                            }
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
                            Invoice.Lines.TaxCode = "X0";
                            Invoice.Lines.UserFields.Fields.Item("U_IdealFood").Value = (Double) OrderLines.OrdLineIdealFoodOptionQty;
                            Invoice.Lines.CostingCode5 = "CM0002";
                            Invoice.Lines.CostingCode2 = CostCenter;
                            Invoice.Lines.COGSCostingCode5 = "CM0002";
                            Invoice.Lines.COGSCostingCode2 = CostCenter;

                            Invoice.Lines.ProjectCode = "DominoPizza";

                            i++;
	                    }

                        Invoice.Lines.Add();                        
                        Invoice.Lines.SetCurrentLine(i);

                                             

                        Invoice.Lines.ItemCode = "VAT";
                        Invoice.Lines.Quantity = 1;
                        Invoice.Lines.Price = (Double)(OINV.Taxable_Sales1) * .05;
                        Invoice.Lines.TaxCode = "X0";
                        Invoice.Lines.ProjectCode = "DominoPizza";
                        Invoice.Lines.AccountCode = "211501";
                        
                        i++;
                        Invoice.Lines.Add();
                        Invoice.Lines.SetCurrentLine(i);
                        
                        Invoice.Lines.ItemCode = "Consumption";
                        Invoice.Lines.Quantity = 1;
                        Invoice.Lines.Price = (Double)(OINV.Taxable_Sales1) * .05;
                        Invoice.Lines.TaxCode = "X0";
                        Invoice.Lines.ProjectCode = "DominoPizza";
                        Invoice.Lines.AccountCode = "211505";

                        //oCompany.StartTransaction();
                        if (Invoice.Add() != 0)
                        {
                            oCompany.GetLastError(out errCode, out errMsg);
                            Console.WriteLine(errMsg);
                            OINV.ErrMsg += "-" + errMsg;
                            //oCompany.Disconnect();
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

                            OINV.DocNum = invNum;

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
                                        Receipt.CashAccount = cashGL;
                                        Receipt.CashSum = (Double)OINV.OrderFinalPrice;
                                        break;
                                    case 4:
                                        Receipt.TransferAccount = BankGL;
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
                                    OINV.ErrMsg += "-" +errMsg;
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
                        string strSql = "Update Orders Set DocNum = " + OINV.DocNum.ToString() + ", errMsg = '" + OINV.ErrMsg + "'" ;
                        strSql += " Where id = " + OINV.id.ToString();
                        int noOfRowsAffected = context.Database.ExecuteSqlCommand(strSql);

                        Console.WriteLine(OINV.Order_Number.ToString());
                        //using (var Context1 = new POSStagingContext())
                        //{
                        //    var Orders1 = context.Orders.Where(o => o.id == OINV.id).FirstOrDefault<Order>();
                        //    Orders1.DocNum = OINV.DocNum;

                        //    Context1.SaveChanges();
                        //}

                        
                    }

                    //context.SaveChanges();
                    //Console.WriteLine(" ");
                    //Console.WriteLine("Context saved successfully");
                    
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
                using (var context = new POSStagingContext())
                {
                    var loc = context.SAPMappings.ToList();
                    var InvUse = context.InventoryUsageSummaries.ToList();

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
}
    }
    
