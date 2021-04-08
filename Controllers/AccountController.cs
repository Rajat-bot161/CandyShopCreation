using CandyShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserDetailsRepository _userDetailsRepository;

        public AccountController(IUserDetailsRepository userDetailsRepository)
        {
            _userDetailsRepository = userDetailsRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult IsUserValid(string UserName, string Password)
        {
           ViewBag.Message= "Login Successful";
            return View();
        }
       
    }
}
