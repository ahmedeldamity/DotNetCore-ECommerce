using Core.Entities.Product_Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class StoreContext : DbContext // DbContext in Microsoft.EntityFrameworkCore package so to download it we download (Microsoft.EntityFrameworkCore | Microsoft.EntityFrameworkCore.(Database you work on it) like =>  Microsoft.EntityFrameworkCore.SqlServer )
    {
        //public StoreContext():base(){}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("ConnectionString");
        //}
        // -- this the old way to open connection with database
        // -- in this way we invoking empty constractor so this empty constractor invoking the parameterized constructor that take DbContextOptions and execute OnConfiguring() method
        // but instead of we invoking empty constractor and this empty constractor invoking the parameterized constructor, we invoke parameterized constructor 

        public StoreContext(DbContextOptions<StoreContext> options): base(options) { }

    }
}
