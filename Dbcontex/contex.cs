using Microsoft.EntityFrameworkCore;

namespace airline
{
    public class connect:DbContext
    {
        public DbSet<Customer> Customers  { get; set; }
         public DbSet<Fly_List> Fly_Lists { get; set; }
         public DbSet<Customer_Fly> Customer_flys { get; set; }
         public DbSet<Fly_Type> Fly_Types { get; set; }
         public DbSet<City> Citys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data Source=.;initial catalog=Airline;integrated security=true");

        }
        
    }
    
}