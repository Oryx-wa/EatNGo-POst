// 
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EatNGoPost.Models.Mapping;

namespace EatNGoPost.Models
{
    public partial class POSStagingContext : DbContext
    {
        static POSStagingContext()
        {
            Database.SetInitializer<POSStagingContext>(null);
        }

        public POSStagingContext()
            : base("Name=POSStagingContext")
        {
        }

        public DbSet<Credit_Card_Accounts> Credit_Card_Accounts { get; set; }
        public DbSet<InventoryUsageSummary> InventoryUsageSummaries { get; set; }
        public DbSet<InvoiceNumber> InvoiceNumbers { get; set; }
        public DbSet<Order_Lines> Order_Lines { get; set; }
        public DbSet<OrderPayments2> OrderPayments2 { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Products2> Products2 { get; set; }
        public DbSet<ProductsText> ProductsTexts { get; set; }
        public DbSet<SAPMapping> SAPMappings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Credit_Card_AccountsMap());
            modelBuilder.Configurations.Add(new InventoryUsageSummaryMap());
            modelBuilder.Configurations.Add(new InvoiceNumberMap());
            modelBuilder.Configurations.Add(new Order_LinesMap());
            modelBuilder.Configurations.Add(new OrderPayments2Map());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new Products2Map());
            modelBuilder.Configurations.Add(new ProductsTextMap());
            modelBuilder.Configurations.Add(new SAPMappingMap());
        }
    }
}
