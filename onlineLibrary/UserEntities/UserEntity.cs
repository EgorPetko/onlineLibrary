namespace onlineLibrary.UserEntities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public UserPost Post { get; set; }

    }

}
