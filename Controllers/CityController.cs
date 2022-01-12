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
    public class CityController : Controller
    {
        private readonly CityRepository _cityRepository;

        public CityController(CityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IActionResult Index()
        {
            return View(_cityRepository.GetAll());
        }
        public IActionResult Add()
        {
            CityModel city = new CityModel();
            return View(city);
        }

        [HttpPost]
        public IActionResult Add(CityModel city)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _cityRepository.Create(city);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int Id)
        {
            var city = _cityRepository.GetById(Id);
            return View(city);
        }

        [HttpPost]
        public IActionResult Update(CityModel city)
        {
            _cityRepository.Update(city);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            _cityRepository.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
