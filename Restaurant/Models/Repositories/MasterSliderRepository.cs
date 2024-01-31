using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterSliderRepository : IRepository<MasterSlider>
    {
        private readonly AppDbContext db;

        public MasterSliderRepository(AppDbContext _db)
        {
            db = _db;
        }


        public void Active(int Id, MasterSlider entity)
        {
            entity=Find(Id);
            entity.IsActive = !entity.IsActive;
            db.SaveChanges();
        }

        public void Add(MasterSlider entity)
        {
            db.MasterSlider.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterSlider entity)
        {
            entity = Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public MasterSlider Find(int Id)
        {
            var data = db.MasterSlider.SingleOrDefault(x=>x.MasterSliderId==Id);
            return data;
        }

        public void Update(int Id, MasterSlider entity)
        {
            db.MasterSlider.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterSlider> View()
        {
            return db.MasterSlider.Where(x => x.IsDelete == false).ToList();
        }

        public IList<MasterSlider> ViewFrontClient()
        {
            return db.MasterSlider.Where(x => x.IsDelete == false&&x.IsActive==true).ToList();
        }
    }
}
