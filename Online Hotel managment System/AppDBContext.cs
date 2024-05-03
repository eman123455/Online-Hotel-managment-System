using Microsoft.EntityFrameworkCore;
using Online_Hotel_Managment_System.Models;

namespace Online_Hotel_Managment_System
{
    public class AppDBContext:DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext>option):base (option)
        {
        }

        public DbSet<Customer>customers { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<CustomerMobile> customersMobile { get; set; }
        public DbSet<EmpMobile>empMobiles { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        //public DbSet<Payment> payments { get; set; }
        public DbSet<Room> rooms { get; set; }
        //public DbSet<TotalPrices> totalPrices { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerMobile>()
                .HasKey(o => new { o.customerID, o.CustomerMob });

            modelBuilder.Entity<EmpMobile>()
              .HasKey(o => new { o.EmployeeID, o.Mobile_No });
        }
    }


}

