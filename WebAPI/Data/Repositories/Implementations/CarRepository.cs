using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebAPI.Data.Models;
using WebAPI.Data.Repositories.Interfaces;
using WebAPI.Messages;

namespace WebAPI.Data.Repositories.Implementations
{
    public class CarRepository : ICarRepository
    {
        CarSalesContext DbContext;

        ILogger Logger;

        public CarRepository(CarSalesContext carSalesContext, ILogger<CarRepository> logger)
        {
            DbContext = carSalesContext;
            Logger = logger;
        }

        /// <summary>
        /// Creates a new record. 
        /// </summary>
        /// <param name="inputCar"></param>
        /// <returns></returns>
        public async Task<int> CreateCar(Messages.Car inputCar)
        {
            var dbCar = EntityMappers.MapCar(new[] { inputCar });
            try
            {
                var result = await DbContext.AddAsync(dbCar.FirstOrDefault());
                await DbContext.SaveChangesAsync();
                return result.Entity.Id;
            }
            catch(Exception e)
            {
                Logger.LogError(e.Message);
                return 0;
            }
        }

        /// <summary>
        /// Get the currently stored cars
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Messages.Car>> ListCars()
        {
            var cars = await DbContext.Cars.ToListAsync();

            return EntityMappers.MapCar(cars);
        }

    }
}
