using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Models;
using Data.Base;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IAdminService
    {

        IEnumerable<Admin> GetAll();
    }
    public class AdminService : IAdminService
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private CategorySerivce categoryservice = new CategorySerivce();
        public AdminService()
        {
        }
        public IEnumerable<Admin> GetAll()
        {

            var check = unitOfWork.AdminRepository.Get().ToList();
            var check2 = unitOfWork.CategoryRepository.Get().ToList();
            return check;
        }
    }
}
