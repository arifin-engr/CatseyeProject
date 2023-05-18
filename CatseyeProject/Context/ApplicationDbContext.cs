using CatseyeProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace CatseyeProject.Context
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {

        }
        //public DbSet<CatsApplicationUser> tblAppUsers { get; set; }

        public DbSet<BrowserCount> tblBrowserCount { get; set; }
        public DbSet<CatsSelseDetails> tblCatsSelseDetails { get; set; }
        public DbSet<CatsBillingadres> tblBilling { get; set; }
        public DbSet<CatsCartDetails> tblCatsCartDetails { get; set; }
        public DbSet<CatsCart> tblCatsCart { get; set; }
        public DbSet<CatsCollection> tblCollection { get; set; }
        public DbSet<catsContractUs> tblcontractus { get; set; }
        public DbSet<CatsCustomer> tblCustomers { get; set; }
        public DbSet<CatsproductDescription>tbldescription { get; set; }
        public DbSet<CatsHomebannercs> tblHomBanner { get; set; }
        public DbSet<CatsOrder> tblOrder { get; set; }
        public DbSet<CatsProduct> tblOrderDetails { get; set; }
        public DbSet<CatsOrderDetails> tblProduct { get; set; }
        public DbSet<CatsProductCategory> tblProductCategory { get; set; }
        public DbSet<CatsProductColor> tblProductColors { get; set; }
        public DbSet<CatsProductdetails> tblProductdetails { get; set; }
        public DbSet<CatsProductSize> ProductSizes { get; set; }
        public DbSet<CatsproductType> tblproductTypes { get; set; }
        public DbSet<CatsRatingSystem> tblRating { get; set; }
        public DbSet<CatsReason> tblreasons { get; set; }
        public DbSet<CatsReturnReason> tblReturnReasons { get; set; }
        public DbSet<CatsSearchHistory> tblsearch { get; set; }
        public DbSet<CatsShippingadres> tblShipping { get; set; }
        public DbSet<CatsStockInformation> tblStockInformation { get; set; }
        public DbSet<CatsProductSubCategory> tblSubCategory { get; set; }
        public DbSet<CatsToken> tblToken { get; set; }
    }
}
