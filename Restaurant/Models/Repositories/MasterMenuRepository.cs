using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterMenuRepository : IRepository<MasterMenu>
    {
        private readonly AppDbContext db;

        public MasterMenuRepository(AppDbContext _db)
        {
            db = _db;

        }


        public void Active(int Id, MasterMenu entity)
        {
            entity = Find(Id);
            entity.IsActive = !(entity.IsActive);
            db.SaveChanges();
        }

        public void Add(MasterMenu entity)
        {
            db.MasterMenu.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterMenu entity)
        {
            entity = Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public MasterMenu Find(int Id)
        {
            var data = db.MasterMenu.SingleOrDefault(x=>x.MasterMenuId==Id);
            return data;
        }

        public void Update(int Id, MasterMenu entity)
        {
            db.MasterMenu.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterMenu> View()
        {
            return db.MasterMenu.Where(x => x.IsDelete == false).ToList();
        }

        public IList<MasterMenu> ViewFrontClient()
        {
            return db.MasterMenu.Where(x => x.IsActive == true && x.IsDelete == false).ToList();
        }
    }
}
