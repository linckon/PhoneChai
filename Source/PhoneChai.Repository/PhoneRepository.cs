using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneChai.Model;

namespace PhoneChai.Repository
{
    public abstract class BaseRepository
    {
        public BusinessDbContext Db  { get; set; }

        protected BaseRepository(BusinessDbContext db)
        {
            Db = db;
        }
    }
    public class PhoneRepository:BaseRepository
    {
        public PhoneRepository(BusinessDbContext db):base(db)
        {
            
        }
        public IQueryable<Phone> GetAll()
        {
            return Db.Phones.AsQueryable();
        }
    }
}
