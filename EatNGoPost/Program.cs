using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatNGoPost
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Post.ConnectToSAP())
            {
                Console.WriteLine("Unable to Connect");
                Environment.Exit(8);
            }
            else
            {
                Console.WriteLine("*** Creating Products in SAP ***");
                Console.WriteLine("");
                Post.CreateProducts();
                Console.WriteLine("*** Creating Invoices and Payments in SAP ***");
                Console.WriteLine("");
                Post.CreateOrders();
                Console.WriteLine("");

            }
    
            
        }
    }
}
