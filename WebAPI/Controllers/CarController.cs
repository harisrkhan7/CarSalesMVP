using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Models;
using WebAPI.Data.Repositories.Implementations;
using WebAPI.Messages;
using Messages = WebAPI.Messages.Car;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        CarRepository CarRepository;

        public CarController(CarRepository carRepository)
        {
            this.CarRepository = carRepository;
        }


        [HttpGet(Name = "ListCars")]
        public async Task<IEnumerable<Messages.Car>> ListCars()
        {
            return await CarRepository.ListCars();
        }
        

        // Creates a new car in the system
        [HttpPost(Name = "CreateCar")]
        public async Task<ActionResult<Messages.Car>> CreateCar(Messages.Car inputCar)
        {
            return new CreatedResult(nameof(CreateCar),await CarRepository.CreateCar(inputCar));
        }

        

    }
}
