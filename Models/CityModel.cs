using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class CityModel : Entity
    {
        public List<HotelModel> Hotels { get; set; }

        public List<CleanerModel> Cleaners { get; set; }

    }
}
