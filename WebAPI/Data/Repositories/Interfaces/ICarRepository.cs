using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Messages;

namespace WebAPI.Data.Repositories.Interfaces
{
    public interface ICarRepository
    {
        //Inserts a new car in the database
        Task<int> CreateCar(Messages.Car car);

        Task<IEnumerable<Car>> ListCars();

    }
}
