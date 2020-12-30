using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarGallery.Models;
using CarGallery.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _pieRepository;

        public HomeController(ICarRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Cars = _pieRepository.GetAllCars()
            };

            return View(homeViewModel);
        }
    }
}
