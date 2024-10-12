using RepoPatternPrac.Models;

namespace RepoPatternPrac.Repo
{
    public interface ProductRepo
    {
        void AddProd(Products p);
        List<Products> GetAll();
        void Remove(int id);    
        Products GetById(int id);
        void Update(Products p);
    }
}
