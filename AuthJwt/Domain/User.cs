namespace AuthJwt.Domain
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public long ProviderId  { get; set; }

        public List<Role> roles { get; } = new();        

        public void SetRoles(params Role[] value)
        {
            roles.AddRange(value);
        }

        public User(long id, string email, string name, string password)
        {
            Id = id;
            Email = email;
            Name = name;
            Password = password;
        }

    }
}
