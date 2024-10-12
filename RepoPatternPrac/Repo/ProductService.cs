using RepoPatternPrac.Data;
using RepoPatternPrac.Models;

namespace RepoPatternPrac.Repo
{
    public class ProductService:ProductRepo
    {
        private readonly ApplicationDbContext db;
        public ProductService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddProd(Products p)
        {
            db.prod.Add(p);
            db.SaveChanges();
        }

        public List<Products> GetAll()
        {
            var data = db.prod.ToList();
            return data;
        }

        public Products GetById(int id)
        {
            return db.prod.Find(id);
        }

        public void Remove(int id)
        {
            var data = db.prod.Find(id);
            if(data != null)
            {
                db.prod.Remove(data);
                db.SaveChanges();
            }
        }

        public void Update(Products p)
        {
            db.prod.Update(p);
            db.SaveChanges();
        }
    }
}
