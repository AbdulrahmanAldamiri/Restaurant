using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterSocialMediaRepository : IRepository<MasterSocialMedia>
    {
        private readonly AppDbContext db;

        public MasterSocialMediaRepository(AppDbContext _db)
        {
            db = _db;
        }


        public void Active(int Id, MasterSocialMedia entity)
        {
            entity = Find(Id);
            entity.IsActive = !entity.IsActive;
            db.SaveChanges();
        }

        public void Add(MasterSocialMedia entity)
        {
            db.MasterSocialMedia.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterSocialMedia entity)
        {
            entity=Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public MasterSocialMedia Find(int Id)
        {
            var data = db.MasterSocialMedia.SingleOrDefault(x => x.MasterSocialMediaId == Id);
            return data;
        }

        public void Update(int Id, MasterSocialMedia entity)
        {
            db.MasterSocialMedia.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterSocialMedia> View()
        {
            return db.MasterSocialMedia.Where(x => x.IsDelete == false).ToList();
        }

        public IList<MasterSocialMedia> ViewFrontClient()
        {
            return db.MasterSocialMedia.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
    }
}
