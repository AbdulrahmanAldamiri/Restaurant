using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class TransactionContactUsRepository : IRepository<TransactionContactUs>
    {
        private readonly AppDbContext db;

        public TransactionContactUsRepository(AppDbContext _db)
        {
            db = _db;
        }

        public void Active(int Id, TransactionContactUs entity)
        {
            entity = Find(Id);
            entity.IsActive = !entity.IsActive;
            db.SaveChanges();
        }

        public void Add(TransactionContactUs entity)
        {
            db.TransactionContactUs.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, TransactionContactUs entity)
        {
            entity = Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public TransactionContactUs Find(int Id)
        {
            var data = db.TransactionContactUs.SingleOrDefault(x => x.TransactionContactUsId == Id);
            return data;
        }

        public void Update(int Id, TransactionContactUs entity)
        {
            db.TransactionContactUs.Update(entity);
            db.SaveChanges();
        }

        public IList<TransactionContactUs> View()
        {
            return db.TransactionContactUs.Where(x => x.IsDelete == false).ToList();
        }

        public IList<TransactionContactUs> ViewFrontClient()
        {
            return db.TransactionContactUs.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
    }
}
