using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;
 

namespace CandyShop.Controllers
{
    public class AccountController : Controller
    {
        private AppDbContext db;

        public AccountController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(UserDetails model)
        {
            bool isValid = db.UserDetail.Any(x => x.UserName == model.UserName && x.Password == model.Password);
            if(isValid)
            {
                
                return RedirectToAction("Index","Home"); 
            }
            ModelState.AddModelError("", "Invalid UserName and password");
            return View();
        }
        public IActionResult SignUp()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDetails user = new UserDetails();
                user.UserName = model.UserName;
                user.Password = model.Password;

                db.UserDetail.Add(user);
                db.SaveChanges();

                ViewData["message"] = "User created Successfully!";
            }

            return RedirectToAction("login");
        }

    }
}
