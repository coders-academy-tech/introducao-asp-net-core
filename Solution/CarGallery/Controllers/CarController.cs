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
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CarController(ICarRepository carRepository, ICategoryRepository categoryRepository)
        {
            _carRepository = carRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Car> cars;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cars = _carRepository.GetAllCars().OrderBy(p => p.CarId);
                currentCategory = "All Cars";
            }
            else
            {
                cars = _carRepository.GetAllCars().Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.CarId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CarListViewModel
            {
                Cars = cars,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var pie = _carRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
