using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    [DataContract]
    public class HotelModel
    {
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public String Address { get; set; }
        [DataMember]
        public int Rating { get; set; }
        [DataMember]
        public int Price { get; set; }
    }
}
