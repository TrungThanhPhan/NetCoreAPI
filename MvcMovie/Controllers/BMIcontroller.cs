using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(BMI cs)
        {
            double BMI = cs.cannang / (cs.chieucao * cs.chieucao);
            ViewBag.BMI = BMI;
            if (BMI < 18.5)
            ViewBag.Message ="Bạn đang thiếu cân";
            else if (BMI >=18.5 && BMI <=24.9)
            ViewBag.Message ="Bạn đang có cân nặng bình thường";
            else if (BMI >24.9)
            ViewBag.Message ="Bạn đang thừa cân";
            return View();
        }
    }
}