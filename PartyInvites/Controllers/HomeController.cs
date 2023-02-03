using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RsvForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ViewResult ListResponses()
        {
            return View(Repository.Response.Where(r=>r.WillAttend == true));  
        }



    }
}