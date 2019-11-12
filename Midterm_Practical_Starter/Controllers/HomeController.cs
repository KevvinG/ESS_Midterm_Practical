using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm_Practical_Starter.Models;

namespace Midterm_Practical_Starter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                if (IsEmailExist(user.Email))
                {
                    if (IsPasswordCorrect(user.Email, user.Password))
                    {
                        return View("MyWorkshops", user);
                    } else
                    {
                        ModelState.AddModelError("PasswordIncorrect", "Password is incorrect");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("EmailNotExist", "Email doesn't exist");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(User user)
        {
            if (ModelState.IsValid)
            {
                if (!IsEmailExist(user.Email))
                {
                    Repository.AddUser(user);
                    return View("Login");
                }
                else
                {
                    ModelState.AddModelError("EmailExist", "Email already exist");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult MyWorkshops()
        {
            return View();
        }

        public bool IsEmailExist(string emailID)
        {

            var v = Repository.Users.Where(a => a.Email == emailID).FirstOrDefault();
            return v != null;

        }

        public bool IsPasswordCorrect(string email, string password)
        {
            var v = Repository.Users.Where(a => a.Email == email).FirstOrDefault();
            var p = v.Password;
            if (password == p)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

}