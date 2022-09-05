namespace AuthJwt.Domain
{
    public class Role
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Role(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
