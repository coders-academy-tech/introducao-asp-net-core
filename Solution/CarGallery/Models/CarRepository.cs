using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarGallery.Models
{
    public class CarRepository: ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> GetAllCars()
        {
           return _appDbContext.Cars.Include(c => c.Category);
        }

        public Car GetPieById(int carId)
        {
            return _appDbContext.Cars.FirstOrDefault(p => p.CarId == carId);
        }
    }
}
