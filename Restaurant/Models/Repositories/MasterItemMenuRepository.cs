using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterItemMenuRepository : IRepository<MasterItemMenu>
    {
        private readonly AppDbContext db;

        public MasterItemMenuRepository(AppDbContext _db)
        {
            db = _db;
        }


        public void Active(int Id, MasterItemMenu entity)
        {
            entity = Find(Id);
            entity.IsActive = !(entity.IsActive);
            db.SaveChanges();
        }

        public void Add(MasterItemMenu entity)
        {
            db.MasterItemMenu.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterItemMenu entity)
        {
            entity=Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public MasterItemMenu Find(int Id)
        {
            var data = db.MasterItemMenu.Include(x=>x.MasterCategoryMenu).SingleOrDefault(x => x.MasterItemMenuId == Id);
            return data;
        }

        public void Update(int Id, MasterItemMenu entity)
        {
            db.MasterItemMenu.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterItemMenu> View()
        {
            return db.MasterItemMenu.Include(x => x.MasterCategoryMenu).Where(x => x.IsDelete == false).ToList();
        }

        public IList<MasterItemMenu> ViewFrontClient()
        {
            return db.MasterItemMenu.Include(x => x.MasterCategoryMenu).Where(x => x.IsDelete == false && x.IsActive==true).ToList();
        }
    }
}
