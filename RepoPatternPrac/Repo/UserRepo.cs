using RepoPatternPrac.Models;

namespace RepoPatternPrac.Repo
{
    public interface UserRepo
    {
        void addUsers(Users u);
        Users Login(string usernameOrEmail, string password);
    }
}
