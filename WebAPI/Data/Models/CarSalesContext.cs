using System;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data.Models
{
    public class CarSalesContext: DbContext
    {
        public CarSalesContext(DbContextOptions<CarSalesContext> contextOptions):base(contextOptions)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
