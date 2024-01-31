using Restaurant.Data;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Models.Repositories
{
    public class MasterCustomerReviewRepository : IRepository<MasterCustomerReview>
    {
        public MasterCustomerReviewRepository(AppDbContext _db)
        {
            Db = _db;
        }

        public AppDbContext Db { get; }

        public void Active(int Id, MasterCustomerReview entity)
        {
            entity = Find(Id);
            entity.IsActive = !entity.IsActive;
            Db.SaveChanges();
        }

        public void Add(MasterCustomerReview entity)
        {
            Db.MasterCustomerReview.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int Id, MasterCustomerReview entity)
        {
            entity = Find(Id);
            entity.IsDelete = true;
            Db.SaveChanges();
        }

        public MasterCustomerReview Find(int Id)
        {
            var data= Db.MasterCustomerReview.SingleOrDefault(x=>x.MasterCustomerReviewId==Id);
            return data;
        }

        public void Update(int Id, MasterCustomerReview entity)
        {
            Db.MasterCustomerReview.Update(entity);
            Db.SaveChanges();
        }

        public IList<MasterCustomerReview> View()
        {
            return Db.MasterCustomerReview.Where(x=>x.IsDelete==false).ToList();
        }

        public IList<MasterCustomerReview> ViewFrontClient()
        {
            return Db.MasterCustomerReview.Where(x => x.IsDelete == false&&x.IsActive==true).ToList();
        }
    }
}
