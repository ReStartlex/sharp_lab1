public class UsersRepositoryInMemory : IUserRepositoryInMemory
{
    private List<User> Users { get; set; } = new List<User>();

    public List<User> GetData()
    {
        return Users;
    }

    public User GetData(int id)
    {
        return Users.FirstOrDefault(u => u.Id == id);
    }

    public void Add(User user)
    {
        int maxId = Users.Any() ? Users.Max(u => u.Id) : 0;
        user.Id = maxId + 1;
        Users.Add(user);
    }

    public void Delete(int id)
    {
        var user = Users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            Users.Remove(user);
        }
    }

    public void Edit(User user)
    {
        var existingUser = Users.FirstOrDefault(u => u.Id == user.Id);
        if (existingUser != null)
        {
            existingUser.UserName = user.UserName;
            existingUser.Login = user.Login;
        }
    }
}