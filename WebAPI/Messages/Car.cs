using System;
using System.Runtime.Serialization;

namespace WebAPI.Messages
{
    [DataContract]
    public class Car : Vehicle
    {
        public Car()
        {
        }

        [DataMember]
        public int Doors { get; set; }

        [DataMember]
        public int Wheels { get; set; }

        [DataMember]
        public string BodyType { get; set; }

    }
}
