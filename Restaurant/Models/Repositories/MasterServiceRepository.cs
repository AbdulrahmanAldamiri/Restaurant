using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterServiceRepository : IRepository<MasterService>
    {
        private readonly AppDbContext db;

        public MasterServiceRepository(AppDbContext _db)
        {
            db = _db;
        }


        public void Active(int Id, MasterService entity)
        {
            entity = Find(Id);
            entity.IsActive = !(entity.IsActive);
            db.SaveChanges();
        }

        public void Add(MasterService entity)
        {
            db.MasterService.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterService entity)
        {
            entity=Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public MasterService Find(int Id)
        {
            var data=db.MasterService.SingleOrDefault(x=>x.MasterServiceId==Id);
            return data;
        }

        public void Update(int Id, MasterService entity)
        {
            db.MasterService.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterService> View()
        {
            return db.MasterService.Where(x => x.IsDelete == false).ToList();
        }

        public IList<MasterService> ViewFrontClient()
        {
            return db.MasterService.Where(x => x.IsDelete == false && x.IsActive==true).ToList();
        }
    }
}
