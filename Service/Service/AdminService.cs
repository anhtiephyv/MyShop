using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Models;
using Service.Base;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IAdminService
    {
        //Admin Add(Admin Product);
        //void Update(Admin Product);
        //Admin Delete(int id);
        IEnumerable<Admin> GetAll();
        //IEnumerable<Admin> GetAll(string keyword);
        //IEnumerable<Admin> GetListProductByCategoryIdPaging(int categoryId, int page, int pageSize, string sort, out int totalRow);
        //Admin GetById(int id);
        //void Save();
    }
    public class AdminService : IAdminService
    {
        private IGenericRepository<Admin> _adminRepository;
        private IDisposable _unitOfWork;
        private UnitOfWork BigunitOfWork = new UnitOfWork();
        public AdminService(IGenericRepository<Admin> adminRepository,
            IDisposable unitOfWork)
        {
            this._adminRepository = adminRepository;
            this._unitOfWork = unitOfWork;
        }
        public  IEnumerable<Admin> GetAll()
        {

            var check =  BigunitOfWork.AdminRepository.Get();
            _unitOfWork.Dispose();
            return check;
        }
    }
}
