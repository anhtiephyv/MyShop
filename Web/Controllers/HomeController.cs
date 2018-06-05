using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Models;
using Service.Service;
using Data.Base;
namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private AdminService _adminRepository = new AdminService();
        private IDisposable _unitOfWork;
        private UnitOfWork BigunitOfWork = new UnitOfWork();
     //  private AdminService AdminService = new AdminService();
        public HomeController() { }
       
        public ActionResult Index()
        {
            var check2 = BigunitOfWork.AdminRepository.Get().ToList();
            var check = _adminRepository.GetAll().ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}