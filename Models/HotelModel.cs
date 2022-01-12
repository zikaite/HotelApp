using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class HotelModel : Entity 
    {
        public int CityId { get; set; }
        public CityModel City { get; set; }
        public string Adress { get; set; }
        public int RoomsCapacity { get; set; }  
        public List<RoomModel> Rooms { get; set; }
    }
}
