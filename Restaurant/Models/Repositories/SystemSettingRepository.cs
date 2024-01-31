using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class SystemSettingRepository : IRepository<SystemSetting>
    {
        private readonly AppDbContext db;

        public SystemSettingRepository(AppDbContext _db)
        {
            db = _db;
        }


        public void Active(int Id, SystemSetting entity)
        {
            entity = Find(Id);
            entity.IsActive = !entity.IsActive;
            db.SaveChanges();
        }

        public void Add(SystemSetting entity)
        {
            db.SystemSetting.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, SystemSetting entity)
        {
            entity = Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public SystemSetting Find(int Id)
        {
            var data = db.SystemSetting.SingleOrDefault(x => x.SystemSettingId == Id);
            return data;
        }

        public void Update(int Id, SystemSetting entity)
        {
            db.SystemSetting.Update(entity);
            db.SaveChanges();
        }

        public IList<SystemSetting> View()
        {
            return db.SystemSetting.Where(x => x.IsDelete == false).ToList();
        }

        public IList<SystemSetting> ViewFrontClient()
        {
            return db.SystemSetting.Where(x => x.IsDelete == false&&x.IsActive==true).ToList();
        }
    }
}
