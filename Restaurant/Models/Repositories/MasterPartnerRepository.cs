using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterPartnerRepository : IRepository<MasterPartner>
    {
        private readonly AppDbContext db;

        public MasterPartnerRepository(AppDbContext _db)
        {
            db = _db;

        }


        public void Active(int Id, MasterPartner entity)
        {
            entity = Find(Id);
            entity.IsActive=!entity.IsActive;
            db.SaveChanges();
        }

        public void Add(MasterPartner entity)
        {
            db.MasterPartner.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, MasterPartner entity)
        {
            entity=Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public MasterPartner Find(int Id)
        {
            var data = db.MasterPartner.SingleOrDefault(x=>x.MasterPartnerId==Id);
            return data;
        }

        public void Update(int Id, MasterPartner entity)
        {
            db.MasterPartner.Update(entity);
            db.SaveChanges();
        }

        public IList<MasterPartner> View()
        {
            return db.MasterPartner.Where(x => x.IsDelete == false).ToList();
        }

        public IList<MasterPartner> ViewFrontClient()
        {
            return db.MasterPartner.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
    }
}
