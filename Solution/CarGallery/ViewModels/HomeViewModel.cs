using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarGallery.Models;

namespace CarGallery.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}
