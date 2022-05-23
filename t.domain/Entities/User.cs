namespace t.domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }

        public User() { }

        public User(int userID, string userName, string name)
        {
            UserID = userID;
            UserName = userName;
            Name = name;
        }


        public static User Create(int userID, string userName, string name)
        {
            User user = new User(userID, userName, name);
            return user;
        }

    }
}
