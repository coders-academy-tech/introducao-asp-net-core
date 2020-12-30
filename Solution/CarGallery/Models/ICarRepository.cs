﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarGallery.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetPieById(int pieId);
    }
}
