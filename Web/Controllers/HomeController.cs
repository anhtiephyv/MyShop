using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Models;
using Service.Service;
using Service.Base;
namespace Web.Controllers
{
    public class HomeController : Controller
    {   private IAdminService _adminRepository;
        private IDisposable _unitOfWork;
        private UnitOfWork BigunitOfWork = new UnitOfWork();
     //   private AdminService AdminService = new AdminService();
        public HomeController() { }
        public HomeController(IAdminService adminRepository,
            IDisposable unitOfWork)
        {
            this._adminRepository = adminRepository;
            this._unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        
        {
            var check = BigunitOfWork.AdminRepository.Get().ToList();
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