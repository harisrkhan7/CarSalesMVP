using System;
namespace WebAPI.Data.Models
{
    public abstract class Vehicle
    {
        public Vehicle()
        {

        }

        public Vehicle(string Make, string Model, string Engine)
        {
            this.Make = Make;
            this.Model = Model;
            this.Engine = Engine;
        }

        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Engine { get; set; }
    }
}
