using AuthJwt.Domain;

namespace AuthJwt.Repository
{
    public class UserRepository: IUserRepository
    {

        private readonly List<User> users;

        public UserRepository()
        {
            Role adminRole = new Role(1, "Admin");
            Role stockistRole = new Role(1, "Stockist");

            var userAdmin = new User(1, "admin@enterprise.com", "Admin", "123456");
            userAdmin.SetRoles(adminRole, stockistRole);

            var userStockist = new User(2, "john@enterprise.com", "John Doe", "123456");
            userStockist.SetRoles(stockistRole);

            users = new();
            users.Add(userAdmin);
            users.Add(userStockist);
        }

        public List<User> GetUsers() => users;

        public User GetUser(string email, string password)
            => users.First(x => x.Email.ToLower() == email.ToLower() &&
                         x.Password == password);
    }
}
