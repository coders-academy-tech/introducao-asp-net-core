using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarGallery.Models;
using CarGallery.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarGallery.Controllers
{
    public class ContactController : Controller
    {

        private readonly IEmailService emailService;

        public ContactController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact model)
        {
            if (!ModelState.IsValid)
                return View(model);

            this.emailService.SendEmail(model);

            ViewBag.EmailSend = true;

            return View();
        }

    }
}
