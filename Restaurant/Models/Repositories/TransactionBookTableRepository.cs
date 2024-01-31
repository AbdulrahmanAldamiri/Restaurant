using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class TransactionBookTableRepository : IRepository<TransactionBookTable>
    {
        private readonly AppDbContext db;

        public TransactionBookTableRepository(AppDbContext _db)
        {
            db = _db;

        }

        public void Active(int Id, TransactionBookTable entity)
        {
            entity = Find(Id);
            entity.IsActive = !entity.IsActive;
            db.SaveChanges();
        }

        public void Add(TransactionBookTable entity)
        {
            db.TransactionBookTable.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, TransactionBookTable entity)
        {
            entity=Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public TransactionBookTable Find(int Id)
        {
            var data = db.TransactionBookTable.SingleOrDefault(x => x.TransactionBookTableId == Id);
            return data;
        }

        public void Update(int Id, TransactionBookTable entity)
        {
            db.TransactionBookTable.Update(entity);
            db.SaveChanges();
        }

        public IList<TransactionBookTable> View()
        {
            return db.TransactionBookTable.Where(x => x.IsDelete == false).ToList();
        }

        public IList<TransactionBookTable> ViewFrontClient()
        {
            return db.TransactionBookTable.Where(x => x.IsDelete == false && x.IsActive == true).ToList();
        }
    }
}
