namespace Library;

public interface IUserHandler
{
    public string GetUser();
    public List<string> GetUsersAccepted();
    public bool IsUserAccepted(string user);
}