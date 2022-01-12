using HotelApp.Data;
using HotelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Repositories
{
    public class HotelRepository : RepositoryBase<HotelModel>
    {
        public HotelRepository(DataContext context) : base(context)
        {

        }
    }
}
