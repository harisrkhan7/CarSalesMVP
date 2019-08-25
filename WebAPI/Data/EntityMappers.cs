using System;
using System.Collections.Generic;
using System.Linq;
using Messages = WebAPI.Messages;
using Models = WebAPI.Data.Models;
namespace WebAPI.Data
{
    public static class EntityMappers
    {
        public static IEnumerable<Models.Car> MapCar(IEnumerable<Messages.Car> inputCars)
        {
            return inputCars.Select(x => new Models.Car
            {
                Make = x.Make,
                Model = x.Model,
                BodyType = x.BodyType,
                Engine = x.Engine,
                Doors = x.Doors,
                Wheels = x.Wheels
            });
        }

        public static IEnumerable<Messages.Car> MapCar(IEnumerable<Models.Car> inputCars)
        {
            return inputCars.Select(x => new Messages.Car
            {
                Make = x.Make,
                Model = x.Model,
                BodyType = x.BodyType,
                Engine = x.Engine,
                Doors = x.Doors,
                Wheels = x.Wheels
            });
        }

    }
}
