using HotelApp.Dtos;
using HotelApp.Models;
using HotelApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Controllers
{
    public class HotelController : Controller
    {
        private readonly HotelRepository _hotelRepository;

        public HotelController(HotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public IActionResult Index()
        {
            return View(_hotelRepository.GetAll());
        }
        public IActionResult Add()
        {
            var createHotel = new CreateHotel();
            return View(createHotel);
        }

        [HttpPost]
        public IActionResult Add(HotelModel hotel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _hotelRepository.Create(hotel);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int Id)
        {
            var hotel = _hotelRepository.GetById(Id);
            return View(hotel);
        }

        [HttpPost]
        public IActionResult Update(HotelModel hotel)
        {
            _hotelRepository.Update(hotel);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            _hotelRepository.Delete(Id);
            return RedirectToAction("Index");
        }


    }
}
