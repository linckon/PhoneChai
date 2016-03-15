using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneChai.Model;
using PhoneChai.Repository;
using PhoneChai.ViewModel;

namespace PhoneChai.Service
{
    public class PhoneService
    {
        private BusinessDbContext _dbContext;

        public PhoneService(BusinessDbContext db)
        {
            _dbContext = db;
        }

        public List<PhoneViewModel> GetAll()
        {

            PhoneRepository repository = new PhoneRepository(_dbContext);

            IQueryable<Phone> queryable = repository.GetAll();
            var phoneViewModels = queryable.ToList().Select(x => new PhoneViewModel(x)).ToList();
            return phoneViewModels;
        }
    }
}
