using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarGallery.Models;

namespace CarGallery.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public string CurrentCategory { get; set; }
    }
}
