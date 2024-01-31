using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterOfferRepository : IRepository<MasterOffer>
    {
        private readonly AppDbContext db;

        public MasterOfferRepository(AppDbContext _db)
        {
            db = _db;
        }


        public void Active(int Id, MasterOffer entity)
        {
            entity = Find(Id);
            entity.IsActive = !(entity.IsActive);
            db.SaveChanges();
        }

        public void Add(MasterOffer entity)
        {
            db.MasterOffer.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterOffer entity)
        {
            entity=Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public MasterOffer Find(int Id)
        {
            var data = db.MasterOffer.SingleOrDefault(X=>X.MasterOfferId==Id);
            return data;
        }

        public void Update(int Id, MasterOffer entity)
        {
            db.MasterOffer.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterOffer> View()
        {
            return db.MasterOffer.Where(x=>x.IsDelete==false).ToList();
        }

        public IList<MasterOffer> ViewFrontClient()
        {
            return db.MasterOffer.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
    }
}
