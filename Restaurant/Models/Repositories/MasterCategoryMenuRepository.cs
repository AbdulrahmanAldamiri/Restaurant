using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterCategoryMenuRepository : IRepository<MasterCategoryMenu>
    {
        private readonly AppDbContext db;

        public MasterCategoryMenuRepository(AppDbContext _db)
        {
            db = _db;
        }
        public void Active(int Id, MasterCategoryMenu entity)
        {
            entity=Find(Id);
            entity.IsActive = !(entity.IsActive);
            db.SaveChanges();
        }
    
        public void Add(MasterCategoryMenu entity)
        {
            db.MasterCategoryMenu.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterCategoryMenu entity)
        {
            entity = Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public void Update(int Id, MasterCategoryMenu entity)
        {
            db.MasterCategoryMenu.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterCategoryMenu> View()
        {
            return db.MasterCategoryMenu.Where(X=>X.IsDelete==false).ToList();
        }

        public IList<MasterCategoryMenu> ViewFrontClient()
        {
            return db.MasterCategoryMenu.Where(x => x.IsActive == true && x.IsDelete == false).ToList();
        }

        public MasterCategoryMenu Find(int Id)
        {
            var data = db.MasterCategoryMenu.SingleOrDefault(x=>x.MasterCategoryMenuId==Id);
            return data;
        }
    }
}
