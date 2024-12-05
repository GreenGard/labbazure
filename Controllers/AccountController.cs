using Microsoft.AspNetCore.Mvc;
using WebApplicationMA.Models;

namespace WebApplicationMA.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(UserSignup model)
        {
            if (ModelState.IsValid)
            {
                
                ViewBag.Message = "Signup successful!";
                return View("SignupSuccess", model);
            }

           
            return View(model);
        }
    }
}
