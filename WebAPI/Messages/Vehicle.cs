using System;
using System.Runtime.Serialization;

namespace WebAPI.Messages
{
    [DataContract]
    public abstract class Vehicle
    {
        public Vehicle() { }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string Make { get; set; }

        [DataMember]
        public string Engine { get; set; }
    }
}
