using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterWorkingHourRepository : IRepository<MasterWorkingHour>
    {
        private readonly AppDbContext db;

        public MasterWorkingHourRepository(AppDbContext _db)
        {
            db = _db;
        }


        public void Active(int Id, MasterWorkingHour entity)
        {
            entity = Find(Id);
            entity.IsActive = !entity.IsActive;
            db.SaveChanges();
        }

        public void Add(MasterWorkingHour entity)
        {
            db.MasterWorkingHour.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterWorkingHour entity)
        {
            entity = Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public MasterWorkingHour Find(int Id)
        {
            var data = db.MasterWorkingHour.SingleOrDefault(x => x.MasterWorkingHourId == Id);
            return data;
        }

        public void Update(int Id, MasterWorkingHour entity)
        {
            db.MasterWorkingHour.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterWorkingHour> View()
        {
            return db.MasterWorkingHour.Where(x=>x.IsDelete==false).ToList();
        }

        public IList<MasterWorkingHour> ViewFrontClient()
        {
            return db.MasterWorkingHour.Where(x => x.IsDelete == false&&x.IsActive==true).ToList();
        }
    }
}
