using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class RoomModel : Entity
    {
        public int Floor { get; set; }
        public bool IsBooked { get; set; }
        public HotelModel Hotel { get; set; }
        public int HotelId { get; set; }
    }
}
