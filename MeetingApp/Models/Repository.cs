namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<Userinfo> _users = new();

        public static List<Userinfo> Users { get { return _users; } }

        static Repository()
        {
            _users.Add(new Userinfo() { Id = 1, Name = "Ali", Email = "abc@gmail.com", Phone = "3333", WillAttend = true });
            _users.Add(new Userinfo() { Id = 2, Name = "Ahmet", Email = "abcd@gmail.com", Phone = "1111", WillAttend = false });
            _users.Add(new Userinfo() { Id = 3, Name = "Canan", Email = "abce@gmail.com", Phone = "2222", WillAttend = true });

        }

        public static void CreatUser(Userinfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static Userinfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
