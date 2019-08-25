using System;
namespace WebAPI.Data.Models
{
    public class Car : Vehicle
    {
        public Car() { }
        
        public Car(string make, string model, string engine, int doors, int wheels, string bodyType):base(make,model,engine)
        {
            this.Doors = doors;
            this.Wheels = wheels;
            this.BodyType = bodyType;
        }

        public int Doors { get; set; }

        public int Wheels { get; set; }

        public string BodyType { get; set; }

    }
}
