using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class CleanerModel : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public List<RoomModel> Rooms { get; set; }
    }
}
