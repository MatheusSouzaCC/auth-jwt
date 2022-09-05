using AuthJwt.Domain;

namespace AuthJwt.Repository
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(string email, string password);
    }
}
