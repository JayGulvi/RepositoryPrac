using Microsoft.AspNetCore.Mvc.ModelBinding;
using RepoPatternPrac.Data;
using RepoPatternPrac.Models;

namespace RepoPatternPrac.Repo
{
    public class UserService : UserRepo
    {
        private readonly ApplicationDbContext db;
        public UserService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void addUsers(Users u)
        {
            db.users.Add(u);
            db.SaveChanges();
        }

        public Users Login(string usernameOrEmail, string Password)
        {
            var users = db.users.FirstOrDefault(reg => reg.UserName == usernameOrEmail || reg.Email == usernameOrEmail && reg.Password == Password);
            
                return users;
            
        }
    }
}

