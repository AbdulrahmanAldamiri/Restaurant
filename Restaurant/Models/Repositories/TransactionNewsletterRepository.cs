using Microsoft.AspNetCore.Identity;
using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class TransactionNewsletterRepository : IRepository<TransactionNewsletter>
    {
        private readonly AppDbContext db;

        public TransactionNewsletterRepository(AppDbContext _db)
        {
            db = _db;
        }


        public void Active(int Id, TransactionNewsletter entity)
        {
            entity = Find(Id);
            entity.IsActive = !entity.IsActive;
            db.SaveChanges();
        }

        public void Add(TransactionNewsletter entity)
        {
            db.TransactionNewsletter.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id, TransactionNewsletter entity)
        {
            entity = Find(Id);
            entity.IsDelete = true;
            db.SaveChanges();
        }

        public TransactionNewsletter Find(int Id)
        {
            var data = db.TransactionNewsletter.SingleOrDefault(x => x.TransactionNewsletterId == Id);
            return data;
        }

        public void Update(int Id, TransactionNewsletter entity)
        {
            db.TransactionNewsletter.Update(entity);
            db.SaveChanges();
        }

        public IList<TransactionNewsletter> View()
        {
            return db.TransactionNewsletter.Where(x => x.IsDelete == false).ToList();
        }

        public IList<TransactionNewsletter> ViewFrontClient()
        {
            return db.TransactionNewsletter.Where(x => x.IsDelete == false&&x.IsActive==true).ToList();
        }
    }
}
