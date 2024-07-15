using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.ViewModels;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new()
            {
                new (){ Id = 1, Name = "Stu1"},
                new (){ Id = 2, Name = "Stu2"},
                new (){ Id = 3, Name = "Stu3"},
                new (){ Id = 4, Name = "Stu4"}
            };
            HomeVM vm = new HomeVM();
            vm.GroupName = "PB301";
            vm.Student=students[0];
            vm.Students = students;
            return View(vm);
        }
        public IActionResult About()
        {
            return View();  
        }
    }
}
